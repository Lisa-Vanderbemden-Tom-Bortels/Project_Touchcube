using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Project_TouchCube
{
    public partial class Login : Form
    {
        /**
         * Login class
         * Written by: Tom Bortels
         * this class handles the login into the application
         * 
         * */


        //conn handles the login part
        Connection conn;
        string language = "nl";

        public Login()
        {
            conn = new Connection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set nederlands to default language
            cmb_language.SelectedIndex = 0;

        }

      
        // change languague
        private void cmb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_language.SelectedIndex == 1) {
                lbl_username.Text = "   username";
                lbl_pasword.Text = "password";
                btn_login.Text = "log in";
                language = "en";
            }
            else if (cmb_language.SelectedIndex == 0) {
                lbl_pasword.Text = "wachtwoord";
                lbl_username.Text = "gebruikersnaam";
                btn_login.Text = "inloggen";
                language = "nl";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //loggin in procedure
            //login succesvol
            if (conn.login(txt_username.Text, txt_pasword.Text))
            {
                Main frm = new Main(language);
                frm.Show();
                this.Hide();
            }//login failed
            else {
                lbl_error.ForeColor = Color.Red;
                
                //languague specific error
                if (cmb_language.SelectedIndex == 0)
                    lbl_error.Text = "Gebruiker/wachtwoordcombinatie niet gevonden";
                else
                    lbl_error.Text = "Could not find username/password combination";

            }
        }



    }
}
