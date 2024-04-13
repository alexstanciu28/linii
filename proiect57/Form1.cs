using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        int x1,y1,x2,y2;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random random = new Random();
            Random random1 = new Random();

            for (i = 1; i <= 1000; i++)
            {

                Color c = Color.FromArgb(random1.Next(256), random1.Next(256), random1.Next(256));
                Pen p = new Pen(c, 2);
                x1=random1.Next(this.Width);
                x2=random1.Next(this.Width);
                y1=random1.Next(this.Height);
                y2=random1.Next(this.Height);   
                g.DrawLine(p,x1,y1,x2,y2);

            }
        }
    }
}
