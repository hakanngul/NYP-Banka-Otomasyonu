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
    public partial class frm_ParaCek : Form
    {
        public Banka banka;
        public frm_ParaCek(Banka banka)
        {
            this.banka = banka;
            InitializeComponent();
        }
        DialogResult islem = new DialogResult();

        private void btnCek_Click(object sender, EventArgs e)
        {
            int cek = Convert.ToInt32(txtParaCek.Text);
            foreach (var item in banka.Musteriler)
            {
                foreach (var x in item.Hesaplar)
                {
                    if (x.HesapNo == txtHesap.Text)
                    {
                        if (cek <= x.gunlukParaLimiti)
                        {
                            if (x.HesapBakiyesi > cek)
                            {
                                x.HesapBakiyesi -= cek;
                                x.gunlukParaLimiti -= cek;
                                MessageBox.Show("İşlem Başarıyla Gerçekleştirilmiştir");
                                break;
                            }
                            else if (x.HesapBakiyesi < cek)
                            {
                                islem = MessageBox.Show("Hesabınızda Yeterli Para bulunmuyor Ek Hesaptan Çekilmesini ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                                if (islem == DialogResult.Yes)
                                {                                    
                                    int azaltılcak = cek - x.HesapBakiyesi;
                                    x.gunlukParaLimiti -= cek;
                                    x.EkHesap -= azaltılcak;
                                    x.HesapBakiyesi = 0;
                                }
                                else if (islem == DialogResult.No)
                                {
                                    break;
                                }

                            }
                        }
                        else if (cek > x.gunlukParaLimiti)
                        {
                            MessageBox.Show("Günlük Para Çekme Limitizi Aştınız");
                        }
                    }
                }
            }
        }
    }
}
