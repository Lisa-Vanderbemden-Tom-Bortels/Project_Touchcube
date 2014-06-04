using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //moet myqsl/net connector hebben.

namespace Project_TouchCube
{   
    /**
     * Connection class
     * Written by: Tom Bortels
     * This class manages the connection to the mysql-database 
     * 
     * */
    class Connection
    {
        //for the moment the password and user name are still plain text,
        //I probably will play around with the idea of a reference library class holding this data
        private String dserver="localhost";
        private String dport = "3306";
        private String duser = "***************";
        private String dpass = "***************";
        private String db = "a2100359_project";

        private MySqlCommand msCom;
        private MySqlConnection msConn;
        private MySqlDataReader msDr; 

        //Constructor, initializing the msConn
        public Connection() {
            //Convert zero datetime needed for dataset error
            msConn = new MySqlConnection("Server=" + dserver + ";Port=" + dport + ";Database=" + db + ";Uid=" + duser + ";Pwd=" + dpass + ";Convert Zero Datetime=True;");
        }

        //Connects to the datbase, if it fails, it gives a message
        public bool connect() {            
            try{
               
                msConn.Open();
                return true;
            }
            catch(MySqlException ex){
               MessageBox.Show(ex.Message);
                return false;
            }
        }

        //deconnects the database
        public bool deconnect() {
            try
            {
                msConn.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool login(string username, string password) {
          
            msCom = new MySqlCommand();
            msCom.Connection = msConn;
            msCom.CommandText = "Select * from pr_login where L_ID = \""+username +"\" and L_Wachtwoord = \""+DSecurity.GetMd5Hash(password)+"\";";
            msCom.CommandType = System.Data.CommandType.Text;

            //connecting to the database
            if (connect())
            {

                //if user associate with querry is found: more than 1 row
                msDr = msCom.ExecuteReader();

                if (msDr.HasRows)
                {
                    deconnect();
                    return true;
                    
                }
                else {
                    deconnect();
                    return false;
                }
               
            }
            else {
                return false;
            }

        }

        //gathers all the patients
        public List<user> getPatients() {
            List<user> gebruikers = new List<user>();


            msCom = new MySqlCommand();
            msCom.Connection = msConn;
           // msCom.CommandText = "Select * from pr_gebruiker where U_Privilege=\"0\";"; originele string, maar dankzij postcode veranderd
            msCom.CommandText= "select "+
                                "pr_gebruiker.U_ID, pr_gebruiker.U_Voornaam,pr_gebruiker.U_Achternaam,pr_gebruiker.U_Geboortedatum,"+
                                "pr_gebruiker.U_Adres,pr_gebruiker.U_Postcode,pr_postcode.P_Gemeente,pr_postcode.P_Provincie ,pr_gebruiker.U_Telefoon,"+
                                "pr_gebruiker.U_Email,pr_gebruiker.U_Privilege "+
                                "from pr_gebruiker join pr_postcode "+ 
                                "on pr_gebruiker.U_postcode = pr_postcode.p_postcode "+
                                "where pr_gebruiker.U_privilege=\"0\";";

            msCom.CommandType = System.Data.CommandType.Text;
            
           connect();
           msDr= msCom.ExecuteReader();

            //check whether there are rows.
           if (msDr.HasRows) {
               while (msDr.Read()) {
                   user u1 = new user(msDr.GetInt32(0), msDr.GetString(1), msDr.GetString(2), msDr.GetDateTime(3), msDr.GetString(4), msDr.GetString(5),msDr.GetString(6), msDr.GetString(7), msDr.GetString(8),msDr.GetString(9), msDr.GetInt32(10));
                   gebruikers.Add(u1);
               } 
          
           }
           deconnect();
           return gebruikers;
            
        }

        //gets just one patient
        public user getPatient(int id)
        {
            user gebruiker=null;


            msCom = new MySqlCommand();
            msCom.Connection = msConn;
            msCom.CommandText = "select " +
                                "pr_gebruiker.U_ID, pr_gebruiker.U_Voornaam,pr_gebruiker.U_Achternaam,pr_gebruiker.U_Geboortedatum," +
                                "pr_gebruiker.U_Adres,pr_gebruiker.U_Postcode,pr_postcode.P_Gemeente,pr_postcode.P_Provincie ,pr_gebruiker.U_Telefoon," +
                                "pr_gebruiker.U_Email,pr_gebruiker.U_Privilege " +
                                "from pr_gebruiker join pr_postcode " +
                                "on pr_gebruiker.U_postcode = pr_postcode.p_postcode "+
                                "where pr_gebruiker.U_ID=\""+id+"\";";

            msCom.CommandType = System.Data.CommandType.Text;

            connect();
            msDr = msCom.ExecuteReader();

            //check whether there are rows.
            if (msDr.HasRows)
            {
                while (msDr.Read())
                {
                    gebruiker = new user(msDr.GetInt32(0), msDr.GetString(1), msDr.GetString(2), msDr.GetDateTime(3), msDr.GetString(4), msDr.GetString(5), msDr.GetString(6), msDr.GetString(7), msDr.GetString(8), msDr.GetString(9), msDr.GetInt16(10));

                }

            }
            deconnect();
            return gebruiker;

        }

        //gets history of one patient
        public List<measurement> getHistory(int id) {
            
            msCom = new MySqlCommand();
            List<measurement> metingen = new List<measurement>();
            measurement m1;

            msCom.Connection = msConn;
            msCom.CommandText = "select * from pr_meting where pr_meting.M_ID=\"" + id + "\" ORDER BY  M_Datum DESC LIMIT 10;";
            msCom.CommandType = CommandType.Text;

            connect();
            msDr = msCom.ExecuteReader();

            //check whether there are rows.
            if (msDr.HasRows)
            {
                
                while (msDr.Read())
                {
                    m1 = new measurement(msDr.GetInt32(0), msDr.GetDateTime(1), msDr.GetString(2), msDr.GetString(3), msDr.GetString(4), msDr.GetString(5), msDr.GetString(6), msDr.GetString(7), msDr.GetString(8), msDr.GetString(9), msDr.GetString(10), msDr.GetString(11), msDr.GetString(12), msDr.GetString(13), msDr.GetString(14), msDr.GetString(15));
                    metingen.Add(m1);
                }
            }
            deconnect();

            return metingen;
        }

        public bool addPatient(user gebruiker){
            string strQuery = "INSERT INTO  a2100359_project.pr_gebruiker (U_ID ,U_Voornaam,U_Achternaam ,U_Geboortedatum ,U_Adres ," +
                               "U_Postcode ,U_Telefoon ,U_Email ,U_Privilege) VALUES (" +
            "NULL , \"" + gebruiker.Voornaam + "\" ,  \"" + gebruiker.Achternaam + "\",  \"" + gebruiker.Geboortedatum.ToString("yyyy-MM-dd") + "\", \"" + gebruiker.Adres + "\"," +
            "\"" + gebruiker.Postcode + "\",  \"" + gebruiker.Telefoon + "\",\"" + gebruiker.Email + "\",  \"" + gebruiker.Niveau + "\");";

            msCom = new MySqlCommand();
            msCom.Connection = msConn;
            msCom.CommandText = strQuery;

            //MessageBox.Show(strQuery);

           try {
                connect();
                if (msCom.ExecuteNonQuery() == 1) {
                    return true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally {
                deconnect();
            }
            return false;   
        }

        public bool addMeasurement(measurement meting) { 
            string strQuery = "INSERT INTO a2100359_project.pr_meting (M_ID, M_Datum, M_Duimtop, M_Duimbot," +
            "M_Wijstop, M_Wijsmid, M_Wijsbot, M_Midtop, M_Midmid, M_Midbot, M_Ringtop, M_Ringmid, M_Ringbot, M_Pinktop, M_Pinkmid, M_Pinkbot)"+ 
            "VALUES ('"+meting.Gebruiker+"','"+meting.Datum.ToString("yyyy-MM-dd HH:mm:ss")+"' , '"+meting.Duimtop+"', '"+meting.Duimbot+"', '"+meting.Wijstop+"', '"+meting.Wijsmid+"', '"+meting.Wijsbot+
                "', '"+meting.Midtop+"', '"+meting.Midmid+"', '"+meting.Midbot+"', '"+meting.Ringtop+"', '"+meting.Ringmid+"', '"+meting.Ringbot+"', '"+meting.Pinktop+
                "', '"+meting.Pinkmid+"', '"+meting.Pinkbot+"');";
            msCom = new MySqlCommand();
            msCom.Connection = msConn;
            msCom.CommandText = strQuery;

            //MessageBox.Show(strQuery);

           try {
                connect();
                if (msCom.ExecuteNonQuery() == 1) {
                    return true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally {
                deconnect();
            }
            return false;   
        }
        }

    }

