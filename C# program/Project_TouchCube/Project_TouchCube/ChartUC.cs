using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_TouchCube
{
    public partial class ChartUC : UserControl
    {

        /**
         * 
         * ChartUC class
         * created by: Tom Bortels
         * handles the creation of the charts dynamically
         * code will be transparant to allow further use in future
         * 
         * */

        //configuration variables
        Connection conn;


        //margins for box surrounding graph
        private int vmargin = 30;
        private int hmargin = 30;
        private int maxpointsize = 255;
        private Pen pen1;


        Graphics graphobj;

        //points of the graph.
        private tooltipPointUC[,] vpunten = new tooltipPointUC[5,10];
        private int[,]  waarden = new int[5,10];
        private Color[] kleur = { Color.Red, Color.Blue, Color.Fuchsia, Color.Green, Color.Orange };
        

        #region "Control properties"
        
        public int Vmargin
        {
           get { return vmargin; }
                    set { vmargin = value; }
        }
        public int Hmargin
        {
            get { return hmargin; }
            set { hmargin = value; }
        }

        #endregion



        public ChartUC()
        {
            
            InitializeComponent();
        }

        private void ChartUC_Load(object sender, EventArgs e)
        {
            conn = new Connection();

            graphobj = this.CreateGraphics();
             pen1 = new Pen(Color.Black, 2);


            //draws the field containing the graph
            //always 2 times the offset for lower border
        }


        public void loadUC(int id) {
            conn = new Connection();
            List<measurement> metingen = conn.getHistory(id);

            for (int i = 0; i < metingen.Count; i++) {
                measurement meting = metingen.ElementAt(i);
                waarden[0,i] = Int32.Parse(meting.Wijstop);
                waarden[1,i] = Int32.Parse(meting.Midtop);
                waarden[2,i] = Int32.Parse(meting.Ringtop);
                waarden[3,i] = Int32.Parse(meting.Pinktop);
                waarden[4,i] = Int32.Parse(meting.Duimtop);
            }
            
      
        }


        private void ChartUC_Paint(object sender, PaintEventArgs e)
        {
            //drawing the border, has to be each paint since the points interfere otherwise, though it gives problems with the overview
            graphobj.DrawRectangle(pen1, hmargin, vmargin, getWidth() - 2 * hmargin, getHeight() - 2 * vmargin);
        }

                                        
     

     //mag later weg, test nu de beweging van de punten.
        public void drawgraph(int puntid)
        {
           

            int hoogte = this.Height;
            int breedte = this.Width;

            int pointsperfinger = vpunten.GetUpperBound(1) + 1;

         

            //clear the screen
            //clear lines
            graphobj.Clear(Color.White);
            //clear the points
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 10; j++) {
                    this.Controls.Remove(vpunten[i, j]);
                }
            }
  
            //initialising
            for (int i = 0; i < 10; i++)
            {
                vpunten[puntid, i] = new tooltipPointUC();
                //set the color according to the selected finger
                vpunten[puntid, i].Color = kleur[puntid];

                //variable to calculate distance between each point, considering size of points, window size and offset
                double distanceBetweenPoints = (double)(breedte - (pointsperfinger * tooltipPointUC.getPointSize()) - 2 * hmargin) / (pointsperfinger + 1);
                // MessageBox.Show(breedte.ToString()); //260
                //MessageBox.Show(distanceBetweenPoints.ToString()); //11 //hmargin : 30px, //pointsize: 8px
                vpunten[puntid, i].Xpos = hmargin + (int)Math.Round(distanceBetweenPoints) + (i * (tooltipPointUC.getPointSize() + (int)Math.Round(distanceBetweenPoints))) + 1; //plus one because the tooltippoints aren't drawn correctly in size

                //starts left top -> height -; hmargin +9 because border = 2 px in width, ucontrontrol = +-6px.
                //vpunten[puntid, i].Ypos = hoogte - (waarden[puntid, i] + hmargin + tooltipPointUC.getPointSize() + 2);
                //2*2 for the border!
                double scalevalues = ((hoogte - 2*(hmargin+2))/((double)maxpointsize+tooltipPointUC.getPointSize()+4));
                vpunten[puntid, i].Ypos = hoogte - (hmargin + (int)(scalevalues * waarden[puntid, i])+tooltipPointUC.getPointSize()+4); 
                vpunten[puntid, i].TooltipText = "punt " + i + " " + waarden[puntid, i];
                this.Controls.Add(vpunten[puntid, i]);
            }

            //drawing the connection lines between the points

                
            for (int i = 0; i <pointsperfinger - 1; i++)
            {
                //point drawing starts in top left, line should connect in center, not top left, so correction will be necessary
                //corrections depend on relative vs next point location
                graphobj.DrawLine(new Pen(kleur[puntid], (tooltipPointUC.getPointSize() / 2) - 1), vpunten[puntid,i].Xpos + (tooltipPointUC.getPointSize() / 2), vpunten[puntid,i].Ypos + (tooltipPointUC.getPointSize() / 2), vpunten[puntid,i + 1].Xpos + (tooltipPointUC.getPointSize() / 2), vpunten[puntid,i + 1].Ypos + (tooltipPointUC.getPointSize() / 2));
            }
           
        }

        private int getWidth()
        {
            return this.Width;
        }

        private int getHeight()
        {
            return this.Height;
        }


    }

}