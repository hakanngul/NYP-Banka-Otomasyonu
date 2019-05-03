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
    public partial class frm_MusteriEkle : Form
    {
        public Banka musteriBanka;
        
        public frm_MusteriEkle(Banka Banka)
        {
            musteriBanka = Banka;
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if(txtTc.Text.Length<11)
            {
                MessageBox.Show("Lütfen TC Kimlik numaranızı 11 haneli olarak giriniz.");
            }
          else  if (rdTicari.Checked == true)
            {
                TicariMusteri ticari = new TicariMusteri(musteriBanka);
                ticari.TCKimlik = Convert.ToInt64(txtTc.Text);
                ticari.Adi = txtAd.Text;
                ticari.Soyadi = txtSoyad.Text;
                ticari.Tur = rdTicari.Text;
                musteriBanka.MusteriEkle(ticari);
                MessageBox.Show("Ticari Müşteri Eklendi");

            }
            else if (rdBireysel.Checked == true)
            {
                BireyselMusteri bireysel = new BireyselMusteri(musteriBanka);
                bireysel.TCKimlik = Convert.ToInt64(txtTc.Text);
                bireysel.Adi = txtAd.Text;
                bireysel.Soyadi = txtSoyad.Text;
                bireysel.Tur = rdBireysel.Text;
                musteriBanka.MusteriEkle(bireysel);
                MessageBox.Show("Bireysel Müşteri Eklendi");
            }
            else
                MessageBox.Show("Lütfen Müşteri Türünü Seçiniz");
        }
    }
}
