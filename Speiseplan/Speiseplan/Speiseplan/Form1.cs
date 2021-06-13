using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Speiseplan
{
    public partial class Form1 : Form
    {
        internal static Form1 f1;

        public Form1()
        {
            InitializeComponent();
            f1 = this;
        }

        XmlSerializer serializer;
        ListViewItem lvItem;
        internal List<Speise> speisenliste;
        internal List<Zutat> zutatenliste;

        public void Speisenspeichern()
        {
            try
            {
                FileStream fs = new FileStream("speisen.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializer.Serialize(fs, speisenliste);
                fs.Close();
            }
            catch (Exception e) { MessageBox.Show("Fehler beim Speichern der Daten" + e.Message); }
        }

        private void bilderLaden()
        {
            imageList1.Images.Clear();

            foreach (Speise s in speisenliste)
            {
                try
                {
                    imageList1.Images.Add(Image.FromFile(s.BildAdresse));
                }
                catch (Exception) {  }
            }
        }

        private void Speisenladen()
        {
            try
            {
                FileStream fs = new FileStream("speisen.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                speisenliste = (List<Speise>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception e) { MessageBox.Show("Fehler beim Laden der Daten" + e.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speisenliste = new List<Speise>();
            zutatenliste = new List<Zutat>();
            serializer = new XmlSerializer(speisenliste.GetType());

            Speisenladen();
            //speisenliste.Add(new Speise("Schnitzel", "Aus Wien", "Fleisch", 14.20, 'H'));
            listviewLaden();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Speisenspeichern();
        }


        internal void listviewLaden()
        {
            lvSpeisekarte.Items.Clear();
            int index = 0;
            foreach (Speise s in speisenliste)
            {

                lvItem = new ListViewItem("");

                lvItem.ImageIndex = index;

                lvItem.SubItems.Add(s.Name);
                lvItem.SubItems.Add(s.Beschreibung);
                lvItem.SubItems.Add(s.Preis.ToString("c2"));
                lvItem.SubItems.Add(s.Zutaten);
                lvItem.SubItems.Add(s.Speiseart.ToString());
                lvSpeisekarte.Items.Add(lvItem);

                index++;
            }
            lvSpeisekarte.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvSpeisekarte.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            bilderLaden();
        }

        private void neuanlageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Neuanlage";
            f2.ShowDialog();
            listviewLaden();
            Speisenspeichern();
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSpeisekarte.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte etwas auswählen");
            }
            else
            {
                int inde = lvSpeisekarte.SelectedItems[0].Index;
                speisenliste.RemoveAt(inde);

                listviewLaden();
                Speisenspeichern();
            }
        }

        private void ändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSpeisekarte.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte etwas auswählen");
            }
            else
            {
                lvItem = lvSpeisekarte.SelectedItems[0];

                Form2 f2 = new Form2();
                f2.inde = lvItem.Index;
                f2.Text = "Ändern";

                f2.txtName.Text = lvItem.SubItems[1].Text;
                f2.txtBeschreibung.Text = lvItem.SubItems[2].Text;
                f2.txtPreis.Text = speisenliste[lvSpeisekarte.SelectedIndices[0]].Preis + "";
                f2.txtZutaten.Text = lvItem.SubItems[4].Text;

                string speisetyp = "";
                if (lvItem.SubItems[5].Text.Equals("V"))
                {
                    f2.comboBox1.SelectedItem = "Vorspeise";
                }
                else if (lvItem.SubItems[5].Text.Equals("H"))
                {
                    f2.comboBox1.SelectedItem = "Hauptspeise";
                }
                else if (lvItem.SubItems[5].Text.Equals("N"))
                {
                    f2.comboBox1.SelectedItem = "Nachspeise";
                }

                f2.ShowDialog();
                listviewLaden();
            }
        }

        private void lvSpeisekarte_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Alle Zutaten: "+speisenliste[lvSpeisekarte.SelectedIndices[0]].Zutaten);
        }

        private void wochenspeiseplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wochenspeiseplan fmWWochenspeiseplan = new Wochenspeiseplan();
            fmWWochenspeiseplan.ShowDialog();
        }
    }
}
