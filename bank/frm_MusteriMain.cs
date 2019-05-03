using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace bank
{
    public partial class frm_MusteriMain : Form
    {
        public Banka musteriBanka;
        public frm_MusteriMain(Banka musteriBanka)
        {
            InitializeComponent();
            this.musteriBanka = musteriBanka;
        }
        private void frm_MusteriDetay_Load(object sender, EventArgs e)
        {
        }
        //Hesap Açma Formu
        frm_HesapAcma HesapAcma;
        private void hesapAçmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HesapAcma == null)
            {
                HesapAcma = new frm_HesapAcma(musteriBanka);
                HesapAcma.MdiParent = this;
                HesapAcma.FormClosed += HesapAcma_FormClosed;
                HesapAcma.Show();
            }
        }
        frm_HesapListele hesapList;
        private void hesaplarıListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hesapList == null)
            {
                hesapList = new frm_HesapListele(musteriBanka);
                hesapList.MdiParent = this;
                hesapList.FormClosed += HesapList_FormClosed;
                hesapList.Show();
            }
            else
                hesapList.Activate();
        }
        frm_HesapKapatma hesapKapatma;
        private void hesapKapatmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hesapKapatma == null)
            {
                hesapKapatma = new frm_HesapKapatma(musteriBanka);
                hesapKapatma.MdiParent = this;
                hesapKapatma.FormClosed += HesapKapatma_FormClosed;
                hesapKapatma.Show();
            }
            else
                hesapList.Activate();
        }
        frm_ParaYatir paraYatir;
        private void paraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (paraYatir == null)
            {
                paraYatir = new frm_ParaYatir(musteriBanka);
                paraYatir.MdiParent = this;
                paraYatir.FormClosed += ParaYatir_FormClosed;
                paraYatir.Show();
            }
            else
                paraYatir.Activate();
        }
        frm_ParaCek paraCek;
        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (paraCek == null)
            {
                paraCek = new frm_ParaCek(musteriBanka);
                paraCek.MdiParent = this;
                paraCek.FormClosed += ParaCek_FormClosed;
                paraCek.Show();
            }
            else
                paraCek.Activate();
        }

        frm_Havale havale;

        private void havaleYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (havale == null)
            {
                havale = new frm_Havale(musteriBanka);
                havale.MdiParent = this;
                havale.FormClosed += Havale_FormClosed;
                havale.Show();
            }
            else
                havale.Activate();
        }
        //FormClosed'ların Bulunduğu Kısım
        private void Havale_FormClosed(object sender, FormClosedEventArgs e)
        {
            havale = null;
        }       
        private void ParaCek_FormClosed(object sender, FormClosedEventArgs e)
        {
            paraCek = null;
        }

        private void ParaYatir_FormClosed(object sender, FormClosedEventArgs e)
        {
            paraYatir = null;
        }
        private void HesapKapatma_FormClosed(object sender, FormClosedEventArgs e)
        {
            hesapKapatma = null;
        }
        private void HesapList_FormClosed(object sender, FormClosedEventArgs e)
        {
            hesapList = null;
        }

        private void HesapAcma_FormClosed(object sender, FormClosedEventArgs e)
        {
            HesapAcma = null;
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
