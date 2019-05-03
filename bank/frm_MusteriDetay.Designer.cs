namespace bank
{
    partial class frm_MusteriDetay
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paraİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKapatmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem,
            this.paraİşlemleriToolStripMenuItem,
            this.havaleİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paraİşlemleriToolStripMenuItem
            // 
            this.paraİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraEkleToolStripMenuItem,
            this.paraÇekToolStripMenuItem});
            this.paraİşlemleriToolStripMenuItem.Name = "paraİşlemleriToolStripMenuItem";
            this.paraİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paraİşlemleriToolStripMenuItem.Text = "Para İşlemleri";
            // 
            // paraEkleToolStripMenuItem
            // 
            this.paraEkleToolStripMenuItem.Name = "paraEkleToolStripMenuItem";
            this.paraEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paraEkleToolStripMenuItem.Text = "Para Ekle";
            // 
            // paraÇekToolStripMenuItem
            // 
            this.paraÇekToolStripMenuItem.Name = "paraÇekToolStripMenuItem";
            this.paraÇekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paraÇekToolStripMenuItem.Text = "Para Çek";
            // 
            // havaleİşlemleriToolStripMenuItem
            // 
            this.havaleİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.havaleYapToolStripMenuItem});
            this.havaleİşlemleriToolStripMenuItem.Name = "havaleİşlemleriToolStripMenuItem";
            this.havaleİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.havaleİşlemleriToolStripMenuItem.Text = "Havale İşlemleri";
            // 
            // havaleYapToolStripMenuItem
            // 
            this.havaleYapToolStripMenuItem.Name = "havaleYapToolStripMenuItem";
            this.havaleYapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.havaleYapToolStripMenuItem.Text = "Havale Yap";
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapAçmaToolStripMenuItem,
            this.hesapKapatmaToolStripMenuItem});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // hesapAçmaToolStripMenuItem
            // 
            this.hesapAçmaToolStripMenuItem.Name = "hesapAçmaToolStripMenuItem";
            this.hesapAçmaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapAçmaToolStripMenuItem.Text = "Hesap Açma";
            this.hesapAçmaToolStripMenuItem.Click += new System.EventHandler(this.hesapAçmaToolStripMenuItem_Click);
            // 
            // hesapKapatmaToolStripMenuItem
            // 
            this.hesapKapatmaToolStripMenuItem.Name = "hesapKapatmaToolStripMenuItem";
            this.hesapKapatmaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapKapatmaToolStripMenuItem.Text = "Hesap Kapatma";
            // 
            // frm_MusteriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 383);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MusteriDetay";
            this.Text = "frm_MusteriDetay";
            this.Load += new System.EventHandler(this.frm_MusteriDetay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paraİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapAçmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKapatmaToolStripMenuItem;
    }
}