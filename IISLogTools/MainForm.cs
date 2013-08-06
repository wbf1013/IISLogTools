using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace IISLogTools
{
    public partial class MainForm : Form
    {
        public DataTable dt = null;
        public Thread currentThread = null;
        public string[] logtitle;
        public string logfilename;

        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void 选择日志文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDial = new OpenFileDialog();
            fileDial.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            fileDial.RestoreDirectory = true;
            if (fileDial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                logfilename = fileDial.FileName;
                using (var sr = new StreamReader(logfilename, Encoding.Default))
                {
                    string line = sr.ReadLine();
                    if (line != "#Software: Microsoft Internet Information Services 6.0")
                    {
                        MessageBox.Show("此文件无效!");
                    }
                    else
                    {
                        line = sr.ReadLine();
                        if (line != "#Version: 1.0")
                        {
                            MessageBox.Show("版本出错!");
                        }
                        else
                        {
                            line = sr.ReadLine();
                            if (line.Substring(0, 6) != "#Date:")
                            {
                                MessageBox.Show("读取创建时间失败!");
                            }
                            else
                            {
                                var s = line.Substring(6);
                                DateTime dtime;
                                try
                                {
                                    dtime = DateTime.Parse(s);
                                }
                                catch
                                {
                                    MessageBox.Show("读取时间失败!");
                                    return;
                                }
                                dtime = dtime.AddHours(8.0);
                                this.startTime.Value = dtime;
                                this.endTime.Value = dtime;
                                line = sr.ReadLine();
                                if (line.Substring(0, 8) != "#Fields:")
                                {
                                    MessageBox.Show("读取字段出错!");
                                }
                                else
                                {
                                    line = line.Substring(8).Trim();
                                    logtitle = line.Split(new char[] { ' ' });
                                    if (dt != null)
                                        dt.Clear();
                                    dt = new DataTable();
                                    this.dataGridView1.DataSource = dt;
                                    info1.Items.Clear();
                                    info2.Items.Clear();
                                    info3.Items.Clear();
                                    info4.Items.Clear();
                                    for (int i = 0; i < logtitle.Length; i++)
                                    {
                                        dt.Columns.Add(logtitle[i]);
                                        ListItem item = new ListItem
                                        {
                                            ID = logtitle[i],
                                            Name = i.ToString()
                                        };
                                        info1.Items.Add(item);
                                        info2.Items.Add(item);
                                        info3.Items.Add(item);
                                        info4.Items.Add(item);
                                    }
                                    info1.DisplayMember = "ID";
                                    info1.ValueMember = "Name";
                                    info1.SelectedIndex = 0;
                                    info2.DisplayMember = "ID";
                                    info2.ValueMember = "Name";
                                    info2.SelectedIndex = 0;
                                    info3.DisplayMember = "ID";
                                    info3.ValueMember = "Name";
                                    info3.SelectedIndex = 0;
                                    info4.DisplayMember = "ID";
                                    info4.ValueMember = "Name";
                                    info4.SelectedIndex = 0;
                                    var ii = 0;
                                    while (ii < 50 && (line = sr.ReadLine()) != null)
                                    {
                                        var arr = line.Split(new[] { ' ' });
                                        if (arr.Length == logtitle.Length)
                                        {
                                            DateTime datetime = DateTime.Parse(arr[0] + " " + arr[1]).AddHours(8.0);
                                            arr[0] = datetime.ToString("yyyy-MM-dd");
                                            arr[1] = datetime.ToString("HH:mm:ss");
                                            var dr = dt.NewRow();
                                            for (int i = 0; i < logtitle.Length; i++)
                                            {
                                                dr[logtitle[i]] = arr[i];
                                            }
                                            dt.Rows.Add(dr);
                                        }
                                        ii++;
                                    }
                                    tabControl1.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.lblMsg.Text = "正在搜寻记录...";
            this.dt.Clear();
            this.btnStart.Enabled = false;
            this.btnPause.Enabled = true;
            this.btnStop.Enabled = true;
            this.grpCon.Enabled = false;
            this.currentThread = new Thread(run);
            currentThread.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (currentThread.ThreadState == ThreadState.Running)
            {
                btnPause.Text = "继续";
                currentThread.Suspend();
                btnStop.Enabled = false;
            }
            else
            {
                btnPause.Text = "暂停";
                currentThread.Resume();
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            currentThread.Abort();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            grpCon.Enabled = true;
        }

        private void run()
        {
            FileInfo fileinfo = new FileInfo(this.logfilename);
            int num = (int)fileinfo.Length;
            int num2 = 0;
            this.progressBar1.Maximum = num;
            this.progressBar1.Value = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = num / 100;
            int num6 = 1;
            using (StreamReader streamReader = new StreamReader(this.logfilename, Encoding.Default))
            {
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    num3++;
                    string[] array = text.Split(new char[]
			        {
				        ' '
			        });
                    if (array.Length == this.logtitle.Length)
                    {
                        DateTime t = DateTime.Parse(array[0] + " " + array[1]).AddHours(8.0);
                        bool flag = true;
                        if (this.chkStartTime.Checked)
                        {
                            if (t < this.startTime.Value)
                            {
                                flag = false;
                            }
                        }
                        if (this.chkEndTime.Checked)
                        {
                            if (t > this.endTime.Value)
                            {
                                break;
                            }
                        }
                        bool flag2;
                        if (this.checksearch1.Checked)
                        {
                            if (this.paicu1.Checked)
                            {
                                if (chbreg1.Checked)
                                {
                                    flag2 = !Regex.IsMatch(array[int.Parse(this.info1.SelectedItem.ToString())], keyword1.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag2 = (array[int.Parse(this.info1.SelectedItem.ToString())].ToLower().IndexOf(this.keyword1.Text.Trim().ToLower()) == -1);
                                }
                            }
                            else
                            {
                                if (chbreg1.Checked)
                                {
                                    flag2 = Regex.IsMatch(array[int.Parse(info1.SelectedItem.ToString())], keyword1.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag2 = (array[int.Parse(this.info1.SelectedItem.ToString())].ToLower().IndexOf(keyword1.Text.Trim().ToLower()) >= 0);
                                }
                            }
                        }
                        else
                        {
                            flag2 = true;
                        }
                        bool flag3;
                        if (this.checksearch2.Checked)
                        {
                            if (this.paicu2.Checked)
                            {
                                if (this.chbreg2.Checked)
                                {

                                    flag3 = !Regex.IsMatch(array[int.Parse(this.info2.SelectedItem.ToString())], this.keyword2.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag3 = (array[int.Parse(this.info2.SelectedItem.ToString())].ToLower().IndexOf(this.keyword2.Text.Trim().ToLower()) == -1);
                                }
                            }
                            else
                            {
                                if (this.chbreg2.Checked)
                                {

                                    flag3 = Regex.IsMatch(array[int.Parse(this.info2.SelectedItem.ToString())], this.keyword2.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag3 = (array[int.Parse(this.info2.SelectedItem.ToString())].ToLower().IndexOf(this.keyword2.Text.Trim().ToLower()) >= 0);
                                }
                            }
                        }
                        else
                        {
                            flag3 = true;
                        }
                        bool flag4;
                        if (this.checksearch3.Checked)
                        {
                            if (this.paicu3.Checked)
                            {
                                if (this.chbreg3.Checked)
                                {
                                    flag4 = !Regex.IsMatch(array[int.Parse(this.info3.SelectedItem.ToString())], this.keyword3.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag4 = (array[int.Parse(this.info3.SelectedItem.ToString())].ToLower().IndexOf(this.keyword3.Text.Trim().ToLower()) == -1);
                                }
                            }
                            else
                            {
                                if (this.chbreg3.Checked)
                                {
                                    flag4 = Regex.IsMatch(array[int.Parse(this.info3.SelectedItem.ToString())], this.keyword3.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag4 = (array[int.Parse(this.info3.SelectedItem.ToString())].ToLower().IndexOf(this.keyword3.Text.Trim().ToLower()) >= 0);
                                }
                            }
                        }
                        else
                        {
                            flag4 = true;
                        }
                        bool flag5;
                        if (this.checksearch4.Checked)
                        {
                            if (this.paicu4.Checked)
                            {
                                if (this.chbreg4.Checked)
                                {
                                    flag5 = !Regex.IsMatch(array[int.Parse(this.info4.SelectedItem.ToString())], this.keyword4.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag5 = (array[int.Parse(this.info4.SelectedItem.ToString())].ToLower().IndexOf(this.keyword4.Text.Trim().ToLower()) == -1);
                                }
                            }
                            else
                            {
                                if (this.chbreg4.Checked)
                                {
                                    flag5 = Regex.IsMatch(array[int.Parse(this.info4.SelectedItem.ToString())], this.keyword4.Text.Trim(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                }
                                else
                                {
                                    flag5 = (array[int.Parse(this.info4.SelectedItem.ToString())].ToLower().IndexOf(this.keyword4.Text.Trim().ToLower()) >= 0);
                                }
                            }
                        }
                        else
                        {
                            flag5 = true;
                        }
                        if (flag && flag2 && flag3 && flag4 && flag5)
                        {
                            array[0] = t.ToString("yyyy-MM-dd");
                            array[1] = t.ToString("HH:mm:ss");
                            DataRow dataRow = this.dt.NewRow();
                            for (int i = 0; i < this.logtitle.Length; i++)
                            {
                                dataRow[this.logtitle[i]] = array[i];
                            }
                            this.dt.Rows.Add(dataRow);
                            num4++;
                        }
                    }
                    num2 += text.Length;
                    if (num2 > num5 * num6)
                    {
                        num6++;
                        this.lblMsg.Text = string.Concat(new object[]
				        {
					        "已查询",
					        num3,
					        "行,找到",
					        num4,
					        "条符合信息"
				        });
                        this.progressBar1.Value = num2;
                    }
                }
                this.progressBar1.Value = 0;
                this.btnStart.Enabled = true;
                this.btnPause.Enabled = false;
                this.btnStop.Enabled = false;
                this.grpCon.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void info1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checksearch1_CheckedChanged(object sender, EventArgs e)
        {

            info1.Enabled = checksearch1.Checked;
            keyword1.Enabled = checksearch1.Checked;
            paicu1.Enabled = checksearch1.Checked;
            chbreg1.Enabled = checksearch1.Checked;

        }

        private void checksearch2_CheckedChanged(object sender, EventArgs e)
        {
            info2.Enabled = checksearch2.Checked;
            keyword2.Enabled = checksearch2.Checked;
            paicu2.Enabled = checksearch2.Checked;
            chbreg2.Enabled = checksearch2.Checked;
        }

        private void checksearch3_CheckedChanged(object sender, EventArgs e)
        {
            info3.Enabled = checksearch3.Checked;
            keyword3.Enabled = checksearch3.Checked;
            paicu3.Enabled = checksearch3.Checked;
            chbreg3.Enabled = checksearch3.Checked;
        }

        private void checksearch4_CheckedChanged(object sender, EventArgs e)
        {
            info4.Enabled = checksearch4.Checked;
            keyword4.Enabled = checksearch4.Checked;
            paicu4.Enabled = checksearch4.Checked;
            chbreg4.Enabled = checksearch4.Checked;
        }
    }
}
