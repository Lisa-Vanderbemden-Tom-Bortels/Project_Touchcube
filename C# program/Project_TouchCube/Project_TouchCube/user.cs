using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_TouchCube
{

    /**
     * 
     * user class
     * Written by: Tom Bortels
     * class used to store elements from the pr_gebruiker table.
     * 
     * */
   public class user
    {
        private int id;
        private string voornaam;
        private string achternaam;
        private DateTime geboortedatum;
        private string adres;
        private string postcode;
        private string telefoon;
        private string email;
        private int niveau;
        //combobox can only handle 1 displaymember
        private string fullname;

        private string gemeente;
        private string provincie;

        #region "getters/setters"
     
       public int Id
        {
            get { return id; }
            set { id = value; }
        }
       

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }
        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }
        public DateTime Geboortedatum
        {
            get { return geboortedatum; }
            set { geboortedatum = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }


        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }


        public string Telefoon
        {
            get { return telefoon; }
            set { telefoon = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public int Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        public string Fullname {
            get { return fullname; }
            set { fullname = value; }
        }

        public string Gemeente
        {
            get { return gemeente; }
            set { gemeente = value; }
        }

        public string Provincie
        {
            get { return provincie; }
            set { provincie = value; }
        }

        #endregion

        //constructor
        public user(int id, string voornaam, string achternaam, DateTime geboortedatum, string adres, string postcode, string gemeente, string provincie, string telefoonnummer, string email,int niveau) {
            this.id = id;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.adres = adres;
            this.geboortedatum = geboortedatum;
            this.postcode = postcode;
            this.email = email;
            this.telefoon = telefoonnummer;
            this.niveau = niveau;

            this.fullname = voornaam + " " + achternaam;
            this.gemeente = gemeente;
            this.provincie = provincie;

        }


    }
}
