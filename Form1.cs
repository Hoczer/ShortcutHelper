using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PomocnikSkrotowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nazwaOkna= null;
        DataTable macroDT = new DataTable();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Okna okna = new Okna();
            int indexOkna = okna.ZnajdzOkno(nazwaOkna);
            if (indexOkna==0)
            {
                MessageBox.Show("Nie znalazłem okna");
            }
            else
            {
                okna.UstawAktywneOkno(indexOkna);
                wykonajMakro();
                
                
            }
        }

        private void podwojneKlikniecieEve(object sender, EventArgs e)
        {
            Properties.Settings.Default.lokacja = this.Location;
            Properties.Settings.Default.wysokosc = this.Height;
            Properties.Settings.Default.szerokosc = this.Width;

            var ustform = new UstForm();
            ustform.Show();
            this.Hide();
        }
        public void wczytajUstawienia()
        {
            int wysokosc = Properties.Settings.Default.wysokosc;
            int szerokosc = Properties.Settings.Default.szerokosc;
            nazwaOkna = Properties.Settings.Default.nazwaOkna;
            button1.Text = Properties.Settings.Default.nazwaPrzycisku;
            this.Location = Properties.Settings.Default.lokacja;
            Okna okna = new Okna();
            okna.UstawOknoAllwaysOnTop(this.Handle, Properties.Settings.Default.allwaysOnTop, this.Location.X, this.Location.Y,szerokosc,wysokosc);
            
            //this.Height = wysokosc;
            //this.Width = szerokosc;
            macroDT.TableName = "Skroty";
            if(macroDT.Rows.Count > 0)
                macroDT.Clear();
            macroDT.ReadXml("bazaSkrotow");
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wczytajUstawienia();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.lokacja = this.Location;
            Properties.Settings.Default.wysokosc = this.Height;
            Properties.Settings.Default.szerokosc = this.Width;
        }
        private void wykonajMakro()
        {
            
            foreach (DataRow wiersz in macroDT.Rows)
            {
                string skrot = null;
                if (wiersz[1].ToString() == "Ctrl")
                    skrot = skrot + "^";
                if (wiersz[2].ToString() == "Shift")
                    skrot = skrot + "+";
                if (wiersz[3].ToString() == "Alt")
                    skrot = skrot + "%";
                if (wiersz[4].ToString() == "Tab")
                    skrot = skrot + "{TAB}";
                if (wiersz[5].ToString() == "Enter")
                    skrot = skrot + "{ENTER}";
                skrot = skrot + wiersz[6].ToString();
                Debug.WriteLine(skrot);
                
                SendKeys.SendWait(skrot);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //wykonajMakro();
            // for (int i = 0; i < macroDT.Rows.Count; i++)
            //{
            //    DataRow wiersz = macroDT.Rows[i];
            //    Debug.WriteLine(wiersz["Klawisz1"]+" "+wiersz["Klawisz2"]+" "+wiersz["Klawisz3"]+" "+wiersz["Klawisz4"]+" "+wiersz["Litery"]);
            // }
            Debug.WriteLine(macroDT.Rows.Count);
            foreach(DataRow wiersz in macroDT.Rows)
            {
                string skrot = null;
                if (wiersz[1].ToString() == "Ctrl")
                    skrot = skrot + "^";
                if (wiersz[2].ToString() == "Shift")
                    skrot = skrot + "+";
                if (wiersz[3].ToString() == "Alt")
                    skrot = skrot + "%";
                if (wiersz[4].ToString() == "Tab")
                    skrot = skrot + "{TAB}";
                if (wiersz[5].ToString() == "Enter")
                    skrot = skrot + "{ENTER}";
                skrot = skrot + wiersz[6].ToString();
                Debug.WriteLine(skrot);
                
                SendKeys.SendWait(skrot);
                
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hokto.net");
        }
    }
}
