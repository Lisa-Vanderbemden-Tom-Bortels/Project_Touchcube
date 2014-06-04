using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace Project_TouchCube
{
    public partial class Main : Form
    {
        /**
         * 
         * Main class
         * written by: Tom Bortels
         * This Class is the main and home screen of the application
         * it handles the reading of the sensor as well as an overview of the patients/measurements
         * 
         * */

        string id; //user
        string language="nl";
        Connection conn;
        SerialPort sp;
        delegate void updateLbldelegate(String str);
        bool active = false;

        public Main(string language)
        {
            InitializeComponent();
            conn = new Connection();
            cmb_port.DataSource = SerialPort.GetPortNames();

            if (cmb_port.Items.Count > 0)
            {
                cmb_port.SelectedIndex = 0;
            }

            this.language = language;

            if(this.language.Equals("nl")){
                nederlands();
            }
            if(this.language.Equals("en")){
                engels();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadPatients();
        }

        //fills the combobox with availlable patients.
        private void loadPatients() {
            List<user> gebruikers = conn.getPatients();

            foreach(user gebruiker in gebruikers){
                cmb_patients.DataSource = gebruikers;
                cmb_patients.ValueMember = "id";
                cmb_patients.DisplayMember = "fullname";
                cmb_patients.SelectedIndex = 0;
            }
        }

        private void bestandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user gebruiker = conn.getPatient(Int32.Parse(cmb_patients.SelectedValue.ToString()));
            UserData info = new UserData(gebruiker, language);
            info.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cmb_port.DataSource = SerialPort.GetPortNames();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try{
                sp = new SerialPort();
            sp.BaudRate = 9600;
            sp.PortName = cmb_port.SelectedValue.ToString();
            sp.Parity = System.IO.Ports.Parity.None;
            sp.DataBits = 8;
            sp.StopBits = System.IO.Ports.StopBits.One;
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            sp.Open();
            tlstlbl_status.ForeColor = Color.Black;

                 if(this.language.Equals("nl")){
                tlstlbl_status.Text ="Verbonden met poort : "+sp.PortName;
                }
                if(this.language.Equals("en")){
                    tlstlbl_status.Text= "Connected to port : "+sp.PortName;
                }
           
            } 
            catch(Exception ex){
                MessageBox.Show("Er is een fout opgetreden:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            }

            active = true;
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String str;
            if (sp.IsOpen)
            {
                str = sp.ReadLine();

                if (!String.IsNullOrEmpty(str))
                {
                    updateLbl(str);
                }
            }


        }


        private void updateLbl(String str)
        {
            String[] values;
            if (InvokeRequired)
            {
                Invoke(new updateLbldelegate(updateLbl), str);
            }
            else
            {

                if (Regex.IsMatch(str, "ptc:([0-9]([0-9]*):){14}ptc"))
                {
                    // index starst at 1, 0 is control elements
                    values = str.Split(':');
                    setcolor(lbl_duimtop,Int32.Parse(values[1]));
                    lbl_duimtop.Text = values[1].ToString();
                    
                    setcolor(lbl_duimbot, Int32.Parse(values[2]));
                    lbl_duimbot.Text = values[2].ToString();
                    
                    setcolor(lbl_wijstop, Int32.Parse(values[3]));
                    lbl_wijstop.Text = values[3].ToString();

                    setcolor(lbl_wijsmid, Int32.Parse(values[4]));
                    lbl_wijsmid.Text = values[4].ToString();

                    setcolor(lbl_wijsbot, Int32.Parse(values[5]));
                    lbl_wijsbot.Text = values[5].ToString();

                    setcolor(lbl_midtop, Int32.Parse(values[6]));
                    lbl_midtop.Text = values[6].ToString();

                    setcolor(lbl_midmid, Int32.Parse(values[7]));
                    lbl_midmid.Text = values[7].ToString();

                    setcolor(lbl_midbot, Int32.Parse(values[8]));
                    lbl_midbot.Text = values[8].ToString();

                    setcolor(lbl_ringtop, Int32.Parse(values[9]));
                    lbl_ringtop.Text = values[9].ToString();

                    setcolor(lbl_ringmid,Int32.Parse(values[10]));
                    lbl_ringmid.Text = values[10].ToString();

                    setcolor(lbl_ringbot,Int32.Parse(values[11]));
                    lbl_ringbot.Text = values[11].ToString();

                    setcolor(lbl_pinktop, Int32.Parse(values[12]));
                    lbl_pinktop.Text = values[12].ToString();

                    setcolor(lbl_pinkmid, Int32.Parse(values[13]));
                    lbl_pinkmid.Text = values[13].ToString();

                    setcolor(lbl_pinkbot, Int32.Parse(values[14]));
                    lbl_pinkbot.Text = values[14].ToString();
                }

            }
        }

        private void setcolor(Label lbl,int waarde) { 
            int maxvalue = 255;
            if (waarde < maxvalue / 10) {
                lbl.BackColor = SystemColors.Control;
            }
            if (waarde >= (maxvalue / 10) && waarde < ((maxvalue / 10) * 2)) {
                lbl.BackColor = Color.PaleGreen;
            }
            if (waarde >=( 2*(maxvalue / 10)) && waarde < ((maxvalue / 10) * 3)) {
                lbl.BackColor = Color.Lime;
            }
            if (waarde >= (3*(maxvalue / 10)) && waarde < ((maxvalue / 10) * 4)) {
                lbl.BackColor = Color.GreenYellow;
            }
            if (waarde >= (4*(maxvalue / 10)) && waarde < ((maxvalue / 10) * 5)) {
                lbl.BackColor = Color.Yellow;
            }
            if (waarde >= (5*(maxvalue / 10)) && waarde < ((maxvalue / 10) * 6)) {
                lbl.BackColor = Color.Orange;
            }
            if (waarde >= (6*(maxvalue / 10)) && waarde < ((maxvalue / 10) * 7)) { 
                lbl.BackColor = Color.OrangeRed;
            }
            if(waarde>= (7*(maxvalue/10))){
                lbl.BackColor = Color.Red;
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Close();
                lbl_duimtop.Text = "000";
                setcolor(lbl_duimtop, 0);
               
                lbl_duimbot.Text = "000";
                setcolor(lbl_duimbot, 0);
               
                lbl_wijstop.Text = "000";
                setcolor(lbl_wijstop, 0);
                
                lbl_wijsmid.Text = "000";
                setcolor(lbl_wijsmid, 0);
                
                lbl_wijsbot.Text = "000";
                setcolor(lbl_wijsbot, 0);
                
                lbl_midtop.Text = "000";
                setcolor(lbl_midtop, 0);
                
                lbl_midmid.Text = "000";
                setcolor(lbl_midmid, 0);
                
                lbl_midbot.Text = "000";
                setcolor(lbl_midbot, 0);
                
                lbl_ringtop.Text = "000";
                setcolor(lbl_ringtop, 0);
                
                lbl_ringmid.Text = "000";
                setcolor(lbl_ringmid, 0);
                
                lbl_ringbot.Text = "000";
                setcolor(lbl_ringbot, 0);

                lbl_pinktop.Text = "000";
                setcolor(lbl_pinktop, 0);

                lbl_pinkmid.Text = "000";
                setcolor(lbl_pinkmid, 0);

                lbl_pinkbot.Text = "000";
                setcolor(lbl_pinkbot, 0);

                tlstlbl_status.ForeColor = Color.DarkRed;

                if (this.language.Equals("nl"))
                {
                    tlstlbl_status.Text = "Niet verbonden met sensor";
                }
                if (this.language.Equals("en"))
                {
                    tlstlbl_status.Text = "Not connected to sensor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            active = false;
        }

        private void nederlands() {
            groupBox1.Text = "Patiënten";
            label3.Text = "Bekijk patiëntgegevens";
            btn_patient.Text = "Bekijk patiënt";
            label3.Text = "Voeg nieuwe gebruiker toe";
            btn_add.Text = "Voeg toe";
            groupBox2.Text = "Metingen";
            label1.Text = "Poort";
            btn_measurement.Text = "Voeg nieuwe meting toe";
            label2.Text = "Voeg nieuwe patiënt toe";
            groupBox3.Text = "Connectie";

        
        }
        private void engels() {
            groupBox1.Text = "Patients";
            label3.Text = "View patientrecords";
            btn_patient.Text = "View patiënt";
            label3.Text = "Add new user";
            btn_add.Text = "Add";
            groupBox2.Text = "Measurements";
            label1.Text = "Port";
            btn_measurement.Text = "Add new measurement";
            label2.Text = "Add new patient";
            groupBox3.Text = "Connection";
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            NewUser add = new NewUser(this.language);
            add.Show();
        }

        private void btn_measurement_Click(object sender, EventArgs e)
        {

            if (active) {
                measurement meting = new measurement(cmb_patients.SelectedIndex, DateTime.Now, lbl_duimtop.Text, lbl_duimbot.Text, lbl_wijstop.Text, lbl_wijsmid.Text, lbl_wijsbot.Text, lbl_midtop.Text, lbl_midmid.Text, lbl_midbot.Text, lbl_ringtop.Text, lbl_ringmid.Text, lbl_ringbot.Text, lbl_pinktop.Text, lbl_pinkmid.Text, lbl_pinkbot.Text);
                try
                {
                    if (conn.addMeasurement(meting))
                    {
                        if (this.language.Equals("en"))
                        {
                            MessageBox.Show("Measurement Added");
                        }
                        if (this.language.Equals("nl"))
                        {
                            MessageBox.Show("meting toegevoegd");
                        }
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Er is een fout opgetreden, probeer later opnieuw");
                }
            }

        }
    
    }
}
