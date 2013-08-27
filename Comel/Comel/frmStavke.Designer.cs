namespace Comel
{
    partial class frmStavke
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comel_dbDataSet = new Comel.comel_dbDataSet();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new Comel.comel_dbDataSetTableAdapters.categoryTableAdapter();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Comel.comel_dbDataSetTableAdapters.itemsTableAdapter();
            this.tableAdapterManager = new Comel.comel_dbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategorija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Količina:";
            // 
            // txtKat
            // 
            this.txtKat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "id_kat", true));
            this.txtKat.DataSource = this.categoryBindingSource;
            this.txtKat.DisplayMember = "ime_kat";
            this.txtKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKat.FormattingEnabled = true;
            this.txtKat.Location = new System.Drawing.Point(75, 6);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(197, 21);
            this.txtKat.TabIndex = 5;
            this.txtKat.ValueMember = "id_kat";
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
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(75, 27);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(197, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(75, 48);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(197, 69);
            this.txtOpis.TabIndex = 7;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(75, 123);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(83, 20);
            this.txtCijena.TabIndex = 8;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(75, 144);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(32, 20);
            this.txtKolicina.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kuna";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(60, 174);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(156, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.itemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Comel.comel_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // frmStavke
            // 
            this.AcceptButton = this.btnDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(296, 213);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStavke";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj stavku";
            this.Load += new System.EventHandler(this.frmStavke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtKat;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnCancel;
        private comel_dbDataSet comel_dbDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private comel_dbDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private comel_dbDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private comel_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}