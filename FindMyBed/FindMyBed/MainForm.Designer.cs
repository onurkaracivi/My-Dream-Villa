namespace FindMyBed
{
    partial class FrmFindMyBed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxBölge = new System.Windows.Forms.ComboBox();
            this.lblBölge = new System.Windows.Forms.Label();
            this.dTimeGiriş = new System.Windows.Forms.DateTimePicker();
            this.dTimeÇıkış = new System.Windows.Forms.DateTimePicker();
            this.lblGiriş = new System.Windows.Forms.Label();
            this.lblÇıkış = new System.Windows.Forms.Label();
            this.dgwVilla = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxSonuç = new System.Windows.Forms.GroupBox();
            this.lblÜcret = new System.Windows.Forms.Label();
            this.tbxÜcret = new System.Windows.Forms.TextBox();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.gbxArama = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxVilla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVilla)).BeginInit();
            this.gbxSonuç.SuspendLayout();
            this.gbxArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBölge
            // 
            this.cbxBölge.FormattingEnabled = true;
            this.cbxBölge.Location = new System.Drawing.Point(147, 59);
            this.cbxBölge.Name = "cbxBölge";
            this.cbxBölge.Size = new System.Drawing.Size(175, 24);
            this.cbxBölge.TabIndex = 0;
            // 
            // lblBölge
            // 
            this.lblBölge.AutoSize = true;
            this.lblBölge.Location = new System.Drawing.Point(6, 62);
            this.lblBölge.Name = "lblBölge";
            this.lblBölge.Size = new System.Drawing.Size(135, 16);
            this.lblBölge.TabIndex = 2;
            this.lblBölge.Text = "Nereye Gideceksiniz?";
            // 
            // dTimeGiriş
            // 
            this.dTimeGiriş.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTimeGiriş.Location = new System.Drawing.Point(118, 92);
            this.dTimeGiriş.Name = "dTimeGiriş";
            this.dTimeGiriş.Size = new System.Drawing.Size(204, 22);
            this.dTimeGiriş.TabIndex = 3;
            this.dTimeGiriş.Value = new System.DateTime(2019, 6, 13, 19, 10, 41, 0);
            // 
            // dTimeÇıkış
            // 
            this.dTimeÇıkış.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTimeÇıkış.Location = new System.Drawing.Point(118, 126);
            this.dTimeÇıkış.Name = "dTimeÇıkış";
            this.dTimeÇıkış.Size = new System.Drawing.Size(204, 22);
            this.dTimeÇıkış.TabIndex = 4;
            // 
            // lblGiriş
            // 
            this.lblGiriş.AutoSize = true;
            this.lblGiriş.Location = new System.Drawing.Point(6, 98);
            this.lblGiriş.Name = "lblGiriş";
            this.lblGiriş.Size = new System.Drawing.Size(69, 16);
            this.lblGiriş.TabIndex = 6;
            this.lblGiriş.Text = "Giriş Tarihi";
            // 
            // lblÇıkış
            // 
            this.lblÇıkış.AutoSize = true;
            this.lblÇıkış.Location = new System.Drawing.Point(6, 132);
            this.lblÇıkış.Name = "lblÇıkış";
            this.lblÇıkış.Size = new System.Drawing.Size(71, 16);
            this.lblÇıkış.TabIndex = 7;
            this.lblÇıkış.Text = "Çıkış Tarihi";
            // 
            // dgwVilla
            // 
            this.dgwVilla.AllowUserToAddRows = false;
            this.dgwVilla.AllowUserToDeleteRows = false;
            this.dgwVilla.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwVilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwVilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwVilla.BackgroundColor = System.Drawing.Color.White;
            this.dgwVilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwVilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwVilla.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwVilla.Location = new System.Drawing.Point(6, 34);
            this.dgwVilla.MultiSelect = false;
            this.dgwVilla.Name = "dgwVilla";
            this.dgwVilla.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgwVilla.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwVilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwVilla.Size = new System.Drawing.Size(267, 228);
            this.dgwVilla.TabIndex = 9;
            this.dgwVilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwVilla_CellClick);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(236, 180);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 30);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbxSonuç
            // 
            this.gbxSonuç.Controls.Add(this.lblÜcret);
            this.gbxSonuç.Controls.Add(this.tbxÜcret);
            this.gbxSonuç.Controls.Add(this.btnRezervasyon);
            this.gbxSonuç.Controls.Add(this.pbxVilla);
            this.gbxSonuç.Controls.Add(this.dgwVilla);
            this.gbxSonuç.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSonuç.Location = new System.Drawing.Point(363, 12);
            this.gbxSonuç.Name = "gbxSonuç";
            this.gbxSonuç.Size = new System.Drawing.Size(524, 309);
            this.gbxSonuç.TabIndex = 12;
            this.gbxSonuç.TabStop = false;
            this.gbxSonuç.Text = "Arama Sonuçları";
            this.gbxSonuç.Visible = false;
            // 
            // lblÜcret
            // 
            this.lblÜcret.AutoSize = true;
            this.lblÜcret.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜcret.ForeColor = System.Drawing.Color.Red;
            this.lblÜcret.Location = new System.Drawing.Point(182, 274);
            this.lblÜcret.Name = "lblÜcret";
            this.lblÜcret.Size = new System.Drawing.Size(92, 16);
            this.lblÜcret.TabIndex = 15;
            this.lblÜcret.Text = "Toplam Ücret";
            this.lblÜcret.Visible = false;
            // 
            // tbxÜcret
            // 
            this.tbxÜcret.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxÜcret.ForeColor = System.Drawing.Color.Red;
            this.tbxÜcret.Location = new System.Drawing.Point(280, 271);
            this.tbxÜcret.Name = "tbxÜcret";
            this.tbxÜcret.ReadOnly = true;
            this.tbxÜcret.Size = new System.Drawing.Size(100, 22);
            this.tbxÜcret.TabIndex = 13;
            this.tbxÜcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxÜcret.Visible = false;
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Location = new System.Drawing.Point(386, 267);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(132, 30);
            this.btnRezervasyon.TabIndex = 12;
            this.btnRezervasyon.Text = "Rezervasyon Yap";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Visible = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.BtnRezervasyon_Click);
            // 
            // gbxArama
            // 
            this.gbxArama.Controls.Add(this.lblBölge);
            this.gbxArama.Controls.Add(this.cbxBölge);
            this.gbxArama.Controls.Add(this.btnAra);
            this.gbxArama.Controls.Add(this.dTimeGiriş);
            this.gbxArama.Controls.Add(this.lblÇıkış);
            this.gbxArama.Controls.Add(this.dTimeÇıkış);
            this.gbxArama.Controls.Add(this.lblGiriş);
            this.gbxArama.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxArama.Location = new System.Drawing.Point(29, 99);
            this.gbxArama.Name = "gbxArama";
            this.gbxArama.Size = new System.Drawing.Size(328, 222);
            this.gbxArama.TabIndex = 13;
            this.gbxArama.TabStop = false;
            this.gbxArama.Text = "Özel  Havuzlu Kiralık Villalar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindMyBed.Properties.Resources.Adsız1;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pbxVilla
            // 
            this.pbxVilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxVilla.Location = new System.Drawing.Point(281, 34);
            this.pbxVilla.Name = "pbxVilla";
            this.pbxVilla.Size = new System.Drawing.Size(237, 227);
            this.pbxVilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVilla.TabIndex = 11;
            this.pbxVilla.TabStop = false;
            // 
            // FrmFindMyBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxArama);
            this.Controls.Add(this.gbxSonuç);
            this.Name = "FrmFindMyBed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Dream Villa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFindMyBed_FormClosed);
            this.Load += new System.EventHandler(this.FrmFindMyBed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVilla)).EndInit();
            this.gbxSonuç.ResumeLayout(false);
            this.gbxSonuç.PerformLayout();
            this.gbxArama.ResumeLayout(false);
            this.gbxArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBölge;
        private System.Windows.Forms.DateTimePicker dTimeGiriş;
        private System.Windows.Forms.DateTimePicker dTimeÇıkış;
        private System.Windows.Forms.Label lblGiriş;
        private System.Windows.Forms.Label lblÇıkış;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.PictureBox pbxVilla;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbxSonuç;
        private System.Windows.Forms.GroupBox gbxArama;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.ComboBox cbxBölge;
        public System.Windows.Forms.DataGridView dgwVilla;
        private System.Windows.Forms.Label lblÜcret;
        private System.Windows.Forms.TextBox tbxÜcret;
    }
}

