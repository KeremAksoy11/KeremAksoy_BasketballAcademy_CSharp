namespace Basketbol_Akademisi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.erkekOlanlarıFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kızOlanlarıFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erlekVe180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaşı18ÜstüOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyu180CmdenBüyükOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilk10KayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.enYeniKayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enSonKayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.yaşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripTextBox1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 36);
            this.toolStripButton1.Text = "Listele";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 36);
            this.toolStripButton2.Text = "Kayıt Sil";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erkekOlanlarıFiltreleToolStripMenuItem,
            this.kızOlanlarıFiltreleToolStripMenuItem,
            this.erlekVe180ToolStripMenuItem,
            this.yaşı18ÜstüOlanlarToolStripMenuItem,
            this.boyu180CmdenBüyükOlanlarToolStripMenuItem,
            this.ilk10KayıtToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(90, 36);
            this.toolStripSplitButton1.Text = "Filtrele";
            // 
            // erkekOlanlarıFiltreleToolStripMenuItem
            // 
            this.erkekOlanlarıFiltreleToolStripMenuItem.Name = "erkekOlanlarıFiltreleToolStripMenuItem";
            this.erkekOlanlarıFiltreleToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.erkekOlanlarıFiltreleToolStripMenuItem.Text = "Erkek Olanları Filtrele";
            this.erkekOlanlarıFiltreleToolStripMenuItem.Click += new System.EventHandler(this.ErkekOlanlarıFiltreleToolStripMenuItem_Click);
            // 
            // kızOlanlarıFiltreleToolStripMenuItem
            // 
            this.kızOlanlarıFiltreleToolStripMenuItem.Name = "kızOlanlarıFiltreleToolStripMenuItem";
            this.kızOlanlarıFiltreleToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.kızOlanlarıFiltreleToolStripMenuItem.Text = "Kız Olanları Filtrele";
            this.kızOlanlarıFiltreleToolStripMenuItem.Click += new System.EventHandler(this.KızOlanlarıFiltreleToolStripMenuItem_Click);
            // 
            // erlekVe180ToolStripMenuItem
            // 
            this.erlekVe180ToolStripMenuItem.Name = "erlekVe180ToolStripMenuItem";
            this.erlekVe180ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.erlekVe180ToolStripMenuItem.Text = "Profesiyonel Eğitim Alanlar";
            this.erlekVe180ToolStripMenuItem.Click += new System.EventHandler(this.ErlekVe180ToolStripMenuItem_Click);
            // 
            // yaşı18ÜstüOlanlarToolStripMenuItem
            // 
            this.yaşı18ÜstüOlanlarToolStripMenuItem.Name = "yaşı18ÜstüOlanlarToolStripMenuItem";
            this.yaşı18ÜstüOlanlarToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.yaşı18ÜstüOlanlarToolStripMenuItem.Text = "Yaşı 18 Üstü Olanlar";
            this.yaşı18ÜstüOlanlarToolStripMenuItem.Click += new System.EventHandler(this.Yaşı18ÜstüOlanlarToolStripMenuItem_Click);
            // 
            // boyu180CmdenBüyükOlanlarToolStripMenuItem
            // 
            this.boyu180CmdenBüyükOlanlarToolStripMenuItem.Name = "boyu180CmdenBüyükOlanlarToolStripMenuItem";
            this.boyu180CmdenBüyükOlanlarToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.boyu180CmdenBüyükOlanlarToolStripMenuItem.Text = "Boyu 180 Cm\'den Büyük Olanlar";
            this.boyu180CmdenBüyükOlanlarToolStripMenuItem.Click += new System.EventHandler(this.Boyu180CmdenBüyükOlanlarToolStripMenuItem_Click);
            // 
            // ilk10KayıtToolStripMenuItem
            // 
            this.ilk10KayıtToolStripMenuItem.Name = "ilk10KayıtToolStripMenuItem";
            this.ilk10KayıtToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.ilk10KayıtToolStripMenuItem.Text = "İlk 10 Kayıt";
            this.ilk10KayıtToolStripMenuItem.Click += new System.EventHandler(this.İlk10KayıtToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enYeniKayıtlarToolStripMenuItem,
            this.enSonKayıtlarToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(127, 36);
            this.toolStripSplitButton2.Text = "Hesaplamalar";
            // 
            // enYeniKayıtlarToolStripMenuItem
            // 
            this.enYeniKayıtlarToolStripMenuItem.Name = "enYeniKayıtlarToolStripMenuItem";
            this.enYeniKayıtlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enYeniKayıtlarToolStripMenuItem.Text = "En Yeni Kayıtlar";
            this.enYeniKayıtlarToolStripMenuItem.Click += new System.EventHandler(this.EnYeniKayıtlarToolStripMenuItem_Click);
            // 
            // enSonKayıtlarToolStripMenuItem
            // 
            this.enSonKayıtlarToolStripMenuItem.Name = "enSonKayıtlarToolStripMenuItem";
            this.enSonKayıtlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enSonKayıtlarToolStripMenuItem.Text = "En Son Kayıtlar";
            this.enSonKayıtlarToolStripMenuItem.Click += new System.EventHandler(this.EnSonKayıtlarToolStripMenuItem_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaşToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(127, 36);
            this.toolStripSplitButton3.Text = "Diğer İşlemler";
            // 
            // yaşToolStripMenuItem
            // 
            this.yaşToolStripMenuItem.Name = "yaşToolStripMenuItem";
            this.yaşToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yaşToolStripMenuItem.Text = "Yaş Listeleri Grupla";
            this.yaşToolStripMenuItem.Click += new System.EventHandler(this.YaşToolStripMenuItem_Click);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(61, 36);
            this.toolStripSplitButton4.Text = "Ara";
            this.toolStripSplitButton4.Click += new System.EventHandler(this.ToolStripSplitButton4_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 39);
            this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyUp);
            this.toolStripTextBox1.Click += new System.EventHandler(this.ToolStripTextBox1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton3.Text = "Geri Dön";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basketbol Akademisi Kayıt Listeleri";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem erkekOlanlarıFiltreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kızOlanlarıFiltreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erlekVe180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaşı18ÜstüOlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyu180CmdenBüyükOlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilk10KayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem enYeniKayıtlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enSonKayıtlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem yaşToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}