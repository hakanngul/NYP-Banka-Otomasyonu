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
    public partial class frm_BankaGiris : Form
    {
        public Banka banka;

        string kadi = "admin";
        string sifre = "12345";         
        public frm_BankaGiris(Banka banka)
        {
            this.banka = banka;
            InitializeComponent();            
        }        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (kadi==textBox1.Text && sifre ==textBox2.Text)
            {
                frm_BankaMain fr = new frm_BankaMain(banka);
                fr.Show();
                this.Hide();
            }
        }

        private void frm_BankaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
