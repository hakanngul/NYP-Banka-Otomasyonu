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
    public partial class frm_ParaYatir : Form
    {
        public Banka banka;
        public frm_ParaYatir(Banka Banka)
        {
            banka = Banka;
            InitializeComponent();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in banka.Musteriler)
            {
                foreach (var x in item.Hesaplar)
                {
                    if (x.HesapNo == (txtHesap.Text))
                    {
                        x.HesapBakiyesi += Convert.ToInt32(txtParaYatir.Text);
                        MessageBox.Show("İşlem Başarıyla Gerçekleştirilmiştir");
                        break;
                    }

                }
            }
        }
    }
}
