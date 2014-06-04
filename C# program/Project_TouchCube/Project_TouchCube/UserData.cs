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
    public partial class UserData : Form
    {
        /**
         * 
         * UserData class
         * Written by: Tom Bortels
         * This class displays user info and history
         * 
         * */
        private user gebruiker;
        private string language="nl";



        public user Gebruiker
        {
            get { return gebruiker; }
            set { gebruiker = value; }
        }

        public UserData(user u1,string language)
        {
            InitializeComponent();
            this.gebruiker = u1;

            this.language = language;

            lbl_voornaam.Text = gebruiker.Voornaam;
            lbl_achternaam.Text = gebruiker.Achternaam;
            lbl_adres.Text = gebruiker.Adres + Environment.NewLine + gebruiker.Postcode+" "+gebruiker.Gemeente;
            lbl_geboortedatum.Text = gebruiker.Geboortedatum.Date.Day + "/" + gebruiker.Geboortedatum.Month + "/" + gebruiker.Geboortedatum.Year; //there probably is a better way of doing this
            lbl_telefoon.Text = gebruiker.Telefoon;
            lbl_email.Text = gebruiker.Email;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            if (this.language.Equals("nl"))
            {
                nederlands();
            }
            else {
                english();
            }


          Connection conn = new Connection();
            //loading history into graph
          chartUC1.loadUC(gebruiker.Id);

        }

        private void english() {
            lbl_vnaam.Text = "First name";
            lbl_anaam.Text = "Surname";
            lbl_adrs.Text = "Address";
            lbl_gbdat.Text = "Date of birth";
            lbl_tel.Text = "Phone number";
            lbl_mail.Text = "E-mail address";

            tabControl1.TabPages[0].Text = "Personal Info";
            tabControl1.TabPages[1].Text = "History";

            rbt_Duim.Text = "Thumb";
            rbt_wijsvinger.Text = "Index Finger";
            rbt_middelvinger.Text = "Middle Finger";
            rbt_ringvinger.Text = "Ring Finger";
            

        }

        private void nederlands() {
            lbl_vnaam.Text = "Voornaam";
            lbl_anaam.Text = "Achternaam";
            lbl_adrs.Text = "Adres";
            lbl_gbdat.Text = "Geboortedatum";
            lbl_tel.Text = "Telefoonnummer";
            lbl_mail.Text = "E-mail addres";

            tabControl1.TabPages[0].Text = "Persoonlijke Info";
            tabControl1.TabPages[1].Text = "Historiek";

            rbt_Duim.Text = "Duim";
            rbt_wijsvinger.Text = "Wijsvinger";
            rbt_middelvinger.Text = "Middelvinger";
            rbt_ringvinger.Text = "Ringvinger";
        }

        private void chartUC1_Load(object sender, EventArgs e)
        {

        }

        private void rbt_wijsvinger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_wijsvinger.Checked)
            {
                chartUC1.drawgraph(0);
            }
        }

        private void rbt_middelvinger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_middelvinger.Checked) {
                chartUC1.drawgraph(1);
            }
        }

        private void rbt_ringvinger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_ringvinger.Checked)
            {
                chartUC1.drawgraph(2);
            }
        }

        private void rbt_pink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_pink.Checked)
            {
                chartUC1.drawgraph(3);
            }
        }

        private void rbt_Duim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Duim.Checked)
            {
                chartUC1.drawgraph(4);
            }
        }
        
    }
}
