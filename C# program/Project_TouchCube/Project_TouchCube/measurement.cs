using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_TouchCube
{
   public class measurement
    {
       int gebruiker;
       DateTime datum;
       string duimtop;
       string duimbot;
       string wijstop;
       string wijsmid;
       string wijsbot;
       string midtop;
       string midmid;
       string midbot;
       string ringtop;
       string ringmid;
       string ringbot;
       string pinktop;
       string pinkmid;
       string pinkbot;

        public int Gebruiker
        {
            get { return gebruiker; }
            set { gebruiker = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
 
        public string Duimtop
        {
            get { return duimtop; }
            set { duimtop = value; }
        }

        public string Duimbot
        {
            get { return duimbot; }
            set { duimbot = value; }
        }

        public string Wijstop
        {
            get { return wijstop; }
            set { wijstop = value; }
        }
  
        public string Wijsmid
        {
            get { return wijsmid; }
            set { wijsmid = value; }
        }

        public string Wijsbot
        {
            get { return wijsbot; }
            set { wijsbot = value; }
        }

        public string Midtop
        {
            get { return midtop; }
            set { midtop = value; }
        }

        public string Midmid
        {
            get { return midmid; }
            set { midmid = value; }
        }
    
        public string Midbot
        {
            get { return midbot; }
            set { midbot = value; }
        }

        public string Ringtop
        {
            get { return ringtop; }
            set { ringtop = value; }
        }
    
        public string Ringmid
        {
            get { return ringmid; }
            set { ringmid = value; }
        }
   
        public string Ringbot
        {
            get { return ringbot; }
            set { ringbot = value; }
        }

        public string Pinktop
        {
            get { return pinktop; }
            set { pinktop = value; }
        }
   
        public string Pinkmid
        {
            get { return pinkmid; }
            set { pinkmid = value; }
        }
        

        public string Pinkbot
        {
            get { return pinkbot; }
            set { pinkbot = value; }
        }

        public measurement(int gebruiker, DateTime datum, string duimtop, string duimbot, string wijstop, string wijsmid, string wijsbot, string midtop, string midmid, string midbot, string ringtop, string ringmid, string ringbot, string pinktop, string pinkmid, string pinkbot)
        {
            this.gebruiker = gebruiker;
            this.datum = datum;
            this.duimbot = duimbot;
            this.duimtop = duimtop;
            this.wijstop = wijstop;
            this.wijsmid = wijsmid;
            this.wijsbot = wijsbot;
            this.midtop = midtop;
            this.midmid = midmid;
            this.midbot = midbot;
            this.ringtop = ringtop;
            this.ringmid = ringmid;
            this.ringbot = ringbot;
            this.pinktop = pinktop;
            this.pinkmid = pinkmid;
            this.pinkbot = pinkbot;
            
        }
    }
}
