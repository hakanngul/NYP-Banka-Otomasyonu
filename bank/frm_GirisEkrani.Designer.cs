namespace bank
{
    partial class frm_GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GirisEkrani));
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBankaGirisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGirisi.Location = new System.Drawing.Point(12, 180);
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.Size = new System.Drawing.Size(164, 60);
            this.btnMusteriGirisi.TabIndex = 0;
            this.btnMusteriGirisi.Text = "Müşteri Girişi";
            this.btnMusteriGirisi.UseVisualStyleBackColor = true;
            this.btnMusteriGirisi.Click += new System.EventHandler(this.btnMusteriGirisi_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bank.Properties.Resources.personel;
            this.pictureBox2.Location = new System.Drawing.Point(205, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bank.Properties.Resources.bireysel;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBankaGirisi
            // 
            this.btnBankaGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaGirisi.Location = new System.Drawing.Point(205, 180);
            this.btnBankaGirisi.Name = "btnBankaGirisi";
            this.btnBankaGirisi.Size = new System.Drawing.Size(164, 60);
            this.btnBankaGirisi.TabIndex = 3;
            this.btnBankaGirisi.Text = "Banka Girişi";
            this.btnBankaGirisi.UseVisualStyleBackColor = true;
            this.btnBankaGirisi.Click += new System.EventHandler(this.btnBankaGirisi_Click);
            // 
            // frm_GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.btnBankaGirisi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMusteriGirisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ EKRANI";
            this.Load += new System.EventHandler(this.frm_GirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriGirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBankaGirisi;
    }
}