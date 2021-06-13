using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speiseplan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        internal int inde;
        string bildpfad = "";

        private void btAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") || txtPreis.Text.Equals("") || txtZutaten.Text.Equals(""))
            {
                MessageBox.Show("Bitte überprüfe deine Eingabe.");
            }
            else
            {
                char speisentyp ='H';
                if (comboBox1.SelectedItem.Equals("Vorspeise"))
                {
                    speisentyp = 'V';
                }
                else if(comboBox1.SelectedItem.Equals("Hauptspeise"))
                {
                    speisentyp = 'H';
                }
                else if (comboBox1.SelectedItem.Equals("Nachspeise"))
                {
                    speisentyp = 'N';
                }



                if (this.Text.Equals("Neuanlage"))
                    Form1.f1.speisenliste.Add(new Speise(txtName.Text,txtBeschreibung.Text,txtZutaten.Text,Convert.ToDouble(txtPreis.Text),speisentyp,bildpfad)) ;
                else
                {
                    Form1.f1.speisenliste[inde].Name = txtName.Text;
                    Form1.f1.speisenliste[inde].Beschreibung = txtBeschreibung.Text;
                    Form1.f1.speisenliste[inde].Preis = Convert.ToDouble(txtPreis.Text);
                    Form1.f1.speisenliste[inde].Zutaten = txtZutaten.Text;
                    Form1.f1.speisenliste[inde].BildAdresse = bildpfad;
                }

                this.Close();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btBild_Click(object sender, EventArgs e)
        {
            OpenFileDialog bildÖffnen = new OpenFileDialog();

            if (bildÖffnen.ShowDialog() == DialogResult.OK)
            {
                bildpfad = "../../../bilder/"+bildÖffnen.SafeFileName;
            }
            else
            {
                return;
            }

        }
    }
}
