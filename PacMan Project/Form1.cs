using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//Ethan Elliott Februrary 15th
namespace PacMan_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
   
        private void button1_Click(object sender, EventArgs e)
        {
            //creating graphics objects
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 20);
            Pen pacmanPen = new Pen(Color.Yellow, 10);
            //draw pacman
            g.DrawPie(pacmanPen, 10, 35, 50, 50, 30, 300);
            //figure out animation on monday
            //g.DrawEllipse(pacmanPen, 10, 35, 50, 50);

            //drawing course for pacman
            g.DrawLine(drawPen, 0, 20, 400, 20);
            g.DrawLine(drawPen, 0, 100, 320, 100);
            g.DrawLine(drawPen, 320, 100, 320, 300);
            g.DrawLine(drawPen, 400, 20, 400, 300);
           

        }
    }
}
