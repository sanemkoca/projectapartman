namespace apartman
{
    partial class frmApartmanGiris
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
            this.lblGirisyap = new System.Windows.Forms.Label();
            this.lblGiristc = new System.Windows.Forms.Label();
            this.lblGirissifre = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGirisyap
            // 
            this.lblGirisyap.AutoSize = true;
            this.lblGirisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisyap.Location = new System.Drawing.Point(117, 62);
            this.lblGirisyap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGirisyap.Name = "lblGirisyap";
            this.lblGirisyap.Size = new System.Drawing.Size(315, 29);
            this.lblGirisyap.TabIndex = 0;
            this.lblGirisyap.Text = "LÜTFEN GİRİŞ YAPINIZ...";
            // 
            // lblGiristc
            // 
            this.lblGiristc.AutoSize = true;
            this.lblGiristc.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiristc.Location = new System.Drawing.Point(39, 136);
            this.lblGiristc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiristc.Name = "lblGiristc";
            this.lblGiristc.Size = new System.Drawing.Size(144, 23);
            this.lblGiristc.TabIndex = 1;
            this.lblGiristc.Text = "Kullanıcı Adı : ";
            // 
            // lblGirissifre
            // 
            this.lblGirissifre.AutoSize = true;
            this.lblGirissifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGirissifre.Location = new System.Drawing.Point(39, 185);
            this.lblGirissifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGirissifre.Name = "lblGirissifre";
            this.lblGirissifre.Size = new System.Drawing.Size(70, 24);
            this.lblGirissifre.TabIndex = 2;
            this.lblGirissifre.Text = "Şifre : ";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(187, 140);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKullanici.Multiline = true;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(132, 20);
            this.txtKullanici.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(187, 187);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(132, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(187, 245);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(132, 37);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic);
            this.btnCikis.Location = new System.Drawing.Point(347, 245);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(132, 37);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "SAĞLAM DETAY APARTMANI";
            // 
            // frmApartmanGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblGirissifre);
            this.Controls.Add(this.lblGiristc);
            this.Controls.Add(this.lblGirisyap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmApartmanGiris";
            this.Text = "APARTMAN YÖNETİM SİSTEMİNE GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGirisyap;
        private System.Windows.Forms.Label lblGiristc;
        private System.Windows.Forms.Label lblGirissifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
    }
}

