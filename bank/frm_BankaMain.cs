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
    public partial class frm_BankaMain : Form
    {
       
        public Banka mainBank;
        public frm_BankaMain(Banka bank)
        {
            InitializeComponent();
            mainBank = bank;
        }      
        private void frm_BankaMain_Load(object sender, EventArgs e)
        {
        }      
        //Müşteri Ekleme Formu
        frm_MusteriEkle musteriEkle;
        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musteriEkle == null)
            {
                musteriEkle = new frm_MusteriEkle(mainBank);
                musteriEkle.MdiParent = this;
                musteriEkle.FormClosed += MusteriEkle_FormClosed;
                musteriEkle.Show();
            }
            else
                musteriEkle.Activate();
        }

       //Müşteri Listeleme Formu
        frm_Musteriler musteri;
        private void müşteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (musteri==null)
            {
                musteri = new frm_Musteriler(mainBank);
                musteri.MdiParent = this;
                musteri.FormClosed += Mus_FormClosed;
                musteri.Show();
            }
            else
                musteri.Activate();
        }
      
        

        //FormClosed'ların Bulunduğu Kısım      
        
        private void MusteriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            musteriEkle = null;
        }
        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GirisEkrani fr = new frm_GirisEkrani(mainBank);
            fr.Show();
            this.Hide();
        }

        private void Mus_FormClosed(object sender, FormClosedEventArgs e)
        {
            musteri = null;
        }

        private void müşteriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

       


        private void HesapAcmaFormu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
