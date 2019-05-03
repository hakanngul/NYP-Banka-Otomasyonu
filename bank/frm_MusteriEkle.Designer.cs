namespace bank
{
    partial class frm_MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MusteriEkle));
            this.rdTicari = new System.Windows.Forms.RadioButton();
            this.rdBireysel = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdTicari
            // 
            this.rdTicari.AutoSize = true;
            this.rdTicari.Location = new System.Drawing.Point(307, 225);
            this.rdTicari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTicari.Name = "rdTicari";
            this.rdTicari.Size = new System.Drawing.Size(64, 24);
            this.rdTicari.TabIndex = 24;
            this.rdTicari.TabStop = true;
            this.rdTicari.Text = "Ticari";
            this.rdTicari.UseVisualStyleBackColor = true;
            // 
            // rdBireysel
            // 
            this.rdBireysel.AutoSize = true;
            this.rdBireysel.Location = new System.Drawing.Point(175, 225);
            this.rdBireysel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBireysel.Name = "rdBireysel";
            this.rdBireysel.Size = new System.Drawing.Size(82, 24);
            this.rdBireysel.TabIndex = 23;
            this.rdBireysel.TabStop = true;
            this.rdBireysel.Text = "Bireysel";
            this.rdBireysel.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(175, 271);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(228, 52);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(96, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müşteri TC :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(175, 154);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(226, 26);
            this.txtSoyad.TabIndex = 22;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 102);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(226, 26);
            this.txtAd.TabIndex = 21;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(175, 43);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(226, 26);
            this.txtTc.TabIndex = 16;
            // 
            // frm_MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 345);
            this.Controls.Add(this.rdTicari);
            this.Controls.Add(this.rdBireysel);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdTicari;
        private System.Windows.Forms.RadioButton rdBireysel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTc;
    }
}