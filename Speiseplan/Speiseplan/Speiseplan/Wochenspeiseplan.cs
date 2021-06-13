using System;
using System.Windows.Forms;

namespace Speiseplan
{
    public partial class Wochenspeiseplan : Form
    {
        public Wochenspeiseplan()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Wochenspeiseplan_Load(object sender, EventArgs e)
        {
            int anzahlVorspeisen = 0, anzahlHauptspeisen = 0, anzahlNachspeisen = 0;

            foreach (Speise s in Form1.f1.speisenliste)
            {
                if (s.Speiseart.Equals('V'))
                {
                    anzahlVorspeisen++;
                    comboBox1.Items.Add(s.Name);
                    comboBox2.Items.Add(s.Name);
                    comboBox3.Items.Add(s.Name);
                    comboBox4.Items.Add(s.Name);
                    comboBox5.Items.Add(s.Name);
                    comboBox6.Items.Add(s.Name);
                    comboBox7.Items.Add(s.Name);
                }
                else if (s.Speiseart.Equals('H'))
                {
                    anzahlHauptspeisen++;
                    comboBox8.Items.Add(s.Name);
                    comboBox9.Items.Add(s.Name);
                    comboBox10.Items.Add(s.Name);
                    comboBox11.Items.Add(s.Name);
                    comboBox12.Items.Add(s.Name);
                    comboBox13.Items.Add(s.Name);
                    comboBox14.Items.Add(s.Name);
                }
                else if (s.Speiseart.Equals('N'))
                {
                    anzahlNachspeisen++;
                    comboBox15.Items.Add(s.Name);
                    comboBox16.Items.Add(s.Name);
                    comboBox17.Items.Add(s.Name);
                    comboBox18.Items.Add(s.Name);
                    comboBox19.Items.Add(s.Name);
                    comboBox20.Items.Add(s.Name);
                    comboBox21.Items.Add(s.Name);
                }

            }

            Random rnd = new Random();

            comboBox1.SelectedIndex = rnd.Next(0, anzahlVorspeisen);
            comboBox2.SelectedIndex = rnd.Next(0, anzahlVorspeisen);
            comboBox3.SelectedIndex = rnd.Next(0, anzahlVorspeisen);
            comboBox4.SelectedIndex = rnd.Next(0, anzahlVorspeisen);
            comboBox5.SelectedIndex = rnd.Next(0, anzahlVorspeisen);
            comboBox6.SelectedIndex = rnd.Next(0, anzahlVorspeisen);
            comboBox7.SelectedIndex = rnd.Next(0, anzahlVorspeisen);

            comboBox8.SelectedIndex = rnd.Next(0, anzahlHauptspeisen);
            comboBox9.SelectedIndex = rnd.Next(0, anzahlHauptspeisen);
            comboBox10.SelectedIndex = rnd.Next(0, anzahlHauptspeisen);
            comboBox11.SelectedIndex = rnd.Next(0, anzahlHauptspeisen);
            comboBox12.SelectedIndex = rnd.Next(0, anzahlHauptspeisen);
            comboBox13.SelectedIndex = rnd.Next(0, anzahlHauptspeisen);
            comboBox14.SelectedIndex = rnd.Next(0, anzahlHauptspeisen);

            comboBox15.SelectedIndex = rnd.Next(0, anzahlNachspeisen);
            comboBox16.SelectedIndex = rnd.Next(0, anzahlNachspeisen);
            comboBox17.SelectedIndex = rnd.Next(0, anzahlNachspeisen);
            comboBox18.SelectedIndex = rnd.Next(0, anzahlNachspeisen);
            comboBox19.SelectedIndex = rnd.Next(0, anzahlNachspeisen);
            comboBox20.SelectedIndex = rnd.Next(0, anzahlNachspeisen);
            comboBox21.SelectedIndex = rnd.Next(0, anzahlNachspeisen);


        }

        private void btDrucken_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            wordapp.Visible = true;

            if (wordapp == null)
            {
                MessageBox.Show("Fehler mit Word");
                return;
            }
            
            try
            {
                wordapp.Documents.Open(Application.StartupPath + "\\Speiseplan.docx");

                wordapp.ActiveDocument.FormFields["MontagVor"].Result = comboBox1.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["MontagHaupt"].Result = comboBox2.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["MontagNach"].Result = comboBox3.SelectedItem.ToString();

                wordapp.ActiveDocument.FormFields["DienstagVor"].Result = comboBox4.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["DienstagHaupt"].Result = comboBox5.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["DienstagNach"].Result = comboBox6.SelectedItem.ToString();

                wordapp.ActiveDocument.FormFields["MittwochVor"].Result = comboBox7.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["MittwochHaupt"].Result = comboBox8.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["MittwochNach"].Result = comboBox9.SelectedItem.ToString();

                wordapp.ActiveDocument.FormFields["DonnerstagVor"].Result = comboBox10.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["DonnerstagHaupt"].Result = comboBox11.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["DonnerstagNach"].Result = comboBox12.SelectedItem.ToString();

                wordapp.ActiveDocument.FormFields["FreitagVor"].Result = comboBox13.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["FreitagHaupt"].Result = comboBox14.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["FreitagNach"].Result = comboBox15.SelectedItem.ToString();

                wordapp.ActiveDocument.FormFields["SamstagVor"].Result = comboBox16.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["SamstagHaupt"].Result = comboBox17.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["SamstagNach"].Result = comboBox18.SelectedItem.ToString();

                wordapp.ActiveDocument.FormFields["SonntagVor"].Result = comboBox19.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["SonntagHaupt"].Result = comboBox20.SelectedItem.ToString();
                wordapp.ActiveDocument.FormFields["SonntagNach"].Result = comboBox21.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Speichern");
                return;
            }

            
            wordapp.ActiveDocument.SaveAs2(Application.StartupPath + "\\Wochenspeiseplan");

        }
    }
}
