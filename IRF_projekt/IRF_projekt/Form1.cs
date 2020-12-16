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
        BindingList<people> People_data = new BindingList<people>();
        BindingList<store> Store_data = new BindingList<store>();
        public Form1()
        {
            InitializeComponent();
            exit_timer.Enabled = true;
            exit_timer.Interval = 1000;
            exit_timer.Start();
            lblexit.Text = counter.ToString();
            
        }

        private void exit_timer_Tick(object sender, EventArgs e)
        {
            counter--;
            lblexit.Text = counter.ToString();
            if (counter == 0)
                this.Close();
            
            
        }

        private void car_btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    foreach (cars car in Auto_data)
                    {
                        sw.WriteLine("{0};{1};{2};{3}",
                        car.Gyártó, car.Típus, car.Szín, car.Gyártás_éve);
                    }
                }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            counter = 300;
        }

        private void car_btn_Click(object sender, EventArgs e)
        {

            Auto_data.Clear();
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

        private void people_btn_Click(object sender, EventArgs e)
        {
            People_data.Clear();
            XmlDocument xml = new XmlDocument();
            xml.Load("emberek.xml");
            dataGridView1.DataSource = People_data;


            foreach (XmlElement element in xml.DocumentElement)
            {
                var person = new people();
                People_data.Add(person);

                person.Életkor = element.GetAttribute("kor");

                var childElement = (XmlElement)element.ChildNodes[0];
                person.Vezetéknév = childElement.GetAttribute("vezeteknev");
                person.Keresztnév = childElement.GetAttribute("keresztnev");
                person.Email = childElement.GetAttribute("email");
            }
        }

        private void people_btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    foreach (people people in People_data)
                    {
                        sw.WriteLine("{0};{1};{2};{3}",
                        people.Életkor, people.Vezetéknév, people.Keresztnév, people.Email);
                    }
                }
            }
        }

        private void store_btn_Click(object sender, EventArgs e)
        {
            Store_data.Clear();
            XmlDocument xml = new XmlDocument();
            xml.Load("bolt.xml");
            dataGridView1.DataSource = Store_data;


            foreach (XmlElement element in xml.DocumentElement)
            {
                var product = new store();
                Store_data.Add(product);

                product.Termék = element.GetAttribute("megnevezes");

                var childElement = (XmlElement)element.ChildNodes[0];
                product.Beszerzési_ár = childElement.GetAttribute("beszerzesi");
                product.Eladási_ár = childElement.GetAttribute("eladási");
                product.Mennyiség = childElement.GetAttribute("mennyiseg");
            }
        }

        private void store_btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    foreach (store product in Store_data)
                    {
                        sw.WriteLine("{0};{1};{2};{3}",
                        product.Termék, product.Beszerzési_ár, product.Eladási_ár, product.Mennyiség);
                    }
                }
            }
        }
    }
}
