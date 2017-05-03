using NotifyByBicycle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private DocumentScriptingObject _dso;

        /// <summary>
        /// 加载默认显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmBY_Load(object sender, EventArgs e)
        {

            this._dso = new DocumentScriptingObject();
            this.wbmap.ObjectForScripting = _dso;

            string s = System.AppDomain.CurrentDomain.BaseDirectory + "map.html";
            //webBrowser1.Url = new Uri(s);
            this.wbmap.Navigate(s);
            wbmap.Navigated += new WebBrowserNavigatedEventHandler(wbmap_Navigated);

        }

        private void wbmap_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser wb = sender as WebBrowser;
            mshtml.HTMLWindow2 win = (mshtml.HTMLWindow2)wb.Document.Window.DomWindow;
            //win.execScript
            //        (
            //            @"
            //                var PeripheringDeviceJs = window.external.PeripheringDevice;
            //                alert('C# exec JavaScript');
            //            "
            //            , "javascript"
            //        );


        }

        /// <summary>
        /// 搜索自行车
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string addr = txtaddr.Text;
            object[] args = new object[1];
            args[0] = addr;
            var peripheringDevice = _dso.PeripheringDevice;
            var listener = peripheringDevice.OnExternalEvent;

            listener.GetType().InvokeMember(
                ""
                , BindingFlags.InvokeMethod
                , null
                , listener
                , args
           );


        }
    }
}
