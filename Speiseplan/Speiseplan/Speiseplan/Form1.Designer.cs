namespace Speiseplan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvSpeisekarte = new System.Windows.Forms.ListView();
            this.bild = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beschreibung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zutaten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speiseart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuanlageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Überschrift = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wochenspeiseplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSpeisekarte
            // 
            this.lvSpeisekarte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bild,
            this.name,
            this.beschreibung,
            this.preis,
            this.zutaten,
            this.speiseart});
            this.lvSpeisekarte.ContextMenuStrip = this.contextMenuStrip1;
            this.lvSpeisekarte.FullRowSelect = true;
            this.lvSpeisekarte.HideSelection = false;
            this.lvSpeisekarte.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvSpeisekarte.Location = new System.Drawing.Point(9, 135);
            this.lvSpeisekarte.Margin = new System.Windows.Forms.Padding(2);
            this.lvSpeisekarte.Name = "lvSpeisekarte";
            this.lvSpeisekarte.ShowItemToolTips = true;
            this.lvSpeisekarte.Size = new System.Drawing.Size(753, 396);
            this.lvSpeisekarte.SmallImageList = this.imageList1;
            this.lvSpeisekarte.TabIndex = 0;
            this.lvSpeisekarte.UseCompatibleStateImageBehavior = false;
            this.lvSpeisekarte.View = System.Windows.Forms.View.Details;
            this.lvSpeisekarte.DoubleClick += new System.EventHandler(this.lvSpeisekarte_DoubleClick);
            // 
            // bild
            // 
            this.bild.Text = "Bild";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // beschreibung
            // 
            this.beschreibung.Text = "Beschreibung";
            // 
            // preis
            // 
            this.preis.Text = "Preis";
            // 
            // zutaten
            // 
            this.zutaten.Text = "Zutaten";
            // 
            // speiseart
            // 
            this.speiseart.Text = "Speiseart";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuanlageToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.ändernToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 70);
            // 
            // neuanlageToolStripMenuItem
            // 
            this.neuanlageToolStripMenuItem.Name = "neuanlageToolStripMenuItem";
            this.neuanlageToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.neuanlageToolStripMenuItem.Text = "Neuanlage";
            this.neuanlageToolStripMenuItem.Click += new System.EventHandler(this.neuanlageToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ändernToolStripMenuItem.Text = "Ändern";
            this.ändernToolStripMenuItem.Click += new System.EventHandler(this.ändernToolStripMenuItem_Click);
            // 
            // Überschrift
            // 
            this.Überschrift.AutoSize = true;
            this.Überschrift.BackColor = System.Drawing.Color.Transparent;
            this.Überschrift.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Überschrift.ForeColor = System.Drawing.Color.White;
            this.Überschrift.Location = new System.Drawing.Point(291, 24);
            this.Überschrift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Überschrift.Name = "Überschrift";
            this.Überschrift.Size = new System.Drawing.Size(213, 63);
            this.Überschrift.TabIndex = 5;
            this.Überschrift.Text = "Speisekarte";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wochenspeiseplanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wochenspeiseplanToolStripMenuItem
            // 
            this.wochenspeiseplanToolStripMenuItem.Name = "wochenspeiseplanToolStripMenuItem";
            this.wochenspeiseplanToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.wochenspeiseplanToolStripMenuItem.Text = "Wochenspeiseplan";
            this.wochenspeiseplanToolStripMenuItem.Click += new System.EventHandler(this.wochenspeiseplanToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 540);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Überschrift);
            this.Controls.Add(this.lvSpeisekarte);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSpeisekarte;
        private System.Windows.Forms.Label Überschrift;
        private System.Windows.Forms.ColumnHeader bild;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader beschreibung;
        private System.Windows.Forms.ColumnHeader preis;
        private System.Windows.Forms.ColumnHeader zutaten;
        private System.Windows.Forms.ColumnHeader speiseart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem neuanlageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wochenspeiseplanToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

