using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocnikSkrotowy
{
    public partial class listaForm : Form
    {
        public listaForm()
        {
            InitializeComponent();
        }

        private void listaForm_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.lokacjaListy;
            List <string> lista = new List <string>();
            lista.Add("{BACKSPACE}");
            lista.Add("{BREAK}");
            lista.Add("{DELETE}");
            lista.Add("{DOWN}");
            lista.Add("{END}");
            lista.Add("{ENTER}");
            lista.Add("{ESC}");
            lista.Add("{HELP}");
            lista.Add("{HOME}");
            lista.Add("{INSERT}");
            lista.Add("{LEFT}");
            lista.Add("{NUMLOCK}");
            lista.Add("{PGDN}");
            lista.Add("{PGUP}");
            lista.Add("{PRTSC}");
            lista.Add("{RIGHT}");
            lista.Add("{SCROLLLOCK}");
            lista.Add("{UP}");
            lista.Add("{F1}");
            lista.Add("{F2}");
            lista.Add("{F3}");
            lista.Add("{F4}");
            lista.Add("{F5}");
            lista.Add("{F6}");
            lista.Add("{F7}");
            lista.Add("{F8}");
            lista.Add("{F9}");
            lista.Add("{F10}");
            lista.Add("{F11}");
            lista.Add("{F12}");
            lista.Add("{ADD}");
            lista.Add("{SUBTRACT}");
            lista.Add("{MULTIPLY}");
            lista.Add("{DIVIDE}");


            foreach (string item in lista)
            {
                DataRow wiersz = listaDT.NewRow();
                wiersz["Klawisz funkcyjny"] = item;
                listaDT.Rows.Add(wiersz);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string wartoscKomorki = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            UstForm ustForm = Application.OpenForms.OfType<UstForm>().FirstOrDefault();
            if (ustForm != null)
            ustForm.ustawLiteryTBox(wartoscKomorki);
            
        }

        private void listaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.lokacjaListy = this.Location;
        }
    }
}
