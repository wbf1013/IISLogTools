using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IISLogTools
{
    /// <summary>
    /// ComboBox 绑定数据集
    /// </summary>
    public class ListItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
