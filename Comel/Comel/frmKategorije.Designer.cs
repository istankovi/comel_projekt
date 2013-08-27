namespace Comel
{
    partial class frmKategorije
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comel_dbDataSet = new Comel.comel_dbDataSet();
            this.categoryTableAdapter = new Comel.comel_dbDataSetTableAdapters.categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(84, 22);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(113, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(86, 61);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(111, 20);
            this.txtOpis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naziv nove kategorije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Opis nove kategorije:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(100, 86);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // comel_dbDataSet
            // 
            this.comel_dbDataSet.DataSetName = "comel_dbDataSet";
            this.comel_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // frmKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 131);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKategorije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.frmKategorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private comel_dbDataSet comel_dbDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private comel_dbDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
    }
}