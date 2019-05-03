using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class frm_GirisEkrani : Form
    {
        public Banka bank;
        public frm_GirisEkrani(Banka bank)
        {
            this.bank = bank;
            InitializeComponent();
        }      

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            frm_MusteriGirisi fr = new frm_MusteriGirisi(bank);
            fr.Show();
            this.Hide();
        }

        private void btnBankaGirisi_Click(object sender, EventArgs e)
        {
            frm_BankaGiris fr = new frm_BankaGiris(bank);
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
