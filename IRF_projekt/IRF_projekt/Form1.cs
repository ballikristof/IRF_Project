using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace IRF_projekt
{
    public partial class Form1 : Form
    {
        public int counter = 300;
        public Form1()
        {
            InitializeComponent();
            exit_timer.Enabled = true;
            exit_timer.Interval = 1000;
            exit_timer.Start();
            lblexit.Text = counter.ToString();
            
            
        }

        private void xmlbetoltes()
        {

        }

        private void exit_timer_Tick(object sender, EventArgs e)
        {
            counter--;
            lblexit.Text = counter.ToString();
            if (counter == 0)
                this.Close();
                
        }
    }
}
