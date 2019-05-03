namespace bank
{
    partial class frm_Havale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Havale));
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtGonderenHesap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParaGelenHesapNo = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(252, 202);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(148, 35);
            this.btnGonder.TabIndex = 0;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtGonderenHesap
            // 
            this.txtGonderenHesap.Location = new System.Drawing.Point(252, 55);
            this.txtGonderenHesap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGonderenHesap.Name = "txtGonderenHesap";
            this.txtGonderenHesap.Size = new System.Drawing.Size(148, 26);
            this.txtGonderenHesap.TabIndex = 1;
            this.txtGonderenHesap.TextChanged += new System.EventHandler(this.txtGonderenHesap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para Gönderen Hesap No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para Gelecek Hesap No :";
            // 
            // txtParaGelenHesapNo
            // 
            this.txtParaGelenHesapNo.Location = new System.Drawing.Point(252, 105);
            this.txtParaGelenHesapNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParaGelenHesapNo.Name = "txtParaGelenHesapNo";
            this.txtParaGelenHesapNo.Size = new System.Drawing.Size(148, 26);
            this.txtParaGelenHesapNo.TabIndex = 3;
            this.txtParaGelenHesapNo.TextChanged += new System.EventHandler(this.txtParaGelenHesapNo_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(252, 150);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(148, 26);
            this.txtTutar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "TUTAR :";
            // 
            // frm_Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 251);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParaGelenHesapNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGonderenHesap);
            this.Controls.Add(this.btnGonder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Havale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HAVALE";
            this.Load += new System.EventHandler(this.frm_Havale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtGonderenHesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParaGelenHesapNo;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label3;
    }
}