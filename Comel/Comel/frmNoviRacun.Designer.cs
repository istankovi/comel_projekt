namespace Comel
{
    partial class frmNoviRacun
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.txtStavka = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comel_dbDataSet = new Comel.comel_dbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.itemsTableAdapter = new Comel.comel_dbDataSetTableAdapters.itemsTableAdapter();
            this.txtRacun = new System.Windows.Forms.TextBox();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblUkupnoCijena = new System.Windows.Forms.Label();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new Comel.comel_dbDataSetTableAdapters.racunTableAdapter();
            this.tableAdapterManager = new Comel.comel_dbDataSetTableAdapters.TableAdapterManager();
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaracunaTableAdapter = new Comel.comel_dbDataSetTableAdapters.stavkaracunaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(707, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(12, 341);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // txtStavka
            // 
            this.txtStavka.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "id_item", true));
            this.txtStavka.DataSource = this.itemsBindingSource;
            this.txtStavka.DisplayMember = "name_item";
            this.txtStavka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStavka.FormattingEnabled = true;
            this.txtStavka.Location = new System.Drawing.Point(100, 10);
            this.txtStavka.Name = "txtStavka";
            this.txtStavka.Size = new System.Drawing.Size(198, 21);
            this.txtStavka.TabIndex = 2;
            this.txtStavka.ValueMember = "id_item";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberi stavku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(100, 40);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(33, 20);
            this.txtKolicina.TabIndex = 5;
            this.txtKolicina.Text = "1";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // txtRacun
            // 
            this.txtRacun.Location = new System.Drawing.Point(355, 11);
            this.txtRacun.Multiline = true;
            this.txtRacun.Name = "txtRacun";
            this.txtRacun.Size = new System.Drawing.Size(427, 312);
            this.txtRacun.TabIndex = 6;
            this.txtRacun.Text = "Račun";
            this.txtRacun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(12, 317);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(51, 13);
            this.lblUkupno.TabIndex = 7;
            this.lblUkupno.Text = "Ukupno: ";
            // 
            // lblUkupnoCijena
            // 
            this.lblUkupnoCijena.AutoSize = true;
            this.lblUkupnoCijena.Location = new System.Drawing.Point(97, 317);
            this.lblUkupnoCijena.Name = "lblUkupnoCijena";
            this.lblUkupnoCijena.Size = new System.Drawing.Size(13, 13);
            this.lblUkupnoCijena.TabIndex = 8;
            this.lblUkupnoCijena.Text = "0";
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.Location = new System.Drawing.Point(110, 80);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(154, 23);
            this.btnDodajNaRacun.TabIndex = 9;
            this.btnDodajNaRacun.Text = "Dodaj na račun";
            this.btnDodajNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.btnDodajNaRacun_Click);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.itemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.racunTableAdapter = this.racunTableAdapter;
            this.tableAdapterManager.stavkaracunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comel.comel_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataMember = "stavkaracuna";
            this.stavkaracunaBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // stavkaracunaTableAdapter
            // 
            this.stavkaracunaTableAdapter.ClearBeforeFill = true;
            // 
            // frmNoviRacun
            // 
            this.AcceptButton = this.btnDodajNaRacun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(802, 391);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.lblUkupnoCijena);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.txtRacun);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStavka);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNoviRacun";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Racun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNoviRacun_FormClosing);
            this.Load += new System.EventHandler(this.frmNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.ComboBox txtStavka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina;
        private comel_dbDataSet comel_dbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private comel_dbDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox txtRacun;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblUkupnoCijena;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private comel_dbDataSetTableAdapters.racunTableAdapter racunTableAdapter;
        private comel_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private comel_dbDataSetTableAdapters.stavkaracunaTableAdapter stavkaracunaTableAdapter;
    }
}