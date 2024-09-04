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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("https://www.google.co.th/maps/dir/%E0%B9%82%E0%B8%A3%E0%B8%87%E0%B9%80%E0%B8%A3%E0%B8%B5%E0%B8%A2%E0%B8%99%E0%B8%9A%E0%B8%94%E0%B8%B4%E0%B8%99%E0%B8%97%E0%B8%A3%E0%B9%80%E0%B8%94%E0%B8%8A%E0%B8%B2+(%E0%B8%AA%E0%B8%B4%E0%B8%87%E0%B8%AB%E0%B9%8C+%E0%B8%AA%E0%B8%B4%E0%B8%87%E0%B8%AB%E0%B9%80%E0%B8%AA%E0%B8%99%E0%B8%B5)+%E0%B9%92%E2%80%8B+%E0%B8%96%E0%B8%99%E0%B8%99+%E0%B8%99%E0%B8%A7%E0%B8%A1%E0%B8%B4%E0%B8%99%E0%B8%97%E0%B8%A3%E0%B9%8C+%E0%B9%81%E0%B8%82%E0%B8%A7%E0%B8%87%E0%B8%84%E0%B8%A5%E0%B8%AD%E0%B8%87%E0%B8%81%E0%B8%B8%E0%B9%88%E0%B8%A1+%E0%B9%80%E0%B8%82%E0%B8%95%E0%B8%9A%E0%B8%B6%E0%B8%87%E0%B8%81%E0%B8%B8%E0%B9%88%E0%B8%A1+%E0%B8%81%E0%B8%A3%E0%B8%B8%E0%B8%87%E0%B9%80%E0%B8%97%E0%B8%9E%E0%B8%A1%E0%B8%AB%E0%B8%B2%E0%B8%99%E0%B8%84%E0%B8%A3/%E0%B9%81%E0%B8%9F%E0%B8%8A%E0%B8%B1%E0%B9%88%E0%B8%99%E0%B9%84%E0%B8%AD%E0%B8%AA%E0%B9%8C%E0%B9%81%E0%B8%A5%E0%B8%99%E0%B8%94%E0%B9%8C+%E0%B8%96%E0%B8%99%E0%B8%99+%E0%B8%A3%E0%B8%B2%E0%B8%A1%E0%B8%AD%E0%B8%B4%E0%B8%99%E0%B8%97%E0%B8%A3%E0%B8%B2+%E0%B9%81%E0%B8%82%E0%B8%A7%E0%B8%87%E0%B8%84%E0%B8%B1%E0%B8%99%E0%B8%99%E0%B8%B2%E0%B8%A2%E0%B8%B2%E0%B8%A7+%E0%B9%80%E0%B8%82%E0%B8%95%E0%B8%84%E0%B8%B1%E0%B8%99%E0%B8%99%E0%B8%B2%E0%B8%A2%E0%B8%B2%E0%B8%A7+%E0%B8%81%E0%B8%A3%E0%B8%B8%E0%B8%87%E0%B9%80%E0%B8%97%E0%B8%9E%E0%B8%A1%E0%B8%AB%E0%B8%B2%E0%B8%99%E0%B8%84%E0%B8%A3/@13.823188,100.6649694,15.25z/data=!4m14!4m13!1m5!1m1!1s0x311d6250cfd8a5e7:0x9cd07124482ee5a5!2m2!1d100.6556037!2d13.8146542!1m5!1m1!1s0x311d630411c79e77:0x8ba150c74d52fc1b!2m2!1d100.6794462!2d13.8261789!3e3?hl=th&entry=ttu");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VDO f2 = new VDO();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
        }
    }
}