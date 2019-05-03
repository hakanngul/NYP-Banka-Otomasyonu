namespace bank
{
    partial class frm_BankaMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BankaMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.bilgiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Image = global::bank.Properties.Resources.if_exit_3226;
            this.bilgiToolStripMenuItem.MergeIndex = 0;
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.bilgiToolStripMenuItem.Text = "Çıkış";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.bilgiToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriToolStripMenuItem1});
            this.müşteriToolStripMenuItem.Image = global::bank.Properties.Resources.Client_list_text_document_user;
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Image = global::bank.Properties.Resources.create_user_man_male_512;
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem1
            // 
            this.müşteriToolStripMenuItem1.Image = global::bank.Properties.Resources.Customers_customer_user_male_man_people_light;
            this.müşteriToolStripMenuItem1.Name = "müşteriToolStripMenuItem1";
            this.müşteriToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.müşteriToolStripMenuItem1.Text = "Müşteri Listele";
            this.müşteriToolStripMenuItem1.Click += new System.EventHandler(this.müşteriToolStripMenuItem1_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Image = global::bank.Properties.Resources.if_Clipboard_tasks_report_business_checking_verification_list_1886797;
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // frm_BankaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_BankaMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKA MAİN";
            this.Load += new System.EventHandler(this.frm_BankaMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
    }
}