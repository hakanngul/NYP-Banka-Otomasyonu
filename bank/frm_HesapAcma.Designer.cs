namespace bank
{
    partial class frm_HesapAcma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HesapAcma));
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.txtHesapAcilisTarihi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(163, 65);
            this.txtTCKimlik.MaxLength = 11;
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(142, 26);
            this.txtTCKimlik.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No :";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Location = new System.Drawing.Point(163, 144);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(142, 30);
            this.btnHesapAc.TabIndex = 2;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtHesapAcilisTarihi
            // 
            this.txtHesapAcilisTarihi.Enabled = false;
            this.txtHesapAcilisTarihi.Location = new System.Drawing.Point(163, 101);
            this.txtHesapAcilisTarihi.Name = "txtHesapAcilisTarihi";
            this.txtHesapAcilisTarihi.Size = new System.Drawing.Size(142, 26);
            this.txtHesapAcilisTarihi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hesap Açılış Tarihi :";
            // 
            // frm_HesapAcma
            // 
            this.ClientSize = new System.Drawing.Size(362, 203);
            this.Controls.Add(this.txtHesapAcilisTarihi);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTCKimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HesapAcma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HESAP AÇ";
            this.Load += new System.EventHandler(this.HesapAcma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox txtTCKimlik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.TextBox txtHesapAcilisTarihi;
        private System.Windows.Forms.Label label1;
    }
}