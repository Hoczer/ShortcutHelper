using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PomocnikSkrotowy
{
    public partial class UstForm : Form
    {
        bool ctrlF;
        bool shiftF;
        bool altF;
        bool tabF;
        bool enterF;
        bool allwaysOnTop;
        
        public UstForm()
        {
            InitializeComponent();
        }

        private void UstForm_Load(object sender, EventArgs e)
        {
            nOknaTextBox.Text = Properties.Settings.Default.nazwaOkna;
            nPrzyciskuBox.Text = Properties.Settings.Default.nazwaPrzycisku;
            allwaysOnTop = Properties.Settings.Default.allwaysOnTop;
            zawszeNaWierzchuCheck.Checked = allwaysOnTop;
            this.Location = Properties.Settings.Default.lokacja;
            macroDt.ReadXml("bazaSkrotow");
            

        }
        private void ctrlPress (bool ctrl)
        {
            ctrlF = ctrl;
            if (ctrlF)
            {
                ctrlLab.BackColor = Color.Orange;

            }
            else
            {
                ctrlLab.BackColor = Color.CornflowerBlue;
            }
        }
        private void shiftPress(bool shift)
        {
            shiftF = shift;
            if (shiftF)
            {
                shiftLab.BackColor = Color.Orange;

            }
            else
            {
                shiftLab.BackColor = Color.CornflowerBlue;
            }
        }
        private void altPress(bool alt)
        {
            altF = alt;
            if (altF)
            {
                altLab.BackColor = Color.Orange;

            }
            else
            {
                altLab.BackColor = Color.CornflowerBlue;
            }
        }
        private void tabPress(bool tab)
        {
            tabF = tab;
            if (tabF)
            {
                tabLab.BackColor = Color.Orange;

            }
            else
            {
                tabLab.BackColor = Color.CornflowerBlue;
            }
        }
        private void enterPress(bool enter)
        {
            enterF = enter;
            if (enterF)
            {
                enterLab.BackColor = Color.Orange;

            }
            else
            {
                enterLab.BackColor = Color.CornflowerBlue;
            }
        }

        private void UstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.lokacja = this.Location;
            var Form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if(Form1 != null)
            {
                Form1.Show();
                Form1.wczytajUstawienia();
            }
            var listaForm = Application.OpenForms.OfType<listaForm>().FirstOrDefault();
            if(listaForm != null)
                listaForm.Close();
            
        }

        private void ctrlLab_Click(object sender, EventArgs e)
        {
            ctrlF = !ctrlF;
            ctrlPress(ctrlF);
        }

        private void shiftLab_Click(object sender, EventArgs e)
        {
            shiftF = !shiftF;
            shiftPress(shiftF);
        }

        private void altLab_Click(object sender, EventArgs e)
        {
            altF= !altF;
            altPress(altF);
        }
        private void tabLab_Click(object sender, EventArgs e)
        {
            tabF = !tabF;
            tabPress(tabF);
        }

        private void ZapiszUstawienia()
        {

            Properties.Settings.Default.nazwaPrzycisku = nPrzyciskuBox.Text;
            Properties.Settings.Default.nazwaOkna = nOknaTextBox.Text;
            macroDt.WriteXml("bazaSkrotow", XmlWriteMode.WriteSchema);
            Properties.Settings.Default.allwaysOnTop = allwaysOnTop;

        }

        private void zapiszButt_Click(object sender, EventArgs e)
        {
            ZapiszUstawienia();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DataRow wiersz = macroDt.NewRow();
            if (ctrlF)
                wiersz["Klawisz1"] = "Ctrl";
            if (shiftF)
                wiersz["Klawisz2"] = "Shift";
            if (altF)
                wiersz["Klawisz3"] = "Alt";
            if (tabF)
                wiersz["Klawisz4"] = "Tab";
            if (enterF)
                wiersz["Klawisz5"] = "Enter";
            wiersz["Litery"] = lSkrotuBox.Text;
            macroDt.Rows.Add(wiersz);
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if(macroDt.Rows.Count > 0)
            {
                DataRow wierszDoUsuniecia = macroDt.Rows[macroDt.Rows.Count - 1];
                wierszDoUsuniecia.Delete();
                macroDt.AcceptChanges();
            }
            
        }

        private void enterLab_Click(object sender, EventArgs e)
        {
            enterF = !enterF;
            enterPress(enterF);
        }

        private void zawszeNaWierzchuCheck_Click(object sender, EventArgs e)
        {
            if (zawszeNaWierzchuCheck.Checked)
            {
                allwaysOnTop = true;
            }
            else
            {
                allwaysOnTop= false;
            }
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            listaForm listaForm = new listaForm ();
            listaForm.Show();

        }
        public void ustawLiteryTBox(string klawiszFunkcyjny)
        {
            lSkrotuBox.Text = klawiszFunkcyjny;
        }
    }
}
