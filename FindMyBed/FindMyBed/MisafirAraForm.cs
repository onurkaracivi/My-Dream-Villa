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
    public partial class MisafirAraForm : Form
    {
        public MisafirAraForm()
        {
            InitializeComponent();
        }

        private void LoadMisafir()
        {
            dgwMisafir.DataSource = rezervasyonDal.GetMisafir();
        }
        private void SearchMisafir(string key)
        {
            dgwMisafir.DataSource = rezervasyonDal.GetMisafir().Where(p=> p.KimlikId.Contains(key)).ToList();
        }
        RezervasyonDal rezervasyonDal = new RezervasyonDal();
        private void MisafirAraForm_Load(object sender, EventArgs e)
        {
            LoadMisafir();
            dgwMisafir.Columns["Id"].Visible = false;
            dgwMisafir.Columns["Email"].Visible = false;
            dgwMisafir.Columns["KimlikId"].HeaderText = "Kimlik No";
        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchMisafir(tbxSearch.Text);
        }

        private void BtnKişiSeç_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbxSearch_TextChanged_1(object sender, EventArgs e)
        {
            SearchMisafir(tbxSearch.Text);
        }
    }
}
