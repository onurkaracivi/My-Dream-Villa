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
    public partial class RezervasyonForm : Form
    {
        public RezervasyonForm()
        {
            InitializeComponent();
        }
        RezervasyonDal rezervasyonDal = new RezervasyonDal();
        MisafirAraForm kişiAraForm = new MisafirAraForm();
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FrmFindMyBed form = new FrmFindMyBed();
            form.Show();
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (tbxKimlik.ReadOnly)
            {
                rezervasyonDal.Add(new Rezervasyon
                {
                    GirişTarihi = Convert.ToDateTime(tbxGiriş.Text),
                    ÇıkışTarihi = Convert.ToDateTime(tbxÇıkış.Text),
                    BölgeId = Convert.ToInt32(rezervasyonDal.GetBölgeId(tbxBölge.Text)),
                    Ücret = Convert.ToDecimal(tbxÜcret.Text),
                    VillaId = Convert.ToInt32(rezervasyonDal.GetVillaId(tbxVillaAd.Text)),
                    MisafirId = Convert.ToInt32(kişiAraForm.dgwMisafir.CurrentRow.Cells["Id"].Value),

                });
                rezervasyonDal.Add(new OtelRezervasyon
                {
                    VillaId = Convert.ToInt32(rezervasyonDal.GetVillaId(tbxVillaAd.Text)),
                    RezervasyonId = Convert.ToInt32(rezervasyonDal.GetRezervasyonId()),
                    GirişT = Convert.ToDateTime(tbxGiriş.Text),
                    ÇıkışT = Convert.ToDateTime(tbxÇıkış.Text),
                });
            }
            else
            {
                rezervasyonDal.Add(new Misafir
                {
                    Ad = tbxAd.Text,
                    Soyad = tbxSoyad.Text,
                    KimlikId = tbxKimlik.Text,
                    Telefon = tbxTelefon.Text,
                    Email = tbxEposta.Text,
                });
                rezervasyonDal.Add(new Rezervasyon
                {
                    GirişTarihi = Convert.ToDateTime(tbxGiriş.Text),
                    ÇıkışTarihi = Convert.ToDateTime(tbxÇıkış.Text),
                    BölgeId = Convert.ToInt32(rezervasyonDal.GetBölgeId(tbxBölge.Text)),
                    Ücret = Convert.ToDecimal(tbxÜcret.Text),
                    VillaId = Convert.ToInt32(rezervasyonDal.GetVillaId(tbxVillaAd.Text)),
                    MisafirId = Convert.ToInt32(rezervasyonDal.GetMisafirId()),

                });
                rezervasyonDal.Add(new OtelRezervasyon
                {
                    VillaId = Convert.ToInt32(rezervasyonDal.GetVillaId(tbxVillaAd.Text)),
                    RezervasyonId = Convert.ToInt32(rezervasyonDal.GetRezervasyonId()),
                    GirişT = Convert.ToDateTime(tbxGiriş.Text),
                    ÇıkışT = Convert.ToDateTime(tbxÇıkış.Text),
                });
            }
        }

        private void BtnKişiAra_Click(object sender, EventArgs e)
        {

            if (kişiAraForm.ShowDialog() == DialogResult.OK)
            {
                tbxAd.Text = kişiAraForm.dgwMisafir.CurrentRow.Cells["Ad"].Value.ToString();
                tbxSoyad.Text = kişiAraForm.dgwMisafir.CurrentRow.Cells["Soyad"].Value.ToString();
                tbxKimlik.Text = kişiAraForm.dgwMisafir.CurrentRow.Cells["KimlikId"].Value.ToString();
                tbxTelefon.Text = kişiAraForm.dgwMisafir.CurrentRow.Cells["Telefon"].Value.ToString();
                tbxEposta.Text = kişiAraForm.dgwMisafir.CurrentRow.Cells["Email"].Value.ToString();
                tbxAd.ReadOnly = true;
                tbxSoyad.ReadOnly = true;
                tbxKimlik.ReadOnly = true;
            }

        }
    }
}
