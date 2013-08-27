namespace Comel
{
    partial class frmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledaRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladišteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.skladišteToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "Main menu";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.zatvoriToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.loginToolStripMenuItem.Text = "Prijava";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.logoutToolStripMenuItem.Text = "Odjava";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviRačunToolStripMenuItem,
            this.pregledaRačunaToolStripMenuItem});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            this.računiToolStripMenuItem.Visible = false;
            // 
            // noviRačunToolStripMenuItem
            // 
            this.noviRačunToolStripMenuItem.Name = "noviRačunToolStripMenuItem";
            this.noviRačunToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.noviRačunToolStripMenuItem.Text = "Novi račun";
            this.noviRačunToolStripMenuItem.Click += new System.EventHandler(this.noviRačunToolStripMenuItem_Click);
            // 
            // pregledaRačunaToolStripMenuItem
            // 
            this.pregledaRačunaToolStripMenuItem.Name = "pregledaRačunaToolStripMenuItem";
            this.pregledaRačunaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pregledaRačunaToolStripMenuItem.Text = "Pregled računa";
            this.pregledaRačunaToolStripMenuItem.Click += new System.EventHandler(this.pregledaRačunaToolStripMenuItem_Click);
            // 
            // skladišteToolStripMenuItem
            // 
            this.skladišteToolStripMenuItem.Name = "skladišteToolStripMenuItem";
            this.skladišteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.skladišteToolStripMenuItem.Text = "Skladište";
            this.skladišteToolStripMenuItem.Visible = false;
            this.skladišteToolStripMenuItem.Click += new System.EventHandler(this.skladišteToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 750);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skladišteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledaRačunaToolStripMenuItem;
    }
}

