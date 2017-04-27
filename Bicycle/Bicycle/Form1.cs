using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle
{
    public partial class fmBY : Form
    {
        public fmBY()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载默认显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmBY_Load(object sender, EventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            Uri addr = new Uri(path + "map.html");
            this.wbmap.Url = addr;

        }
    }
}
