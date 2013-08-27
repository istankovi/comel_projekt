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
    public partial class frmSkladiste : Form
    {
        public frmSkladiste()
        {
            InitializeComponent();
        }

        public int modificirano = -1;

        private void refresh_dgv() {
            int kat = Convert.ToInt32(cmbKat.SelectedValue);
            this.itemsTableAdapter.FillByKategorija(this.comel_dbDataSet.items, kat);
        }

        private void frmSkladiste_Load(object sender, EventArgs e)
        {
            // loadaj kategorije
            this.categoryTableAdapter.Fill(this.comel_dbDataSet.category);
            // loadaj iteme
            int kat = Convert.ToInt32(cmbKat.SelectedValue);
            this.itemsTableAdapter.FillByKategorija(this.comel_dbDataSet.items, kat);
        }

        private void btnSpremi_Click(object sender, EventArgs e) // dodaj količinu button
        {
            int itemID = (int)dgvItems.SelectedRows[0].Cells[0].Value;

            int kolicina;
            if (int.TryParse(txtKolicina.Text, out kolicina))
            {
                kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            else
            {
                MessageBox.Show("Količina mora biti numerička");
                return;
            }

            this.itemsTableAdapter.PromjeniKolicinu(kolicina, itemID);

            txtKolicina.Text = "0";
            refresh_dgv();
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            modificirano = 1;
        }
        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            modificirano = 0;
            itemsTableAdapter.Update(this.comel_dbDataSet.items);
        }

        private void frmSkladiste_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modificirano == 1)
            {
                DialogResult yes_no = MessageBox.Show("Niste spremili trenutne izmjene, želite li spremiti izmjene?", "Potvrda", MessageBoxButtons.YesNo);
                if (yes_no == System.Windows.Forms.DialogResult.Yes)
                {
                    itemsTableAdapter.Update(this.comel_dbDataSet.items);
                }
                else if (yes_no == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
        }

        private void cmbKat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh_dgv();
        }

        private void btnDodajNovuKategoriju_Click(object sender, EventArgs e)
        {
            frmKategorije kategorije = new frmKategorije();
            kategorije.ShowDialog();
            this.categoryTableAdapter.Fill(this.comel_dbDataSet.category);
            refresh_dgv();
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(cmbKat.SelectedValue);
                DialogResult confirm = MessageBox.Show("Jeste li sigurni da želite obrisati kategoriju? Ova akcija je nepovratna!", "Potvrda", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    categoryTableAdapter.DeleteRow(ID);
                    this.categoryTableAdapter.Fill(this.comel_dbDataSet.category);
                    refresh_dgv();
                }
                else return;
            }
            catch
            {
                MessageBox.Show("Ne možete obrisati kategoriju koja ima stavke");
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            frmStavke stavke = new frmStavke(Convert.ToInt32(cmbKat.SelectedValue));
            stavke.ShowDialog();
            refresh_dgv();
        }
    }
}
