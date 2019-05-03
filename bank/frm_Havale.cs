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
    public partial class frm_Havale : Form
    {
        public Banka banka;
        public frm_Havale(Banka banka)
        {
            this.banka = banka;
            InitializeComponent();
        }
        public decimal GonderHesap, GelenHesap;
        long GelenTC, GonderenTC;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            decimal tutar = Convert.ToDecimal(txtTutar.Text);
            int sayac = 0;
            foreach (var item in banka.Musteriler)
            {
                foreach (var x in item.Hesaplar)
                {

                    if (x.HesapNo == txtGonderenHesap.Text)
                    {
                        sayac += 1;
                        GonderenTC = item.TCKimlik;
                    }
                    else if (x.HesapNo == txtParaGelenHesapNo.Text)
                    {
                        sayac += 1;
                        GelenTC = item.TCKimlik;
                    }
                }
                if (GelenTC == GonderenTC && sayac == 2)
                {
                    foreach (var a in item.Hesaplar)
                    {
                        if (a.HesapNo == txtGonderenHesap.Text)
                        {
                            a.HesapBakiyesi -= Convert.ToInt32(txtTutar.Text);
                        }
                        else if (a.HesapNo == txtParaGelenHesapNo.Text)
                        {
                            a.HesapBakiyesi += Convert.ToInt32(txtTutar.Text);
                        }
                        MessageBox.Show("GelenTC == GonderenTC && sayac==2 mbox'ı");
                    }
                    sayac = 3;
                }
            }
            if (sayac == 2 && GonderenTC != GelenTC)
            {
                foreach (var item2 in banka.Musteriler)
                {
                    foreach (var a in item2.Hesaplar)
                    {
                        if (a.HesapNo == txtGonderenHesap.Text)
                        {
                            a.HesapBakiyesi -= Convert.ToInt32(txtTutar.Text);
                        }
                        else if (a.HesapNo == txtParaGelenHesapNo.Text)
                        {
                            a.HesapBakiyesi += Convert.ToInt32(txtTutar.Text);
                        }
                        MessageBox.Show("sayac==2 && GonderenTC != GelenTC mbox'ı");
                        break;
                    }
                }
            }


        }
        private void txtGonderenHesap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParaGelenHesapNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Havale_Load(object sender, EventArgs e)
        {

        }
    }
}
