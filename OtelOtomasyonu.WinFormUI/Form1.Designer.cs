namespace OtelOtomasyonu.WinFormUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.birimTipleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaTüeleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaÖzellikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özellikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimTipleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kasalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaHareketTipleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaHareketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satınAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birimTipleriToolStripMenuItem,
            this.kasalarToolStripMenuItem,
            this.kasaHareketToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.satınAlmaToolStripMenuItem,
            this.satışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // birimTipleriToolStripMenuItem
            // 
            this.birimTipleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.urunlerToolStripMenuItem,
            this.odalarToolStripMenuItem,
            this.odaTüeleriToolStripMenuItem,
            this.odaÖzellikleriToolStripMenuItem,
            this.özellikToolStripMenuItem,
            this.birimTipleriToolStripMenuItem1});
            this.birimTipleriToolStripMenuItem.Name = "birimTipleriToolStripMenuItem";
            this.birimTipleriToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.birimTipleriToolStripMenuItem.Text = "Tanımlar";
            this.birimTipleriToolStripMenuItem.Click += new System.EventHandler(this.birimTipleriToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // urunlerToolStripMenuItem
            // 
            this.urunlerToolStripMenuItem.Name = "urunlerToolStripMenuItem";
            this.urunlerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.urunlerToolStripMenuItem.Text = "Urunler";
            this.urunlerToolStripMenuItem.Click += new System.EventHandler(this.urunlerToolStripMenuItem_Click);
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.odalarToolStripMenuItem.Text = "Odalar";
            this.odalarToolStripMenuItem.Click += new System.EventHandler(this.odalarToolStripMenuItem_Click);
            // 
            // odaTüeleriToolStripMenuItem
            // 
            this.odaTüeleriToolStripMenuItem.Name = "odaTüeleriToolStripMenuItem";
            this.odaTüeleriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.odaTüeleriToolStripMenuItem.Text = "Oda Türleri";
            this.odaTüeleriToolStripMenuItem.Click += new System.EventHandler(this.odaTüeleriToolStripMenuItem_Click);
            // 
            // odaÖzellikleriToolStripMenuItem
            // 
            this.odaÖzellikleriToolStripMenuItem.Name = "odaÖzellikleriToolStripMenuItem";
            this.odaÖzellikleriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.odaÖzellikleriToolStripMenuItem.Text = "Oda Özellikleri";
            this.odaÖzellikleriToolStripMenuItem.Click += new System.EventHandler(this.odaÖzellikleriToolStripMenuItem_Click);
            // 
            // özellikToolStripMenuItem
            // 
            this.özellikToolStripMenuItem.Name = "özellikToolStripMenuItem";
            this.özellikToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.özellikToolStripMenuItem.Text = "Özellik";
            this.özellikToolStripMenuItem.Click += new System.EventHandler(this.özellikToolStripMenuItem_Click);
            // 
            // birimTipleriToolStripMenuItem1
            // 
            this.birimTipleriToolStripMenuItem1.Name = "birimTipleriToolStripMenuItem1";
            this.birimTipleriToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.birimTipleriToolStripMenuItem1.Text = "Birim Tipleri";
            this.birimTipleriToolStripMenuItem1.Click += new System.EventHandler(this.birimTipleriToolStripMenuItem1_Click);
            // 
            // kasalarToolStripMenuItem
            // 
            this.kasalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kasaToolStripMenuItem,
            this.kasaHareketleriToolStripMenuItem,
            this.kasaHareketTipleriToolStripMenuItem});
            this.kasalarToolStripMenuItem.Name = "kasalarToolStripMenuItem";
            this.kasalarToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.kasalarToolStripMenuItem.Text = "Kasalar";
            // 
            // kasaToolStripMenuItem
            // 
            this.kasaToolStripMenuItem.Name = "kasaToolStripMenuItem";
            this.kasaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.kasaToolStripMenuItem.Text = "Kasa";
            this.kasaToolStripMenuItem.Click += new System.EventHandler(this.kasaToolStripMenuItem_Click);
            // 
            // kasaHareketleriToolStripMenuItem
            // 
            this.kasaHareketleriToolStripMenuItem.Name = "kasaHareketleriToolStripMenuItem";
            this.kasaHareketleriToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.kasaHareketleriToolStripMenuItem.Text = "Kasa Hareketleri";
            // 
            // kasaHareketTipleriToolStripMenuItem
            // 
            this.kasaHareketTipleriToolStripMenuItem.Name = "kasaHareketTipleriToolStripMenuItem";
            this.kasaHareketTipleriToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.kasaHareketTipleriToolStripMenuItem.Text = "Kasa hareket Tipleri";
            // 
            // kasaHareketToolStripMenuItem
            // 
            this.kasaHareketToolStripMenuItem.Name = "kasaHareketToolStripMenuItem";
            this.kasaHareketToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kasaHareketToolStripMenuItem.Text = "Tedarikçiler";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.personellerToolStripMenuItem.Text = "Personeller";
            this.personellerToolStripMenuItem.Click += new System.EventHandler(this.personellerToolStripMenuItem_Click);
            // 
            // satınAlmaToolStripMenuItem
            // 
            this.satınAlmaToolStripMenuItem.Name = "satınAlmaToolStripMenuItem";
            this.satınAlmaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.satınAlmaToolStripMenuItem.Text = "Satın Alma";
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.satışToolStripMenuItem.Text = "Satış";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 682);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem birimTipleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaHareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaHareketTipleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaHareketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaÖzellikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özellikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimTipleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satınAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaTüeleriToolStripMenuItem;
    }
}

