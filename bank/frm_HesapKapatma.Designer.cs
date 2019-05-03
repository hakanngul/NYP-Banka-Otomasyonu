namespace bank
{
    partial class frm_HesapKapatma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HesapKapatma));
            this.txtHesap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHesap
            // 
            this.txtHesap.Location = new System.Drawing.Point(120, 55);
            this.txtHesap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHesap.Name = "txtHesap";
            this.txtHesap.Size = new System.Drawing.Size(199, 26);
            this.txtHesap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "HESAP NO :";
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.Location = new System.Drawing.Point(120, 103);
            this.btnHesapKapat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(199, 51);
            this.btnHesapKapat.TabIndex = 3;
            this.btnHesapKapat.Text = "Hesap Kapat";
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_HesapKapatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 196);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHesap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HesapKapatma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HESAP KAPATMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapKapat;
    }
}