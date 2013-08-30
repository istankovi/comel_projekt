using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comel
{
    public partial class frmPregledRacuna : Form
    {
        public frmPregledRacuna()
        {
            InitializeComponent();
        }

        private void frmPregledRacuna_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'comel_dbDataSet.stavkaracuna' table.
            this.stavkaracunaTableAdapter.Fill(this.comel_dbDataSet.stavkaracuna);
            // This line of code loads data into the 'comel_dbDataSet.racun' table.
            this.racunTableAdapter.Fill(this.comel_dbDataSet.racun);

            if (txtRacun.SelectedValue != null)
            {
                int racunID = (int)txtRacun.SelectedValue;
                this.RacuniTableAdapter.FillByID(this.comel_dbDataSet.Racuni, racunID); // loadaj samo racune pojedinog ID-a
                this.reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Ne postoji niti jedan račun");
        }

        private void txtRacun_SelectedIndexChanged(object sender, EventArgs e) // isto kao i load, samo na promjenu indexa u cmb
        {
            if (txtRacun.SelectedValue != null) { 
                int racunID = (int)txtRacun.SelectedValue;
                this.RacuniTableAdapter.FillByID(this.comel_dbDataSet.Racuni, racunID); 
            } 
                this.reportViewer1.RefreshReport(); 
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (txtRacun.SelectedValue == null) return;
            this.stavkaracunaTableAdapter.ObrisiStavkeRacunaID((int)txtRacun.SelectedValue); // obrisi sve stavke ovog racuna
            this.racunTableAdapter.ObrisiRacunByID((int)txtRacun.SelectedValue); // obrisi sam racun
            this.racunTableAdapter.Fill(this.comel_dbDataSet.racun); // refresh dataset za id racuna
        }
    }
}
