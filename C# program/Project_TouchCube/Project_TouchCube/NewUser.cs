using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_TouchCube
{
    public partial class NewUser : Form
    {
        /**
      * 
      * NewUser class
      * written by: Tom Bortels
      * This Class is used to add new users to the database
      * 
      * 
      * */
        Connection conn;
        private string language = "nl";
        
        
        public NewUser(string language)
        {
            InitializeComponent();
            conn = new Connection();
            dtp_geboortedatum.Format = DateTimePickerFormat.Custom;
            dtp_geboortedatum.CustomFormat = "yyyy-MM-dd";
            cmb_level.SelectedIndex = 0;

            this.language = language;

            if(this.language.Equals("nl")){
                nederlands();
            }
            if(this.language.Equals("en")){
                engels();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            user gebruiker = new user(0, txt_voornaam.Text, txt_achternaam.Text, dtp_geboortedatum.Value.Date, txt_adres.Text, txt_postcode.Text, null, null, txt_telefoon.Text, txt_email.Text,cmb_level.SelectedIndex);

            if (String.IsNullOrEmpty(gebruiker.Achternaam) || String.IsNullOrEmpty(gebruiker.Voornaam) || String.IsNullOrEmpty(gebruiker.Postcode) || string.IsNullOrEmpty(gebruiker.Email) || string.IsNullOrEmpty(gebruiker.Adres)) {
                lbl_error.Text = "Gelieve alle velden in te vullen";
                error = true;
            }


            if(!Regex.IsMatch(gebruiker.Email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")){
                
                lbl_error.Text = "Gelieve een geldig email adres in te vullen";
                error = true;
            }

            if(!Regex.IsMatch(gebruiker.Telefoon,@"^[0][0-9]{9}|[0][0-9]{8}$")){
                lbl_error.Text = "Gelieve een geldig telefoonnummer in te vullen";
                error = true;
            }

            if(!error){
                lbl_error.Text = "";

                try{
                    if (conn.addPatient(gebruiker)) { 
                        if(this.language.Equals("en")){
                            MessageBox.Show("User Added");
                        }
                        if(this.language.Equals("nl")){
                            MessageBox.Show("gebruiker toegevoegd");
                        }
                    }
                }
                catch{
                    lbl_error.Text = "Er is een fout opgetreden, probeer later opnieuw";
                }
            }
        }


        private void nederlands() {
            lbl_adrs.Text = "Adres";
            lbl_vnaam.Text = "Voornaam";
            lbl_anaam.Text = "Achternaam";
            lbl_gbdat.Text = "Geboortedatum";
            Lbl_level.Text = "Niveau";
            lbl_mail.Text = "E-mail adres";
            lbl_postcode.Text = "Postcode";
            lbl_tel.Text = "Telefoonnummer";
            btn_upload.Text = "voeg toe";
           

        
        }

        private void engels() {
            lbl_adrs.Text = "Address";
            lbl_vnaam.Text = "First Name";
            lbl_anaam.Text = "Surname";
            lbl_gbdat.Text = "Date of Birth";
            Lbl_level.Text = "Clearance";
            lbl_mail.Text = "E-mail address";
            lbl_postcode.Text = "Postal Code";
            lbl_tel.Text = "Telephone Number";
            btn_upload.Text = "Add";
        }
        
        
        private void Form4_Load(object sender, EventArgs e)
        {
            cmb_level.SelectedIndex = 0;
        }

    }
}
