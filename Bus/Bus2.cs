using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Bus_Route
{
    public partial class VDO : Form
    {
        public VDO()
        {
            InitializeComponent();
        }
      

        private void VDO_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("http://pntdev.ddns.net:30080/BD2_Blog/Forum/?user=Prin");
        }

        private void chromiumWebBrowser1_Click(object sender, EventArgs e)
        {
        }

        private void VDO_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }
    }
}