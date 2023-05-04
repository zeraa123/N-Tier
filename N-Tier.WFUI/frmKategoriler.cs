using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N_Tier.ORM.Facade;
using N_Tier.ORM.Entity;



namespace N_Tier.WFUI
{
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvKategoriListe_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text != "" && txtKategoriTanim.Text != "")
            {
              


            }
            else
            {
            }
        }

        private void dgvKategoriListe_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
          
        }
    }
}
