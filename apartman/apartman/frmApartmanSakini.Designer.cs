namespace apartman
{
    partial class frmApartmanSakini
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
            this.tcApartmanSakini = new System.Windows.Forms.TabControl();
            this.tbSakinGelirler = new System.Windows.Forms.TabPage();
            this.tbSakinGiderler = new System.Windows.Forms.TabPage();
            this.tbSakinBorc = new System.Windows.Forms.TabPage();
            this.tbSakinDuyuru = new System.Windows.Forms.TabPage();
            this.grpSakinDuyuru = new System.Windows.Forms.GroupBox();
            this.btnSakinDuyuru = new System.Windows.Forms.Button();
            this.txtSakinKonu = new System.Windows.Forms.TextBox();
            this.txtSakinKonuBasliği = new System.Windows.Forms.TextBox();
            this.lblSakinKonu = new System.Windows.Forms.Label();
            this.lblSakinKonuBaslik = new System.Windows.Forms.Label();
            this.pnlSakinDuyuru = new System.Windows.Forms.Panel();
            this.dtgSakinDuyurular = new System.Windows.Forms.DataGridView();
            this.btnSakinDuyurular = new System.Windows.Forms.Button();
            this.btnSakinDuyuruEkle = new System.Windows.Forms.Button();
            this.tbCikis = new System.Windows.Forms.TabPage();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dtgSakinGelirler = new System.Windows.Forms.DataGridView();
            this.dtgSakinGiderler = new System.Windows.Forms.DataGridView();
            this.dtgSakinBorcListesi = new System.Windows.Forms.DataGridView();
            this.tcApartmanSakini.SuspendLayout();
            this.tbSakinGelirler.SuspendLayout();
            this.tbSakinGiderler.SuspendLayout();
            this.tbSakinBorc.SuspendLayout();
            this.tbSakinDuyuru.SuspendLayout();
            this.grpSakinDuyuru.SuspendLayout();
            this.pnlSakinDuyuru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinDuyurular)).BeginInit();
            this.tbCikis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinGelirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinGiderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinBorcListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // tcApartmanSakini
            // 
            this.tcApartmanSakini.Controls.Add(this.tbSakinGelirler);
            this.tcApartmanSakini.Controls.Add(this.tbSakinGiderler);
            this.tcApartmanSakini.Controls.Add(this.tbSakinBorc);
            this.tcApartmanSakini.Controls.Add(this.tbSakinDuyuru);
            this.tcApartmanSakini.Controls.Add(this.tbCikis);
            this.tcApartmanSakini.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcApartmanSakini.HotTrack = true;
            this.tcApartmanSakini.Location = new System.Drawing.Point(23, 16);
            this.tcApartmanSakini.Margin = new System.Windows.Forms.Padding(4);
            this.tcApartmanSakini.Name = "tcApartmanSakini";
            this.tcApartmanSakini.SelectedIndex = 0;
            this.tcApartmanSakini.Size = new System.Drawing.Size(1079, 562);
            this.tcApartmanSakini.TabIndex = 0;
            // 
            // tbSakinGelirler
            // 
            this.tbSakinGelirler.Controls.Add(this.dtgSakinGelirler);
            this.tbSakinGelirler.Location = new System.Drawing.Point(4, 32);
            this.tbSakinGelirler.Margin = new System.Windows.Forms.Padding(4);
            this.tbSakinGelirler.Name = "tbSakinGelirler";
            this.tbSakinGelirler.Padding = new System.Windows.Forms.Padding(4);
            this.tbSakinGelirler.Size = new System.Drawing.Size(1071, 526);
            this.tbSakinGelirler.TabIndex = 0;
            this.tbSakinGelirler.Text = "GELİRLER";
            this.tbSakinGelirler.UseVisualStyleBackColor = true;
            // 
            // tbSakinGiderler
            // 
            this.tbSakinGiderler.Controls.Add(this.dtgSakinGiderler);
            this.tbSakinGiderler.Location = new System.Drawing.Point(4, 32);
            this.tbSakinGiderler.Margin = new System.Windows.Forms.Padding(4);
            this.tbSakinGiderler.Name = "tbSakinGiderler";
            this.tbSakinGiderler.Padding = new System.Windows.Forms.Padding(4);
            this.tbSakinGiderler.Size = new System.Drawing.Size(1071, 526);
            this.tbSakinGiderler.TabIndex = 1;
            this.tbSakinGiderler.Text = "GİDERLER";
            this.tbSakinGiderler.UseVisualStyleBackColor = true;
            // 
            // tbSakinBorc
            // 
            this.tbSakinBorc.Controls.Add(this.dtgSakinBorcListesi);
            this.tbSakinBorc.Location = new System.Drawing.Point(4, 32);
            this.tbSakinBorc.Margin = new System.Windows.Forms.Padding(4);
            this.tbSakinBorc.Name = "tbSakinBorc";
            this.tbSakinBorc.Padding = new System.Windows.Forms.Padding(4);
            this.tbSakinBorc.Size = new System.Drawing.Size(1071, 526);
            this.tbSakinBorc.TabIndex = 2;
            this.tbSakinBorc.Text = "BORÇLARIM";
            this.tbSakinBorc.UseVisualStyleBackColor = true;
            // 
            // tbSakinDuyuru
            // 
            this.tbSakinDuyuru.Controls.Add(this.grpSakinDuyuru);
            this.tbSakinDuyuru.Controls.Add(this.pnlSakinDuyuru);
            this.tbSakinDuyuru.Controls.Add(this.btnSakinDuyurular);
            this.tbSakinDuyuru.Controls.Add(this.btnSakinDuyuruEkle);
            this.tbSakinDuyuru.Location = new System.Drawing.Point(4, 32);
            this.tbSakinDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.tbSakinDuyuru.Name = "tbSakinDuyuru";
            this.tbSakinDuyuru.Padding = new System.Windows.Forms.Padding(4);
            this.tbSakinDuyuru.Size = new System.Drawing.Size(1071, 526);
            this.tbSakinDuyuru.TabIndex = 3;
            this.tbSakinDuyuru.Text = "DUYURULAR ";
            this.tbSakinDuyuru.UseVisualStyleBackColor = true;
            // 
            // grpSakinDuyuru
            // 
            this.grpSakinDuyuru.Controls.Add(this.btnSakinDuyuru);
            this.grpSakinDuyuru.Controls.Add(this.txtSakinKonu);
            this.grpSakinDuyuru.Controls.Add(this.txtSakinKonuBasliği);
            this.grpSakinDuyuru.Controls.Add(this.lblSakinKonu);
            this.grpSakinDuyuru.Controls.Add(this.lblSakinKonuBaslik);
            this.grpSakinDuyuru.Location = new System.Drawing.Point(277, 121);
            this.grpSakinDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.grpSakinDuyuru.Name = "grpSakinDuyuru";
            this.grpSakinDuyuru.Padding = new System.Windows.Forms.Padding(4);
            this.grpSakinDuyuru.Size = new System.Drawing.Size(535, 370);
            this.grpSakinDuyuru.TabIndex = 2;
            this.grpSakinDuyuru.TabStop = false;
            this.grpSakinDuyuru.Text = "Yeni Duyuru Ekle";
            // 
            // btnSakinDuyuru
            // 
            this.btnSakinDuyuru.Location = new System.Drawing.Point(340, 249);
            this.btnSakinDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.btnSakinDuyuru.Name = "btnSakinDuyuru";
            this.btnSakinDuyuru.Size = new System.Drawing.Size(172, 50);
            this.btnSakinDuyuru.TabIndex = 4;
            this.btnSakinDuyuru.Text = "DUYURU EKLE";
            this.btnSakinDuyuru.UseVisualStyleBackColor = true;
            this.btnSakinDuyuru.Click += new System.EventHandler(this.btnSakinDuyuru_Click);
            // 
            // txtSakinKonu
            // 
            this.txtSakinKonu.Location = new System.Drawing.Point(183, 84);
            this.txtSakinKonu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSakinKonu.Multiline = true;
            this.txtSakinKonu.Name = "txtSakinKonu";
            this.txtSakinKonu.Size = new System.Drawing.Size(200, 157);
            this.txtSakinKonu.TabIndex = 3;
            // 
            // txtSakinKonuBasliği
            // 
            this.txtSakinKonuBasliği.Location = new System.Drawing.Point(183, 36);
            this.txtSakinKonuBasliği.Margin = new System.Windows.Forms.Padding(4);
            this.txtSakinKonuBasliği.Name = "txtSakinKonuBasliği";
            this.txtSakinKonuBasliği.Size = new System.Drawing.Size(200, 31);
            this.txtSakinKonuBasliği.TabIndex = 2;
            // 
            // lblSakinKonu
            // 
            this.lblSakinKonu.AutoSize = true;
            this.lblSakinKonu.Location = new System.Drawing.Point(23, 91);
            this.lblSakinKonu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSakinKonu.Name = "lblSakinKonu";
            this.lblSakinKonu.Size = new System.Drawing.Size(71, 23);
            this.lblSakinKonu.TabIndex = 1;
            this.lblSakinKonu.Text = "Konu : ";
            // 
            // lblSakinKonuBaslik
            // 
            this.lblSakinKonuBaslik.AutoSize = true;
            this.lblSakinKonuBaslik.Location = new System.Drawing.Point(23, 43);
            this.lblSakinKonuBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSakinKonuBaslik.Name = "lblSakinKonuBaslik";
            this.lblSakinKonuBaslik.Size = new System.Drawing.Size(133, 23);
            this.lblSakinKonuBaslik.TabIndex = 0;
            this.lblSakinKonuBaslik.Text = "Konu Başlığı : ";
            // 
            // pnlSakinDuyuru
            // 
            this.pnlSakinDuyuru.Controls.Add(this.dtgSakinDuyurular);
            this.pnlSakinDuyuru.Location = new System.Drawing.Point(193, 92);
            this.pnlSakinDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSakinDuyuru.Name = "pnlSakinDuyuru";
            this.pnlSakinDuyuru.Size = new System.Drawing.Size(690, 415);
            this.pnlSakinDuyuru.TabIndex = 3;
            // 
            // dtgSakinDuyurular
            // 
            this.dtgSakinDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSakinDuyurular.Location = new System.Drawing.Point(45, 15);
            this.dtgSakinDuyurular.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSakinDuyurular.Name = "dtgSakinDuyurular";
            this.dtgSakinDuyurular.RowHeadersWidth = 51;
            this.dtgSakinDuyurular.Size = new System.Drawing.Size(606, 384);
            this.dtgSakinDuyurular.TabIndex = 0;
            // 
            // btnSakinDuyurular
            // 
            this.btnSakinDuyurular.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic);
            this.btnSakinDuyurular.Location = new System.Drawing.Point(579, 25);
            this.btnSakinDuyurular.Margin = new System.Windows.Forms.Padding(4);
            this.btnSakinDuyurular.Name = "btnSakinDuyurular";
            this.btnSakinDuyurular.Size = new System.Drawing.Size(233, 42);
            this.btnSakinDuyurular.TabIndex = 1;
            this.btnSakinDuyurular.Text = "DUYURULAR";
            this.btnSakinDuyurular.UseVisualStyleBackColor = true;
            this.btnSakinDuyurular.Click += new System.EventHandler(this.btnSakinDuyurular_Click);
            // 
            // btnSakinDuyuruEkle
            // 
            this.btnSakinDuyuruEkle.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic);
            this.btnSakinDuyuruEkle.Location = new System.Drawing.Point(277, 25);
            this.btnSakinDuyuruEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSakinDuyuruEkle.Name = "btnSakinDuyuruEkle";
            this.btnSakinDuyuruEkle.Size = new System.Drawing.Size(233, 42);
            this.btnSakinDuyuruEkle.TabIndex = 0;
            this.btnSakinDuyuruEkle.Text = "YENİ DUYURU EKLE";
            this.btnSakinDuyuruEkle.UseVisualStyleBackColor = true;
            this.btnSakinDuyuruEkle.Click += new System.EventHandler(this.btnSakinDuyuruEkle_Click);
            // 
            // tbCikis
            // 
            this.tbCikis.Controls.Add(this.btnCikis);
            this.tbCikis.Location = new System.Drawing.Point(4, 32);
            this.tbCikis.Name = "tbCikis";
            this.tbCikis.Padding = new System.Windows.Forms.Padding(3);
            this.tbCikis.Size = new System.Drawing.Size(1071, 526);
            this.tbCikis.TabIndex = 4;
            this.tbCikis.Text = "ÇIKIŞ";
            this.tbCikis.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(470, 159);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(116, 67);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dtgSakinGelirler
            // 
            this.dtgSakinGelirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSakinGelirler.Location = new System.Drawing.Point(56, 27);
            this.dtgSakinGelirler.Name = "dtgSakinGelirler";
            this.dtgSakinGelirler.RowHeadersWidth = 51;
            this.dtgSakinGelirler.RowTemplate.Height = 24;
            this.dtgSakinGelirler.Size = new System.Drawing.Size(930, 453);
            this.dtgSakinGelirler.TabIndex = 0;
            // 
            // dtgSakinGiderler
            // 
            this.dtgSakinGiderler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSakinGiderler.Location = new System.Drawing.Point(70, 32);
            this.dtgSakinGiderler.Name = "dtgSakinGiderler";
            this.dtgSakinGiderler.RowHeadersWidth = 51;
            this.dtgSakinGiderler.RowTemplate.Height = 24;
            this.dtgSakinGiderler.Size = new System.Drawing.Size(887, 440);
            this.dtgSakinGiderler.TabIndex = 0;
            // 
            // dtgSakinBorcListesi
            // 
            this.dtgSakinBorcListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSakinBorcListesi.Location = new System.Drawing.Point(70, 49);
            this.dtgSakinBorcListesi.Name = "dtgSakinBorcListesi";
            this.dtgSakinBorcListesi.RowHeadersWidth = 51;
            this.dtgSakinBorcListesi.RowTemplate.Height = 24;
            this.dtgSakinBorcListesi.Size = new System.Drawing.Size(920, 434);
            this.dtgSakinBorcListesi.TabIndex = 0;
            // 
            // frmApartmanSakini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 609);
            this.Controls.Add(this.tcApartmanSakini);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApartmanSakini";
            this.Text = " APARTMAN SAKİNİ";
            this.Load += new System.EventHandler(this.frmApartmanSakini_Load);
            this.tcApartmanSakini.ResumeLayout(false);
            this.tbSakinGelirler.ResumeLayout(false);
            this.tbSakinGiderler.ResumeLayout(false);
            this.tbSakinBorc.ResumeLayout(false);
            this.tbSakinDuyuru.ResumeLayout(false);
            this.grpSakinDuyuru.ResumeLayout(false);
            this.grpSakinDuyuru.PerformLayout();
            this.pnlSakinDuyuru.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinDuyurular)).EndInit();
            this.tbCikis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinGelirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinGiderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSakinBorcListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcApartmanSakini;
        private System.Windows.Forms.TabPage tbSakinGelirler;
        private System.Windows.Forms.TabPage tbSakinGiderler;
        private System.Windows.Forms.TabPage tbSakinBorc;
        private System.Windows.Forms.TabPage tbSakinDuyuru;
        private System.Windows.Forms.GroupBox grpSakinDuyuru;
        private System.Windows.Forms.Button btnSakinDuyurular;
        private System.Windows.Forms.Button btnSakinDuyuruEkle;
        private System.Windows.Forms.Label lblSakinKonu;
        private System.Windows.Forms.Label lblSakinKonuBaslik;
        private System.Windows.Forms.Button btnSakinDuyuru;
        private System.Windows.Forms.TextBox txtSakinKonu;
        private System.Windows.Forms.TextBox txtSakinKonuBasliği;
        private System.Windows.Forms.Panel pnlSakinDuyuru;
        private System.Windows.Forms.DataGridView dtgSakinDuyurular;
        private System.Windows.Forms.TabPage tbCikis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dtgSakinGelirler;
        private System.Windows.Forms.DataGridView dtgSakinGiderler;
        private System.Windows.Forms.DataGridView dtgSakinBorcListesi;
    }
}