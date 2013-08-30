namespace Comel
{
    partial class frmSkladiste
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.iditemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comel_dbDataSet = new Comel.comel_dbDataSet();
            this.itemsTableAdapter = new Comel.comel_dbDataSetTableAdapters.itemsTableAdapter();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Comel.comel_dbDataSetTableAdapters.categoryTableAdapter();
            this.lblKat = new System.Windows.Forms.Label();
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodajNovuKategoriju = new System.Windows.Forms.Button();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iditemDataGridViewTextBoxColumn,
            this.nameitemDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.cijenaitemDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvItems.DataSource = this.itemsBindingSource;
            this.dgvItems.Location = new System.Drawing.Point(15, 37);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(759, 286);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            // 
            // iditemDataGridViewTextBoxColumn
            // 
            this.iditemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iditemDataGridViewTextBoxColumn.DataPropertyName = "id_item";
            this.iditemDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iditemDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iditemDataGridViewTextBoxColumn.Name = "iditemDataGridViewTextBoxColumn";
            this.iditemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameitemDataGridViewTextBoxColumn
            // 
            this.nameitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameitemDataGridViewTextBoxColumn.DataPropertyName = "name_item";
            this.nameitemDataGridViewTextBoxColumn.HeaderText = "Stavka";
            this.nameitemDataGridViewTextBoxColumn.Name = "nameitemDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // cijenaitemDataGridViewTextBoxColumn
            // 
            this.cijenaitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijenaitemDataGridViewTextBoxColumn.DataPropertyName = "cijena_item";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.cijenaitemDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cijenaitemDataGridViewTextBoxColumn.FillWeight = 80F;
            this.cijenaitemDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaitemDataGridViewTextBoxColumn.Name = "cijenaitemDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.FillWeight = 80F;
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // comel_dbDataSet
            // 
            this.comel_dbDataSet.DataSetName = "comel_dbDataSet";
            this.comel_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Location = new System.Drawing.Point(12, 9);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(57, 13);
            this.lblKat.TabIndex = 1;
            this.lblKat.Text = "Kategorija:";
            // 
            // cmbKat
            // 
            this.cmbKat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "id_kat", true));
            this.cmbKat.DataSource = this.categoryBindingSource;
            this.cmbKat.DisplayMember = "ime_kat";
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.Location = new System.Drawing.Point(75, 6);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(283, 21);
            this.cmbKat.TabIndex = 2;
            this.cmbKat.ValueMember = "id_kat";
            this.cmbKat.SelectionChangeCommitted += new System.EventHandler(this.cmbKat_SelectionChangeCommitted);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(12, 329);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(90, 23);
            this.btnDodajStavku.TabIndex = 4;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(711, 327);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(63, 23);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Dodaj količinu na odabrano:";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodajNovuKategoriju
            // 
            this.btnDodajNovuKategoriju.Location = new System.Drawing.Point(365, 6);
            this.btnDodajNovuKategoriju.Name = "btnDodajNovuKategoriju";
            this.btnDodajNovuKategoriju.Size = new System.Drawing.Size(101, 23);
            this.btnDodajNovuKategoriju.TabIndex = 7;
            this.btnDodajNovuKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajNovuKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajNovuKategoriju.Click += new System.EventHandler(this.btnDodajNovuKategoriju_Click);
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(470, 6);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(108, 23);
            this.btnObrisiKategoriju.TabIndex = 8;
            this.btnObrisiKategoriju.Text = "Obriši kategoriju";
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dodaj količinu na odabrano:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(659, 329);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(46, 20);
            this.txtKolicina.TabIndex = 10;
            this.txtKolicina.Text = "0";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(308, 329);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(158, 23);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši odabranu stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiKategoriju);
            this.Controls.Add(this.btnDodajNovuKategoriju);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.cmbKat);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.dgvItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSkladiste";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladište";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSkladiste_FormClosing);
            this.Load += new System.EventHandler(this.frmSkladiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private comel_dbDataSet comel_dbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private comel_dbDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private comel_dbDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.DataGridViewTextBoxColumn iditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodajNovuKategoriju;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnObrisi;
    }
}