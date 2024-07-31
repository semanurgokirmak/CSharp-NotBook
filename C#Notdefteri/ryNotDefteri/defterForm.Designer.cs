namespace ryNotDefteri
{
    partial class defterForm
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
            this.components = new System.ComponentModel.Container();
            this.anaMenu = new System.Windows.Forms.MenuStrip();
            this.dosyaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kapatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tmnSecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminRengiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziRengiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziAlani = new System.Windows.Forms.RichTextBox();
            this.icerikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.icerikKesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icerikKopyalaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icerikYapistirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.icerikZeminRengiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.yaziTipi = new System.Windows.Forms.FontDialog();
            this.renkDunyasi = new System.Windows.Forms.ColorDialog();
            this.anaMenu.SuspendLayout();
            this.icerikMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // anaMenu
            // 
            this.anaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaMenuItem,
            this.duzenMenuItem,
            this.toolsToolStripMenuItem});
            this.anaMenu.Location = new System.Drawing.Point(0, 0);
            this.anaMenu.Name = "anaMenu";
            this.anaMenu.Size = new System.Drawing.Size(378, 24);
            this.anaMenu.TabIndex = 0;
            this.anaMenu.Text = "menuStrip1";
            // 
            // dosyaMenuItem
            // 
            this.dosyaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acMenuItem,
            this.toolStripSeparator,
            this.kaydetMenuItem,
            this.toolStripSeparator1,
            this.kapatMenuItem});
            this.dosyaMenuItem.Name = "dosyaMenuItem";
            this.dosyaMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaMenuItem.Text = "&Dosya";
            // 
            // acMenuItem
            // 
            this.acMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.acMenuItem.Name = "acMenuItem";
            this.acMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.acMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acMenuItem.Text = "&Ac";
            this.acMenuItem.Click += new System.EventHandler(this.acMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // kaydetMenuItem
            // 
            this.kaydetMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetMenuItem.Name = "kaydetMenuItem";
            this.kaydetMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetMenuItem.Text = "&Kaydet";
            this.kaydetMenuItem.Click += new System.EventHandler(this.kaydetMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // kapatMenuItem
            // 
            this.kapatMenuItem.Name = "kapatMenuItem";
            this.kapatMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatMenuItem.Text = "Çıkış";
            this.kapatMenuItem.Click += new System.EventHandler(this.kapatMenuItem_Click);
            // 
            // duzenMenuItem
            // 
            this.duzenMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlMenuItem,
            this.yineleMenuItem,
            this.toolStripSeparator3,
            this.kesMenuItem,
            this.kopyalaMenuItem,
            this.yapistirMenuItem,
            this.toolStripSeparator4,
            this.tmnSecMenuItem});
            this.duzenMenuItem.Name = "duzenMenuItem";
            this.duzenMenuItem.Size = new System.Drawing.Size(52, 20);
            this.duzenMenuItem.Text = "Dü&zen";
            // 
            // geriAlMenuItem
            // 
            this.geriAlMenuItem.Name = "geriAlMenuItem";
            this.geriAlMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlMenuItem.Size = new System.Drawing.Size(180, 22);
            this.geriAlMenuItem.Text = "&Geri Al";
            this.geriAlMenuItem.Click += new System.EventHandler(this.geriAlMenuItem_Click);
            // 
            // yineleMenuItem
            // 
            this.yineleMenuItem.Name = "yineleMenuItem";
            this.yineleMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yineleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yineleMenuItem.Text = "&Yinele";
            this.yineleMenuItem.Click += new System.EventHandler(this.yineleMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // kesMenuItem
            // 
            this.kesMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesMenuItem.Name = "kesMenuItem";
            this.kesMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kesMenuItem.Text = "Kes";
            this.kesMenuItem.Click += new System.EventHandler(this.kesMenuItem_Click);
            // 
            // kopyalaMenuItem
            // 
            this.kopyalaMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaMenuItem.Name = "kopyalaMenuItem";
            this.kopyalaMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kopyalaMenuItem.Text = "&Kopyala";
            this.kopyalaMenuItem.Click += new System.EventHandler(this.kopyalaMenuItem_Click);
            // 
            // yapistirMenuItem
            // 
            this.yapistirMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapistirMenuItem.Name = "yapistirMenuItem";
            this.yapistirMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapistirMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yapistirMenuItem.Text = "&Yapıştır";
            this.yapistirMenuItem.Click += new System.EventHandler(this.yapistirMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tmnSecMenuItem
            // 
            this.tmnSecMenuItem.Name = "tmnSecMenuItem";
            this.tmnSecMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tmnSecMenuItem.Text = "Tümünü Seç";
            this.tmnSecMenuItem.Click += new System.EventHandler(this.tmnSecMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zeminRengiMenuItem,
            this.yaziTipiMenuItem,
            this.yaziRengiMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.toolsToolStripMenuItem.Text = "&Ayarlar";
            // 
            // zeminRengiMenuItem
            // 
            this.zeminRengiMenuItem.Name = "zeminRengiMenuItem";
            this.zeminRengiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zeminRengiMenuItem.Text = "Zemin Rengi";
            this.zeminRengiMenuItem.Click += new System.EventHandler(this.zeminRengiMenuItem_Click);
            // 
            // yaziTipiMenuItem
            // 
            this.yaziTipiMenuItem.Name = "yaziTipiMenuItem";
            this.yaziTipiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yaziTipiMenuItem.Text = "&Yazı Tipi";
            this.yaziTipiMenuItem.Click += new System.EventHandler(this.yaziTipiMenuItem_Click);
            // 
            // yaziRengiMenuItem
            // 
            this.yaziRengiMenuItem.Name = "yaziRengiMenuItem";
            this.yaziRengiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yaziRengiMenuItem.Text = "Yazı Rengi";
            this.yaziRengiMenuItem.Click += new System.EventHandler(this.yaziRengiMenuItem_Click);
            // 
            // yaziAlani
            // 
            this.yaziAlani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yaziAlani.ContextMenuStrip = this.icerikMenu;
            this.yaziAlani.Location = new System.Drawing.Point(0, 27);
            this.yaziAlani.Name = "yaziAlani";
            this.yaziAlani.Size = new System.Drawing.Size(378, 298);
            this.yaziAlani.TabIndex = 1;
            this.yaziAlani.Text = "";
            // 
            // icerikMenu
            // 
            this.icerikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.icerikKesMenuItem,
            this.icerikKopyalaMenuItem,
            this.icerikYapistirMenuItem,
            this.toolStripSeparator5,
            this.icerikZeminRengiMenuItem});
            this.icerikMenu.Name = "icerikMenu";
            this.icerikMenu.Size = new System.Drawing.Size(142, 98);
            // 
            // icerikKesMenuItem
            // 
            this.icerikKesMenuItem.Name = "icerikKesMenuItem";
            this.icerikKesMenuItem.Size = new System.Drawing.Size(141, 22);
            this.icerikKesMenuItem.Text = "Kes";
            // 
            // icerikKopyalaMenuItem
            // 
            this.icerikKopyalaMenuItem.Name = "icerikKopyalaMenuItem";
            this.icerikKopyalaMenuItem.Size = new System.Drawing.Size(141, 22);
            this.icerikKopyalaMenuItem.Text = "Kopyala";
            // 
            // icerikYapistirMenuItem
            // 
            this.icerikYapistirMenuItem.Name = "icerikYapistirMenuItem";
            this.icerikYapistirMenuItem.Size = new System.Drawing.Size(141, 22);
            this.icerikYapistirMenuItem.Text = "Yapıştır";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(138, 6);
            // 
            // icerikZeminRengiMenuItem
            // 
            this.icerikZeminRengiMenuItem.Name = "icerikZeminRengiMenuItem";
            this.icerikZeminRengiMenuItem.Size = new System.Drawing.Size(141, 22);
            this.icerikZeminRengiMenuItem.Text = "Zemin Rengi";
            // 
            // dosyaKaydet
            // 
            this.dosyaKaydet.DefaultExt = "txt";
            this.dosyaKaydet.Filter = "Metin Belgesi|*.txt|Word Belgesi|*.doc";
            this.dosyaKaydet.Title = "Dosyayı Kaydediniz";
            // 
            // defterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 321);
            this.ControlBox = false;
            this.Controls.Add(this.anaMenu);
            this.Controls.Add(this.yaziAlani);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.anaMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "defterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT DEFTERİ";
            this.anaMenu.ResumeLayout(false);
            this.anaMenu.PerformLayout();
            this.icerikMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip anaMenu;
        private System.Windows.Forms.ToolStripMenuItem dosyaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem kaydetMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kapatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tmnSecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeminRengiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziRengiMenuItem;
        private System.Windows.Forms.RichTextBox yaziAlani;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.FontDialog yaziTipi;
        private System.Windows.Forms.ColorDialog renkDunyasi;
        private System.Windows.Forms.ContextMenuStrip icerikMenu;
        private System.Windows.Forms.ToolStripMenuItem icerikKesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icerikKopyalaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icerikYapistirMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem icerikZeminRengiMenuItem;
    }
}

