namespace bank
{
    partial class frm_ParaCek
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
            this.txtParaCek = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHesap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtParaCek
            // 
            this.txtParaCek.Location = new System.Drawing.Point(215, 69);
            this.txtParaCek.Name = "txtParaCek";
            this.txtParaCek.Size = new System.Drawing.Size(120, 20);
            this.txtParaCek.TabIndex = 5;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(215, 95);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(120, 32);
            this.btnCek.TabIndex = 4;
            this.btnCek.Text = "Para Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "PARA ÇEKİLECEK TUTAR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "PARA İŞLEM İÇİN HESAP NO:";
            // 
            // txtHesap
            // 
            this.txtHesap.Location = new System.Drawing.Point(215, 27);
            this.txtHesap.Name = "txtHesap";
            this.txtHesap.Size = new System.Drawing.Size(120, 20);
            this.txtHesap.TabIndex = 8;
            // 
            // frm_ParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHesap);
            this.Controls.Add(this.txtParaCek);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.label1);
            this.Name = "frm_ParaCek";
            this.Text = "frm_ParaCek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParaCek;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHesap;
    }
}