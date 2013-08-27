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
    public partial class frmNoviRacun : Form
    {
        public frmNoviRacun()
        {
            InitializeComponent();
        }

        private DateTime vrijeme_otvaranja_racuna;
        private int racun_otvoren = 1;
        private int id_racun;
        private void frmNoviRacun_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'comel_dbDataSet.racun' table.
            this.racunTableAdapter.Fill(this.comel_dbDataSet.racun);
            // This line of code loads data into the 'comel_dbDataSet.items' table.
            this.itemsTableAdapter.Fill(this.comel_dbDataSet.items);
            
            vrijeme_otvaranja_racuna = DateTime.Now;
            this.racunTableAdapter.Insert(vrijeme_otvaranja_racuna, Varijable.tip_korisnika); //otvori racun s vremenom i korisnikom koji ga otvara

            id_racun = Convert.ToInt32(this.racunTableAdapter.VratiIDRacuna(vrijeme_otvaranja_racuna, Varijable.tip_korisnika)); // buduci da je racun ID inkremenatalan, vraca ID novog racuna
            
            txtRacun.Text = txtRacun.Text + "\r\nVrijeme: " + vrijeme_otvaranja_racuna.ToString() + "\r\n";
            txtRacun.Text = txtRacun.Text + "\r\nStavka\tKoličina\tCijena\r\n\r\n";
        }

        private void btnDodajNaRacun_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in this.comel_dbDataSet.items) // prolazi sve iteme u bazi
            {
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

                if (txtStavka.SelectedValue.ToString() == row["id_item"].ToString())  // ako je nadjen item
                {
                    try {
                        if (kolicina > Convert.ToInt32(row["kolicina"]))  // provjeri kolicinu
                        {
                            MessageBox.Show("Nedovoljna količina na skladištu");
                            return;
                        }
                        this.stavkaracunaTableAdapter.Insert(id_racun, Convert.ToInt32(row["id_item"]),kolicina);  // ubaci stavku racuna
                        double iznos_stavki = kolicina * Convert.ToDouble(row["cijena_item"]); // izracunaj cijenu

                        txtRacun.Text = txtRacun.Text + row["name_item"].ToString() + "\t" + kolicina.ToString() + "\t" + iznos_stavki.ToString() + "\r\n";
                        lblUkupnoCijena.Text = (Convert.ToDouble(lblUkupnoCijena.Text) + iznos_stavki).ToString();
                        
                        this.itemsTableAdapter.PromjeniKolicinu(kolicina*(-1), Convert.ToInt32(row["id_item"])); // promjeni kolicinu na skladistu
                    }
                    catch {
                        MessageBox.Show("Stavka već postoji na računu");
                    }
                }
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            racun_otvoren = 0;
            this.Close();
        }

        private void obrisi_racun() {
            this.stavkaracunaTableAdapter.Fill(this.comel_dbDataSet.stavkaracuna); 
            foreach (DataRow row in this.comel_dbDataSet.stavkaracuna) // obrisi sve stavke racuna prvo
            {
                if (id_racun == Convert.ToInt32(row["racun_id"]))  // ako stavka pripada ovom racunu
                {
                    this.stavkaracunaTableAdapter.ObrisiStavkeRacunaID(id_racun);
                    this.itemsTableAdapter.PromjeniKolicinu(Convert.ToInt32(row["kolicina"]), Convert.ToInt32(row["item_id"])); // uvecaj kolicinu na skladistu buduci da brisemo racun
                    
                }
            }
            this.racunTableAdapter.DeleteQuery(vrijeme_otvaranja_racuna, Varijable.tip_korisnika); // obrisi sam racun
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            obrisi_racun();
        }

        private void frmNoviRacun_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (racun_otvoren == 1) obrisi_racun();
        }
    }
}
