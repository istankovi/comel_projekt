namespace Comel
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblKori = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comel_dbDataSet = new Comel.comel_dbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Comel.comel_dbDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(67, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(54, 36);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(54, 77);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(81, 61);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(47, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Lozinka:";
            // 
            // lblKori
            // 
            this.lblKori.AutoSize = true;
            this.lblKori.Location = new System.Drawing.Point(64, 20);
            this.lblKori.Name = "lblKori";
            this.lblKori.Size = new System.Drawing.Size(78, 13);
            this.lblKori.TabIndex = 4;
            this.lblKori.Text = "Korisničko ime:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(57, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Neuspješna prijava";
            this.lblStatus.Visible = false;
            // 
            // comel_dbDataSet
            // 
            this.comel_dbDataSet.DataSetName = "comel_dbDataSet";
            this.comel_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblKori);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblKori;
        private System.Windows.Forms.Label lblStatus;
        private comel_dbDataSet comel_dbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private comel_dbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
    }
}