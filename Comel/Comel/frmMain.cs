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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult yes_no = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?", "Izlaz", MessageBoxButtons.YesNo);
            if (yes_no == System.Windows.Forms.DialogResult.Yes)
            {
            }
            else if (yes_no == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void postavi_meni()
        {
            if (Varijable.tip_korisnika == -1) // nijedan korisnik
            {
                logoutToolStripMenuItem.Visible = false;
                skladišteToolStripMenuItem.Visible = false;
                računiToolStripMenuItem.Visible = false;
            }
            else if (Varijable.tip_korisnika == 1) // admin 
            {
                logoutToolStripMenuItem.Visible = true;
                skladišteToolStripMenuItem.Visible = true;
                računiToolStripMenuItem.Visible = true;
            }
            else if (Varijable.tip_korisnika == 2) // blagajnik 
            {
                logoutToolStripMenuItem.Visible = true;
                skladišteToolStripMenuItem.Visible = true;
                računiToolStripMenuItem.Visible = true;
            }
            else if (Varijable.tip_korisnika == 3) // skladištar 
            {
                logoutToolStripMenuItem.Visible = true;
                skladišteToolStripMenuItem.Visible = true;
                računiToolStripMenuItem.Visible = false;
            }
        }

        private void prikazi_prijavu() {
            frmLogin prijava = new frmLogin();
            prijava.ShowDialog();
            if (Varijable.tip_korisnika != -1) {
                // MessageBox.Show("Prijava uspješna, tip korisnika: " + Varijable.tip_korisnika);
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
                postavi_meni();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prikazi_prijavu();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            prikazi_prijavu();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varijable.tip_korisnika = -1;
            // MessageBox.Show("Odjava uspješna, tip korisnika: " + Varijable.tip_korisnika);
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
            postavi_meni();
            prikazi_prijavu();
        }

        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSkladiste skladiste = new frmSkladiste();
            skladiste.ShowDialog();
        }

        private void noviRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoviRacun noviracun = new frmNoviRacun();
            noviracun.ShowDialog();
        }

        private void pregledaRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledRacuna PregledRacuna = new frmPregledRacuna();
            PregledRacuna.ShowDialog();
        }
    }

    public static class Varijable
    {
        public static int tip_korisnika = -1;
    }

}
