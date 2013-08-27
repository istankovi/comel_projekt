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
    public partial class frmKategorije : Form
    {
        public frmKategorije()
        {
            InitializeComponent();
        }

        private void frmKategorije_Load(object sender, EventArgs e)
        {
            // nista
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "")  // ako naziv nije prazan
            {
                try
                {
                    categoryTableAdapter.Insert(txtNaziv.Text, txtOpis.Text);
                    MessageBox.Show("Kategorija " + txtNaziv.Text + " je dodana");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Greska prilikom upisa");
                }
            }
            else MessageBox.Show("Naziv kategorije je obavezan");
        }
    }
}
