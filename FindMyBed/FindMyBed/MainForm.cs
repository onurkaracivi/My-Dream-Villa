using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyBed
{
    public partial class FrmFindMyBed : Form
    {
        public FrmFindMyBed()
        {
            InitializeComponent();
        }
        RezervasyonDal rezervasyonDal = new RezervasyonDal();
        int gün;
        decimal toplam;
        private void FrmFindMyBed_Load(object sender, EventArgs e)
        {
            cbxBölge.ValueMember = "BölgeAd";
            cbxBölge.DataSource = rezervasyonDal.GetBölge();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            int a = cbxBölge.SelectedIndex+1;
            DateTime giriş =dTimeGiriş.Value;
            DateTime çıkış = dTimeÇıkış.Value;

            TimeSpan span = çıkış - giriş;
            gün = (int)span.Days + 1;
            string sqlFormattedDate = giriş.ToString("yyyy-MM-dd");
            string sqlFormattedDate2 = çıkış.ToString("yyyy-MM-dd");
            dgwVilla.DataSource = rezervasyonDal.GetVillalar(sqlFormattedDate, sqlFormattedDate2,a);
            dgwVilla.Columns["VillaAd"].HeaderText = "Villa Adı";
            dgwVilla.Columns["BirimFiyat"].HeaderText = "Gecelik Ücret";
            dgwVilla.Columns["Id"].Visible = false;
            dgwVilla.Columns["BölgeId"].Visible = false;
            dgwVilla.Columns["ResimYolu"].Visible = false;
            pbxVilla.Image = null;
            gbxSonuç.Visible = true;
            tbxÜcret.Text = String.Empty;

        }

        private void DgwVilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string a =dgwVilla.CurrentRow.Cells[0].Value.ToString();
            pbxVilla.Load(rezervasyonDal.GetResimYolu(a));
            btnRezervasyon.Visible = true;
            decimal gecelik = Math.Round(Convert.ToDecimal(dgwVilla.CurrentRow.Cells["BirimFiyat"].Value.ToString()), 2);
            toplam = gün * gecelik;
            tbxÜcret.Text = toplam.ToString();
            lblÜcret.Visible = true;
            tbxÜcret.Visible = true;
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            RezervasyonForm form = new RezervasyonForm();
           
            form.tbxBölge.Text = cbxBölge.Text;
            form.tbxVillaAd.Text = dgwVilla.CurrentRow.Cells["VillaAd"].Value.ToString();
            form.tbxGiriş.Text = dTimeGiriş.Value.ToString().Substring(0,10);
            form.tbxÇıkış.Text = dTimeÇıkış.Value.ToString().Substring(0,10);
            form.tbxÜcret.Text = toplam.ToString();
            form.Show();
            this.Hide();
        }

        private void FrmFindMyBed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
