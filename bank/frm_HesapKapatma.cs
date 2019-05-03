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
    public partial class frm_HesapKapatma : Form
    {
        Banka banka;
        public frm_HesapKapatma(Banka banka)
        {
            this.banka=banka;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in banka.Musteriler)
            {
                foreach (var x in item.Hesaplar)
                {

                    if (x.HesapNo == (txtHesap.Text))
                    {
                        if (x.HesapBakiyesi == 0)
                        {
                            item.HesapKapatma(x);
                            MessageBox.Show("Hesabınız Silimiştir");
                            break;
                        }

                        else MessageBox.Show("Hesap Bakiyeniz 0 olmadığından silinemedi");
                    }

                }
            }
        }
    }
}
