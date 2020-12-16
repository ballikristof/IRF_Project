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
using IRF_projekt.Entities;

namespace IRF_projekt
{
    public partial class Form1 : Form
    {
        public int counter = 300;
        BindingList<cars> Auto_data = new BindingList<cars>();
        public Form1()
        {
            InitializeComponent();
            exit_timer.Enabled = true;
            exit_timer.Interval = 1000;
            exit_timer.Start();
            lblexit.Text = counter.ToString();
            XmlDocument xml = new XmlDocument();
            xml.Load("autok.xml");
            dataGridView1.DataSource = Auto_data;

            foreach (XmlElement element in xml.DocumentElement)
            {
                var car = new cars();
                Auto_data.Add(car);

                car.Gyártó = element.GetAttribute("marka");

                var childElement = (XmlElement)element.ChildNodes[0];
                car.Típus = childElement.GetAttribute("tipus");
                car.Szín = childElement.GetAttribute("szin");
                car.Gyártás_éve = childElement.GetAttribute("evjarat");
            }
        }

        private void exit_timer_Tick(object sender, EventArgs e)
        {
            counter--;
            lblexit.Text = counter.ToString();
            if (counter == 0)
                this.Close();
                
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;


        }
    }
}
