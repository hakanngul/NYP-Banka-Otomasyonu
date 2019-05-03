using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace bank
{
    public partial class frm_MusteriDetay : Form
    {
        public Banka musteriBanka;
        public frm_MusteriDetay()
        {
            InitializeComponent();
           //this.musteriBanka = Banka;
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

        private void HesapAcma_FormClosed(object sender, FormClosedEventArgs e)
        {
            HesapAcma = null;
        }
    }
}
