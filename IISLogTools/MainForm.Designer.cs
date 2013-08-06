namespace IISLogTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择日志文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.日志提取 = new System.Windows.Forms.TabPage();
            this.lblMsg = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpCon = new System.Windows.Forms.GroupBox();
            this.info2 = new System.Windows.Forms.ComboBox();
            this.chbreg2 = new System.Windows.Forms.CheckBox();
            this.keyword2 = new System.Windows.Forms.TextBox();
            this.keyword4 = new System.Windows.Forms.TextBox();
            this.chbreg4 = new System.Windows.Forms.CheckBox();
            this.keyword3 = new System.Windows.Forms.TextBox();
            this.chbreg3 = new System.Windows.Forms.CheckBox();
            this.info4 = new System.Windows.Forms.ComboBox();
            this.keyword1 = new System.Windows.Forms.TextBox();
            this.info3 = new System.Windows.Forms.ComboBox();
            this.chbreg1 = new System.Windows.Forms.CheckBox();
            this.info1 = new System.Windows.Forms.ComboBox();
            this.paicu4 = new System.Windows.Forms.CheckBox();
            this.paicu2 = new System.Windows.Forms.CheckBox();
            this.paicu3 = new System.Windows.Forms.CheckBox();
            this.checksearch4 = new System.Windows.Forms.CheckBox();
            this.checksearch2 = new System.Windows.Forms.CheckBox();
            this.checksearch3 = new System.Windows.Forms.CheckBox();
            this.paicu1 = new System.Windows.Forms.CheckBox();
            this.checksearch1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.chkEndTime = new System.Windows.Forms.CheckBox();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.chkStartTime = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.日志提取.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择日志文件ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 选择日志文件ToolStripMenuItem
            // 
            this.选择日志文件ToolStripMenuItem.Name = "选择日志文件ToolStripMenuItem";
            this.选择日志文件ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.选择日志文件ToolStripMenuItem.Text = "选择日志文件...";
            this.选择日志文件ToolStripMenuItem.Click += new System.EventHandler(this.选择日志文件ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.日志提取);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(10, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 442);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // 日志提取
            // 
            this.日志提取.Controls.Add(this.lblMsg);
            this.日志提取.Controls.Add(this.dataGridView1);
            this.日志提取.Controls.Add(this.progressBar1);
            this.日志提取.Controls.Add(this.btnStop);
            this.日志提取.Controls.Add(this.btnPause);
            this.日志提取.Controls.Add(this.btnStart);
            this.日志提取.Controls.Add(this.grpCon);
            this.日志提取.Location = new System.Drawing.Point(4, 22);
            this.日志提取.Name = "日志提取";
            this.日志提取.Padding = new System.Windows.Forms.Padding(3);
            this.日志提取.Size = new System.Drawing.Size(883, 416);
            this.日志提取.TabIndex = 0;
            this.日志提取.Text = "日志提取";
            this.日志提取.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(194, 148);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 12);
            this.lblMsg.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(864, 238);
            this.dataGridView1.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(446, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(425, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(133, 143);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(53, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(69, 142);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(58, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 142);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpCon
            // 
            this.grpCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCon.Controls.Add(this.info2);
            this.grpCon.Controls.Add(this.chbreg2);
            this.grpCon.Controls.Add(this.keyword2);
            this.grpCon.Controls.Add(this.keyword4);
            this.grpCon.Controls.Add(this.chbreg4);
            this.grpCon.Controls.Add(this.keyword3);
            this.grpCon.Controls.Add(this.chbreg3);
            this.grpCon.Controls.Add(this.info4);
            this.grpCon.Controls.Add(this.keyword1);
            this.grpCon.Controls.Add(this.info3);
            this.grpCon.Controls.Add(this.chbreg1);
            this.grpCon.Controls.Add(this.info1);
            this.grpCon.Controls.Add(this.paicu4);
            this.grpCon.Controls.Add(this.paicu2);
            this.grpCon.Controls.Add(this.paicu3);
            this.grpCon.Controls.Add(this.checksearch4);
            this.grpCon.Controls.Add(this.checksearch2);
            this.grpCon.Controls.Add(this.checksearch3);
            this.grpCon.Controls.Add(this.paicu1);
            this.grpCon.Controls.Add(this.checksearch1);
            this.grpCon.Controls.Add(this.groupBox2);
            this.grpCon.Location = new System.Drawing.Point(7, 7);
            this.grpCon.Name = "grpCon";
            this.grpCon.Size = new System.Drawing.Size(870, 128);
            this.grpCon.TabIndex = 0;
            this.grpCon.TabStop = false;
            this.grpCon.Text = "设置提取条件";
            // 
            // info2
            // 
            this.info2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.info2.Enabled = false;
            this.info2.FormattingEnabled = true;
            this.info2.Location = new System.Drawing.Point(618, 71);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(121, 20);
            this.info2.TabIndex = 7;
            this.info2.SelectedIndexChanged += new System.EventHandler(this.info1_SelectedIndexChanged);
            // 
            // chbreg2
            // 
            this.chbreg2.AutoSize = true;
            this.chbreg2.Enabled = false;
            this.chbreg2.Location = new System.Drawing.Point(570, 77);
            this.chbreg2.Name = "chbreg2";
            this.chbreg2.Size = new System.Drawing.Size(48, 16);
            this.chbreg2.TabIndex = 6;
            this.chbreg2.Text = "正则";
            this.chbreg2.UseVisualStyleBackColor = true;
            // 
            // keyword2
            // 
            this.keyword2.Location = new System.Drawing.Point(743, 71);
            this.keyword2.Name = "keyword2";
            this.keyword2.Size = new System.Drawing.Size(121, 21);
            this.keyword2.TabIndex = 5;
            // 
            // keyword4
            // 
            this.keyword4.Location = new System.Drawing.Point(743, 97);
            this.keyword4.Name = "keyword4";
            this.keyword4.Size = new System.Drawing.Size(121, 21);
            this.keyword4.TabIndex = 5;
            // 
            // chbreg4
            // 
            this.chbreg4.AutoSize = true;
            this.chbreg4.Enabled = false;
            this.chbreg4.Location = new System.Drawing.Point(570, 102);
            this.chbreg4.Name = "chbreg4";
            this.chbreg4.Size = new System.Drawing.Size(48, 16);
            this.chbreg4.TabIndex = 4;
            this.chbreg4.Text = "正则";
            this.chbreg4.UseVisualStyleBackColor = true;
            // 
            // keyword3
            // 
            this.keyword3.Location = new System.Drawing.Point(314, 98);
            this.keyword3.Name = "keyword3";
            this.keyword3.Size = new System.Drawing.Size(100, 21);
            this.keyword3.TabIndex = 5;
            // 
            // chbreg3
            // 
            this.chbreg3.AutoSize = true;
            this.chbreg3.Enabled = false;
            this.chbreg3.Location = new System.Drawing.Point(141, 103);
            this.chbreg3.Name = "chbreg3";
            this.chbreg3.Size = new System.Drawing.Size(48, 16);
            this.chbreg3.TabIndex = 4;
            this.chbreg3.Text = "正则";
            this.chbreg3.UseVisualStyleBackColor = true;
            // 
            // info4
            // 
            this.info4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.info4.Enabled = false;
            this.info4.FormattingEnabled = true;
            this.info4.Location = new System.Drawing.Point(618, 99);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(121, 20);
            this.info4.TabIndex = 3;
            this.info4.SelectedIndexChanged += new System.EventHandler(this.info1_SelectedIndexChanged);
            // 
            // keyword1
            // 
            this.keyword1.Location = new System.Drawing.Point(314, 71);
            this.keyword1.Name = "keyword1";
            this.keyword1.Size = new System.Drawing.Size(100, 21);
            this.keyword1.TabIndex = 5;
            // 
            // info3
            // 
            this.info3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.info3.Enabled = false;
            this.info3.FormattingEnabled = true;
            this.info3.Location = new System.Drawing.Point(189, 100);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(121, 20);
            this.info3.TabIndex = 3;
            this.info3.SelectedIndexChanged += new System.EventHandler(this.info1_SelectedIndexChanged);
            // 
            // chbreg1
            // 
            this.chbreg1.AutoSize = true;
            this.chbreg1.Enabled = false;
            this.chbreg1.Location = new System.Drawing.Point(141, 76);
            this.chbreg1.Name = "chbreg1";
            this.chbreg1.Size = new System.Drawing.Size(48, 16);
            this.chbreg1.TabIndex = 4;
            this.chbreg1.Text = "正则";
            this.chbreg1.UseVisualStyleBackColor = true;
            // 
            // info1
            // 
            this.info1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.info1.Enabled = false;
            this.info1.FormattingEnabled = true;
            this.info1.Location = new System.Drawing.Point(189, 73);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(121, 20);
            this.info1.TabIndex = 3;
            this.info1.SelectedIndexChanged += new System.EventHandler(this.info1_SelectedIndexChanged);
            // 
            // paicu4
            // 
            this.paicu4.AutoSize = true;
            this.paicu4.Enabled = false;
            this.paicu4.Location = new System.Drawing.Point(525, 102);
            this.paicu4.Name = "paicu4";
            this.paicu4.Size = new System.Drawing.Size(48, 16);
            this.paicu4.TabIndex = 2;
            this.paicu4.Text = "排除";
            this.paicu4.UseVisualStyleBackColor = true;
            // 
            // paicu2
            // 
            this.paicu2.AutoSize = true;
            this.paicu2.Enabled = false;
            this.paicu2.Location = new System.Drawing.Point(526, 77);
            this.paicu2.Name = "paicu2";
            this.paicu2.Size = new System.Drawing.Size(48, 16);
            this.paicu2.TabIndex = 2;
            this.paicu2.Text = "排除";
            this.paicu2.UseVisualStyleBackColor = true;
            // 
            // paicu3
            // 
            this.paicu3.AutoSize = true;
            this.paicu3.Enabled = false;
            this.paicu3.Location = new System.Drawing.Point(96, 103);
            this.paicu3.Name = "paicu3";
            this.paicu3.Size = new System.Drawing.Size(48, 16);
            this.paicu3.TabIndex = 2;
            this.paicu3.Text = "排除";
            this.paicu3.UseVisualStyleBackColor = true;
            // 
            // checksearch4
            // 
            this.checksearch4.AutoSize = true;
            this.checksearch4.Location = new System.Drawing.Point(443, 102);
            this.checksearch4.Name = "checksearch4";
            this.checksearch4.Size = new System.Drawing.Size(84, 16);
            this.checksearch4.TabIndex = 1;
            this.checksearch4.Text = "提取条件四";
            this.checksearch4.UseVisualStyleBackColor = true;
            this.checksearch4.CheckedChanged += new System.EventHandler(this.checksearch4_CheckedChanged);
            // 
            // checksearch2
            // 
            this.checksearch2.AutoSize = true;
            this.checksearch2.Location = new System.Drawing.Point(444, 77);
            this.checksearch2.Name = "checksearch2";
            this.checksearch2.Size = new System.Drawing.Size(84, 16);
            this.checksearch2.TabIndex = 1;
            this.checksearch2.Text = "提取条件二";
            this.checksearch2.UseVisualStyleBackColor = true;
            this.checksearch2.CheckedChanged += new System.EventHandler(this.checksearch2_CheckedChanged);
            // 
            // checksearch3
            // 
            this.checksearch3.AutoSize = true;
            this.checksearch3.Location = new System.Drawing.Point(14, 103);
            this.checksearch3.Name = "checksearch3";
            this.checksearch3.Size = new System.Drawing.Size(84, 16);
            this.checksearch3.TabIndex = 1;
            this.checksearch3.Text = "提取条件三";
            this.checksearch3.UseVisualStyleBackColor = true;
            this.checksearch3.CheckedChanged += new System.EventHandler(this.checksearch3_CheckedChanged);
            // 
            // paicu1
            // 
            this.paicu1.AutoSize = true;
            this.paicu1.Enabled = false;
            this.paicu1.Location = new System.Drawing.Point(96, 76);
            this.paicu1.Name = "paicu1";
            this.paicu1.Size = new System.Drawing.Size(48, 16);
            this.paicu1.TabIndex = 2;
            this.paicu1.Text = "排除";
            this.paicu1.UseVisualStyleBackColor = true;
            // 
            // checksearch1
            // 
            this.checksearch1.AutoSize = true;
            this.checksearch1.Location = new System.Drawing.Point(14, 76);
            this.checksearch1.Name = "checksearch1";
            this.checksearch1.Size = new System.Drawing.Size(84, 16);
            this.checksearch1.TabIndex = 1;
            this.checksearch1.Text = "提取条件一";
            this.checksearch1.UseVisualStyleBackColor = true;
            this.checksearch1.CheckedChanged += new System.EventHandler(this.checksearch1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.endTime);
            this.groupBox2.Controls.Add(this.chkEndTime);
            this.groupBox2.Controls.Add(this.startTime);
            this.groupBox2.Controls.Add(this.chkStartTime);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(7, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择提取时间";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(604, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "交集";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(550, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "并集";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(368, 16);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(168, 21);
            this.endTime.TabIndex = 3;
            // 
            // chkEndTime
            // 
            this.chkEndTime.AutoSize = true;
            this.chkEndTime.Location = new System.Drawing.Point(275, 21);
            this.chkEndTime.Name = "chkEndTime";
            this.chkEndTime.Size = new System.Drawing.Size(96, 16);
            this.chkEndTime.TabIndex = 2;
            this.chkEndTime.Text = "选择结束时间";
            this.chkEndTime.UseVisualStyleBackColor = true;
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(100, 16);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(157, 21);
            this.startTime.TabIndex = 1;
            // 
            // chkStartTime
            // 
            this.chkStartTime.AutoSize = true;
            this.chkStartTime.Location = new System.Drawing.Point(7, 21);
            this.chkStartTime.Name = "chkStartTime";
            this.chkStartTime.Size = new System.Drawing.Size(96, 16);
            this.chkStartTime.TabIndex = 0;
            this.chkStartTime.Text = "选择开始时间";
            this.chkStartTime.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(883, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "统计分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "IIS Log 分析工具 -- By Luke";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.日志提取.ResumeLayout(false);
            this.日志提取.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCon.ResumeLayout(false);
            this.grpCon.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择日志文件ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 日志提取;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpCon;
        private System.Windows.Forms.ComboBox info2;
        private System.Windows.Forms.CheckBox chbreg2;
        private System.Windows.Forms.TextBox keyword2;
        private System.Windows.Forms.TextBox keyword4;
        private System.Windows.Forms.CheckBox chbreg4;
        private System.Windows.Forms.TextBox keyword3;
        private System.Windows.Forms.CheckBox chbreg3;
        private System.Windows.Forms.ComboBox info4;
        private System.Windows.Forms.TextBox keyword1;
        private System.Windows.Forms.ComboBox info3;
        private System.Windows.Forms.CheckBox chbreg1;
        private System.Windows.Forms.ComboBox info1;
        private System.Windows.Forms.CheckBox paicu4;
        private System.Windows.Forms.CheckBox paicu2;
        private System.Windows.Forms.CheckBox paicu3;
        private System.Windows.Forms.CheckBox checksearch4;
        private System.Windows.Forms.CheckBox checksearch2;
        private System.Windows.Forms.CheckBox checksearch3;
        private System.Windows.Forms.CheckBox paicu1;
        private System.Windows.Forms.CheckBox checksearch1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.CheckBox chkEndTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.CheckBox chkStartTime;
        private System.Windows.Forms.Label lblMsg;
    }
}

