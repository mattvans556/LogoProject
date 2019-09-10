using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.DarkBlue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 74, FontStyle.Bold);
            Font drawFont = new Font("Arial", 14, FontStyle.Bold);
            drawPen.Color = Color.Black;
            drawBrush.Color = Color.DarkBlue;
            drawPen.Color = Color.FromArgb(150, 150, 0, 0);
            drawBrush.Color = Color.FromArgb(160, 255, 0, 0);
            //Clear the screen
            g.Clear(Color.Black);

            //code for drawing all my shapes to screen


            g.DrawLine(drawPen, 0, 0, 250, 250);
            // code for all my text
            g.DrawString("ans", drawFont, drawBrush, 265, 150);
            g.DrawString("V", drawFont, drawBrush, 200, 150);
            g.DrawString("Off The Wall", drawFont, drawBrush, 50, 300);

        }
    }
}
