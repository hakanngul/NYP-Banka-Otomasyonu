using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace bank
{
    public partial class frm_MusteriGirisi : Form
    {
        public Banka banka;
        
        public frm_MusteriGirisi(Banka banka)
        {
            this.banka = banka;
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            foreach (var item in banka.Musteriler )
            {
                if (item.TCKimlik==Convert.ToInt64(txtKimlik.Text))
                {
                    frm_MusteriMain fr = new frm_MusteriMain(banka);
                    fr.Show();
                    this.Hide();
                }
            }
        }
    }
}
