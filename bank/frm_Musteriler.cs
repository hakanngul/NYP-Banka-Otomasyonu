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
    public partial class frm_Musteriler : Form
    {
        public Banka Banka;

        public frm_Musteriler(Banka Banka)
        {
            this.Banka = Banka;
            InitializeComponent();
        }

        private void frm_Musteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banka.Musteriler;
        }
    }
}
