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
    public partial class frmStavke : Form
    {
        public int inicijalna_kat = 0;
        public frmStavke(int kategorija) // konstruktor, preseta početnu kategoriju iz prosle forme
        {
            InitializeComponent();
            inicijalna_kat = kategorija;
        }

        
        private void frmStavke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comel_dbDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.comel_dbDataSet.items);
            // TODO: This line of code loads data into the 'comel_dbDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.comel_dbDataSet.category);
            txtKat.SelectedValue = inicijalna_kat;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            if (naziv == "") {
                MessageBox.Show("Morate unijeti naziv proizvoda");
                return;
            }
            string opis = txtOpis.Text;

            double cijena;
            bool result;
            
            result = double.TryParse(txtCijena.Text, out cijena);
            if (result)
            {
                cijena = Convert.ToDouble(txtCijena.Text);
            }
            else
            {
                MessageBox.Show("Cijena mora biti numerička");
                return;
            }

            int kolicina;
            result = int.TryParse(txtKolicina.Text, out kolicina);
            if (result)
            {
                kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            else
            {
                MessageBox.Show("Količina mora biti numerička");
                return;
            }

            int kategorija = Convert.ToInt32(txtKat.SelectedValue); // uvijek ce biti int

            txtNaziv.Text = "";
            txtCijena.Text = "";
            txtOpis.Text = "";
            txtCijena.Text = "";
            txtKolicina.Text = "";

            try
            {
                this.itemsTableAdapter.Insert(naziv, cijena, opis, kategorija, kolicina);
                MessageBox.Show("Dodana nova stavka " + naziv);
            }
            catch {
                MessageBox.Show("Greska prilikom upisa u bazu");
            }
        }
    }
}
