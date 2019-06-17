namespace FindMyBed
{
    partial class RezervasyonForm
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
            this.gbxKişi = new System.Windows.Forms.GroupBox();
            this.tbxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.tbxEposta = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxKimlik = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblKimlik = new System.Windows.Forms.Label();
            this.lblSoyadı = new System.Windows.Forms.Label();
            this.lblAdı = new System.Windows.Forms.Label();
            this.gbxRezervasyon = new System.Windows.Forms.GroupBox();
            this.tbxÜcret = new System.Windows.Forms.TextBox();
            this.tbxÇıkış = new System.Windows.Forms.TextBox();
            this.tbxGiriş = new System.Windows.Forms.TextBox();
            this.tbxVillaAd = new System.Windows.Forms.TextBox();
            this.tbxBölge = new System.Windows.Forms.TextBox();
            this.lblÜcret = new System.Windows.Forms.Label();
            this.lblÇıkış = new System.Windows.Forms.Label();
            this.lblBölge = new System.Windows.Forms.Label();
            this.lblGiriş = new System.Windows.Forms.Label();
            this.lblVilla = new System.Windows.Forms.Label();
            this.gbxRezvEkle = new System.Windows.Forms.GroupBox();
            this.btnKişiAra = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gbxKişi.SuspendLayout();
            this.gbxRezervasyon.SuspendLayout();
            this.gbxRezvEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKişi
            // 
            this.gbxKişi.Controls.Add(this.tbxTelefon);
            this.gbxKişi.Controls.Add(this.tbxEposta);
            this.gbxKişi.Controls.Add(this.tbxSoyad);
            this.gbxKişi.Controls.Add(this.tbxAd);
            this.gbxKişi.Controls.Add(this.tbxKimlik);
            this.gbxKişi.Controls.Add(this.lblEposta);
            this.gbxKişi.Controls.Add(this.lblTel);
            this.gbxKişi.Controls.Add(this.lblKimlik);
            this.gbxKişi.Controls.Add(this.lblSoyadı);
            this.gbxKişi.Controls.Add(this.lblAdı);
            this.gbxKişi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxKişi.Location = new System.Drawing.Point(37, 32);
            this.gbxKişi.Name = "gbxKişi";
            this.gbxKişi.Size = new System.Drawing.Size(336, 318);
            this.gbxKişi.TabIndex = 0;
            this.gbxKişi.TabStop = false;
            this.gbxKişi.Text = "Misafir Bilgileri";
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(104, 212);
            this.tbxTelefon.Mask = "(999) 000-0000";
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(161, 22);
            this.tbxTelefon.TabIndex = 10;
            // 
            // tbxEposta
            // 
            this.tbxEposta.Location = new System.Drawing.Point(104, 266);
            this.tbxEposta.Name = "tbxEposta";
            this.tbxEposta.Size = new System.Drawing.Size(161, 22);
            this.tbxEposta.TabIndex = 9;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(104, 153);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(161, 22);
            this.tbxSoyad.TabIndex = 7;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(103, 98);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(162, 22);
            this.tbxAd.TabIndex = 6;
            // 
            // tbxKimlik
            // 
            this.tbxKimlik.Location = new System.Drawing.Point(104, 43);
            this.tbxKimlik.Name = "tbxKimlik";
            this.tbxKimlik.Size = new System.Drawing.Size(161, 22);
            this.tbxKimlik.TabIndex = 5;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(24, 273);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(55, 16);
            this.lblEposta.TabIndex = 4;
            this.lblEposta.Text = "E-Posta";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(24, 219);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(48, 16);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Telefon";
            // 
            // lblKimlik
            // 
            this.lblKimlik.AutoSize = true;
            this.lblKimlik.Location = new System.Drawing.Point(24, 49);
            this.lblKimlik.Name = "lblKimlik";
            this.lblKimlik.Size = new System.Drawing.Size(64, 16);
            this.lblKimlik.TabIndex = 2;
            this.lblKimlik.Text = "Kimlik No";
            // 
            // lblSoyadı
            // 
            this.lblSoyadı.AutoSize = true;
            this.lblSoyadı.Location = new System.Drawing.Point(24, 160);
            this.lblSoyadı.Name = "lblSoyadı";
            this.lblSoyadı.Size = new System.Drawing.Size(48, 16);
            this.lblSoyadı.TabIndex = 1;
            this.lblSoyadı.Text = "Soyadı";
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.Location = new System.Drawing.Point(24, 105);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(27, 16);
            this.lblAdı.TabIndex = 0;
            this.lblAdı.Text = "Adı";
            // 
            // gbxRezervasyon
            // 
            this.gbxRezervasyon.Controls.Add(this.tbxÜcret);
            this.gbxRezervasyon.Controls.Add(this.tbxÇıkış);
            this.gbxRezervasyon.Controls.Add(this.tbxGiriş);
            this.gbxRezervasyon.Controls.Add(this.tbxVillaAd);
            this.gbxRezervasyon.Controls.Add(this.tbxBölge);
            this.gbxRezervasyon.Controls.Add(this.lblÜcret);
            this.gbxRezervasyon.Controls.Add(this.lblÇıkış);
            this.gbxRezervasyon.Controls.Add(this.lblBölge);
            this.gbxRezervasyon.Controls.Add(this.lblGiriş);
            this.gbxRezervasyon.Controls.Add(this.lblVilla);
            this.gbxRezervasyon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRezervasyon.Location = new System.Drawing.Point(411, 32);
            this.gbxRezervasyon.Name = "gbxRezervasyon";
            this.gbxRezervasyon.Size = new System.Drawing.Size(336, 318);
            this.gbxRezervasyon.TabIndex = 1;
            this.gbxRezervasyon.TabStop = false;
            this.gbxRezervasyon.Text = "Rezervasyon Bilgileri";
            // 
            // tbxÜcret
            // 
            this.tbxÜcret.Location = new System.Drawing.Point(125, 266);
            this.tbxÜcret.Name = "tbxÜcret";
            this.tbxÜcret.ReadOnly = true;
            this.tbxÜcret.Size = new System.Drawing.Size(161, 22);
            this.tbxÜcret.TabIndex = 19;
            // 
            // tbxÇıkış
            // 
            this.tbxÇıkış.Location = new System.Drawing.Point(125, 212);
            this.tbxÇıkış.Name = "tbxÇıkış";
            this.tbxÇıkış.ReadOnly = true;
            this.tbxÇıkış.Size = new System.Drawing.Size(161, 22);
            this.tbxÇıkış.TabIndex = 18;
            // 
            // tbxGiriş
            // 
            this.tbxGiriş.Location = new System.Drawing.Point(125, 153);
            this.tbxGiriş.Name = "tbxGiriş";
            this.tbxGiriş.ReadOnly = true;
            this.tbxGiriş.Size = new System.Drawing.Size(161, 22);
            this.tbxGiriş.TabIndex = 17;
            // 
            // tbxVillaAd
            // 
            this.tbxVillaAd.Location = new System.Drawing.Point(124, 98);
            this.tbxVillaAd.Name = "tbxVillaAd";
            this.tbxVillaAd.ReadOnly = true;
            this.tbxVillaAd.Size = new System.Drawing.Size(162, 22);
            this.tbxVillaAd.TabIndex = 16;
            // 
            // tbxBölge
            // 
            this.tbxBölge.Location = new System.Drawing.Point(125, 43);
            this.tbxBölge.Name = "tbxBölge";
            this.tbxBölge.ReadOnly = true;
            this.tbxBölge.Size = new System.Drawing.Size(161, 22);
            this.tbxBölge.TabIndex = 15;
            // 
            // lblÜcret
            // 
            this.lblÜcret.AutoSize = true;
            this.lblÜcret.Location = new System.Drawing.Point(35, 272);
            this.lblÜcret.Name = "lblÜcret";
            this.lblÜcret.Size = new System.Drawing.Size(84, 16);
            this.lblÜcret.TabIndex = 14;
            this.lblÜcret.Text = "Toplam Ücret";
            // 
            // lblÇıkış
            // 
            this.lblÇıkış.AutoSize = true;
            this.lblÇıkış.Location = new System.Drawing.Point(35, 218);
            this.lblÇıkış.Name = "lblÇıkış";
            this.lblÇıkış.Size = new System.Drawing.Size(71, 16);
            this.lblÇıkış.TabIndex = 13;
            this.lblÇıkış.Text = "Çıkış Tarihi";
            // 
            // lblBölge
            // 
            this.lblBölge.AutoSize = true;
            this.lblBölge.Location = new System.Drawing.Point(35, 48);
            this.lblBölge.Name = "lblBölge";
            this.lblBölge.Size = new System.Drawing.Size(41, 16);
            this.lblBölge.TabIndex = 12;
            this.lblBölge.Text = "Bölge";
            // 
            // lblGiriş
            // 
            this.lblGiriş.AutoSize = true;
            this.lblGiriş.Location = new System.Drawing.Point(35, 159);
            this.lblGiriş.Name = "lblGiriş";
            this.lblGiriş.Size = new System.Drawing.Size(69, 16);
            this.lblGiriş.TabIndex = 11;
            this.lblGiriş.Text = "Giriş Tarihi";
            // 
            // lblVilla
            // 
            this.lblVilla.AutoSize = true;
            this.lblVilla.Location = new System.Drawing.Point(35, 104);
            this.lblVilla.Name = "lblVilla";
            this.lblVilla.Size = new System.Drawing.Size(55, 16);
            this.lblVilla.TabIndex = 10;
            this.lblVilla.Text = "Villa Adı";
            // 
            // gbxRezvEkle
            // 
            this.gbxRezvEkle.BackColor = System.Drawing.Color.White;
            this.gbxRezvEkle.Controls.Add(this.btnKişiAra);
            this.gbxRezvEkle.Controls.Add(this.btnVazgeç);
            this.gbxRezvEkle.Controls.Add(this.btnKaydet);
            this.gbxRezvEkle.Controls.Add(this.gbxRezervasyon);
            this.gbxRezvEkle.Controls.Add(this.gbxKişi);
            this.gbxRezvEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRezvEkle.Location = new System.Drawing.Point(56, 12);
            this.gbxRezvEkle.Name = "gbxRezvEkle";
            this.gbxRezvEkle.Size = new System.Drawing.Size(790, 392);
            this.gbxRezvEkle.TabIndex = 2;
            this.gbxRezvEkle.TabStop = false;
            this.gbxRezvEkle.Text = "Rezervasyon Ekle";
            // 
            // btnKişiAra
            // 
            this.btnKişiAra.Location = new System.Drawing.Point(37, 356);
            this.btnKişiAra.Name = "btnKişiAra";
            this.btnKişiAra.Size = new System.Drawing.Size(98, 30);
            this.btnKişiAra.TabIndex = 4;
            this.btnKişiAra.Text = "Kayıtlı Misafir";
            this.btnKişiAra.UseVisualStyleBackColor = true;
            this.btnKişiAra.Click += new System.EventHandler(this.BtnKişiAra_Click);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.Location = new System.Drawing.Point(660, 356);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(87, 30);
            this.btnVazgeç.TabIndex = 3;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = true;
            this.btnVazgeç.Click += new System.EventHandler(this.BtnVazgeç_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(567, 356);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 30);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 416);
            this.Controls.Add(this.gbxRezvEkle);
            this.Name = "RezervasyonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Ekle";
            this.gbxKişi.ResumeLayout(false);
            this.gbxKişi.PerformLayout();
            this.gbxRezervasyon.ResumeLayout(false);
            this.gbxRezervasyon.PerformLayout();
            this.gbxRezvEkle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKişi;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblKimlik;
        private System.Windows.Forms.Label lblSoyadı;
        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.GroupBox gbxRezervasyon;
        private System.Windows.Forms.Label lblÜcret;
        private System.Windows.Forms.Label lblÇıkış;
        private System.Windows.Forms.Label lblBölge;
        private System.Windows.Forms.Label lblGiriş;
        private System.Windows.Forms.Label lblVilla;
        public System.Windows.Forms.TextBox tbxBölge;
        public System.Windows.Forms.TextBox tbxVillaAd;
        public System.Windows.Forms.TextBox tbxÇıkış;
        public System.Windows.Forms.TextBox tbxGiriş;
        public System.Windows.Forms.TextBox tbxÜcret;
        private System.Windows.Forms.GroupBox gbxRezvEkle;
        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKişiAra;
        public System.Windows.Forms.TextBox tbxEposta;
        public System.Windows.Forms.TextBox tbxSoyad;
        public System.Windows.Forms.TextBox tbxAd;
        public System.Windows.Forms.TextBox tbxKimlik;
        public System.Windows.Forms.MaskedTextBox tbxTelefon;
    }
}