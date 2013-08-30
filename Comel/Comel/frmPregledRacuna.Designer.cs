namespace Comel
{
    partial class frmPregledRacuna
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RacuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comel_dbDataSet = new Comel.comel_dbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RacuniTableAdapter = new Comel.comel_dbDataSetTableAdapters.RacuniTableAdapter();
            this.txtRacun = new System.Windows.Forms.ComboBox();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRacun = new System.Windows.Forms.Label();
            this.racunTableAdapter = new Comel.comel_dbDataSetTableAdapters.racunTableAdapter();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaracunaTableAdapter = new Comel.comel_dbDataSetTableAdapters.stavkaracunaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RacuniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RacuniBindingSource
            // 
            this.RacuniBindingSource.DataMember = "Racuni";
            this.RacuniBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // comel_dbDataSet
            // 
            this.comel_dbDataSet.DataSetName = "comel_dbDataSet";
            this.comel_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "Računi";
            reportDataSource3.Value = this.RacuniBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Comel.StavkeRačuna.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(452, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // RacuniTableAdapter
            // 
            this.RacuniTableAdapter.ClearBeforeFill = true;
            // 
            // txtRacun
            // 
            this.txtRacun.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.racunBindingSource, "racun_id", true));
            this.txtRacun.DataSource = this.racunBindingSource;
            this.txtRacun.DisplayMember = "racun_id";
            this.txtRacun.FormattingEnabled = true;
            this.txtRacun.Location = new System.Drawing.Point(78, 21);
            this.txtRacun.Name = "txtRacun";
            this.txtRacun.Size = new System.Drawing.Size(86, 21);
            this.txtRacun.TabIndex = 1;
            this.txtRacun.ValueMember = "racun_id";
            this.txtRacun.SelectedIndexChanged += new System.EventHandler(this.txtRacun_SelectedIndexChanged);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.comel_dbDataSet;
            // 
            // lblRacun
            // 
            this.lblRacun.AutoSize = true;
            this.lblRacun.Location = new System.Drawing.Point(13, 24);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(59, 13);
            this.lblRacun.TabIndex = 2;
            this.lblRacun.Text = "Račun ID: ";
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(170, 19);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši račun";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
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
            // frmPregledRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 475);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblRacun);
            this.Controls.Add(this.txtRacun);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPregledRacuna";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled računa";
            this.Load += new System.EventHandler(this.frmPregledRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RacuniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comel_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RacuniBindingSource;
        private comel_dbDataSet comel_dbDataSet;
        private comel_dbDataSetTableAdapters.RacuniTableAdapter RacuniTableAdapter;
        private System.Windows.Forms.ComboBox txtRacun;
        private System.Windows.Forms.Label lblRacun;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private comel_dbDataSetTableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private comel_dbDataSetTableAdapters.stavkaracunaTableAdapter stavkaracunaTableAdapter;
    }
}