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
    public partial class frm_HesapAcma : Form
    {
        public Banka banka;
       
        public frm_HesapAcma(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }
        private void button2_Click(object sender, EventArgs e)
        {           
            foreach (var a in banka.Musteriler)
            {
                if (a.TCKimlik== Convert.ToInt64(txtTCKimlik.Text))
                {
                    Hesap hesap = new Hesap();
                    a.HesapAcma(hesap);
                    MessageBox.Show("Hesabınız Eklenmiştir");
                }
            }
        }
        private void HesapAcma_Load(object sender, EventArgs e)
        {
            txtHesapAcilisTarihi.Text=DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
