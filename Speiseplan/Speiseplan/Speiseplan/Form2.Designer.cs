
namespace Speiseplan
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZutaten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btSpeichern = new System.Windows.Forms.Button();
            this.btAbbrechen = new System.Windows.Forms.Button();
            this.btBild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(99, 32);
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(100, 20);
            this.txtBeschreibung.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beschreibung";
            // 
            // txtZutaten
            // 
            this.txtZutaten.Location = new System.Drawing.Point(99, 58);
            this.txtZutaten.Name = "txtZutaten";
            this.txtZutaten.Size = new System.Drawing.Size(100, 20);
            this.txtZutaten.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zutaten";
            // 
            // txtPreis
            // 
            this.txtPreis.Location = new System.Drawing.Point(99, 84);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.Size = new System.Drawing.Size(100, 20);
            this.txtPreis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Speiseart";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vorspeise",
            "Hauptspeise",
            "Nachspeise"});
            this.comboBox1.Location = new System.Drawing.Point(99, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btSpeichern
            // 
            this.btSpeichern.Location = new System.Drawing.Point(15, 190);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btSpeichern.TabIndex = 10;
            this.btSpeichern.Text = "Speichern";
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.Location = new System.Drawing.Point(124, 190);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.btAbbrechen.TabIndex = 11;
            this.btAbbrechen.Text = "Abbrechen";
            this.btAbbrechen.UseVisualStyleBackColor = true;
            this.btAbbrechen.Click += new System.EventHandler(this.btAbbrechen_Click);
            // 
            // btBild
            // 
            this.btBild.Location = new System.Drawing.Point(99, 137);
            this.btBild.Name = "btBild";
            this.btBild.Size = new System.Drawing.Size(100, 23);
            this.btBild.TabIndex = 12;
            this.btBild.Text = "Bild";
            this.btBild.UseVisualStyleBackColor = true;
            this.btBild.Click += new System.EventHandler(this.btBild_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 225);
            this.Controls.Add(this.btBild);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.btSpeichern);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPreis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZutaten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBeschreibung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSpeichern;
        private System.Windows.Forms.Button btAbbrechen;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtBeschreibung;
        internal System.Windows.Forms.TextBox txtZutaten;
        internal System.Windows.Forms.TextBox txtPreis;
        internal System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btBild;
    }
}