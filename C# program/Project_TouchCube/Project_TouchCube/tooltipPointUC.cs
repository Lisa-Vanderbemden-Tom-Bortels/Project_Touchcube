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
    /**
     * 
     * tooltipPointUC Class
     * Created by : Tom Bortels
     * This User control class is part of the CharUC class
     * It adds an interactive point in the graph
     * 
     * */


    public partial class tooltipPointUC : UserControl
    {
        //class properties and some default values
        Graphics graph;
        Pen pen1;
        SolidBrush brush1;
        Color color = Color.Red;
        
        //defines the size of the points
        private static int size = 8;
        private int xpos;
        private int ypos;

        string tooltiptext = "";

        #region "Control properties"
       
        public Pen Pen1
        {
            get { return pen1; }
            set { pen1 = value; }
        }
        

        public SolidBrush Brush1
        {
            get { return brush1; }
            set { brush1 = value; }
        }
        

        public int Size1
        {
            get { return size; }
            set { size = value; }
        }

        public int Xpos
        {
            get { return xpos; }
            set { xpos = value; }
        }

        public int Ypos
        {
            get { return ypos; }
            set { ypos = value; }
        }
        

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public string TooltipText
        {
            get { return tooltiptext; }
            set { tooltiptext = value; }
        }

        public Graphics Graph {
            get { return graph; }
            set { graph = value; }
        }

        #endregion

        public tooltipPointUC()
        {
            InitializeComponent();
            graph = this.CreateGraphics();

            //default pen 
            pen1 = new Pen(color);
        }

        public static int getPointSize() {
            return size;
        }
        private void tooltipPointUC_Load(object sender, EventArgs e)
        {
            
        }

        public void setPen(int size, Color color) {
            this.pen1 = new Pen(color);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g;
            g = Graph;

            pen1 = new Pen(Color);
            brush1 = new SolidBrush(Color);
            
            //sets the container size, +1 for the border when hovered
            this.Height = size+1;
            this.Width = size+1;
            
            this.Location = new Point(xpos,ypos);

            //draws the point, 0,0 is relative to the container, not the parent
            g.FillEllipse(brush1, 0, 0, size, size);
            
        }

        //add border to point when hover
        private void tooltipPointUC_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(tooltiptext, this);

            //add black border
            pen1.Color = Color.Black;
            graph.DrawEllipse(pen1, 0, 0, size, size);
            pen1.Color = color;
        }

        //remove border when leaving hover
        private void tooltipPointUC_MouseLeave(object sender, EventArgs e)
        {   
            //clear the graphic and redraw it without border
            graph.Clear(Color.White);
            graph.FillEllipse(brush1, 0, 0, size, size);
            toolTip.Hide(this);
        }

        //move already exists as an event handler, hence the Tmove name
        public void Tmove(int xmove, int ymove) {
            this.Left += xmove;
            this.Top += ymove;
        }

    }
}
