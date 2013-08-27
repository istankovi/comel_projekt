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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ispis_greske_u_label() {
            lblStatus.Visible = false;
            System.Threading.Thread.Sleep(500);
            lblStatus.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            string provjera = "";
            try { // ako korisnik postoji u bazi onda
                
                //bypass logina NE ZABORAVI MAKNUTI
                //user = "admin";
                //pass = "admin";

                provjera = usersTableAdapter.VratiPassword(user).ToString();

                if (pass == provjera)
                {
                    Varijable.tip_korisnika = Convert.ToInt32(usersTableAdapter.VratiTip(user));
                    this.Close();
                }
                else {
                    ispis_greske_u_label();
                }
            } catch // ako korisnik ne postoji u bazi onda
            {
                ispis_greske_u_label();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // popis passworda iz baze
            // MessageBox.Show("Username / Password\r\n\r\nadmin/admin\r\nblagajnik/blagajnik\r\nskladistar/skladistar");
        }
    }
}
