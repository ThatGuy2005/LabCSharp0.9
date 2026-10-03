using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp0._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 333;
            timer.Tick += (s, e) =>
            {
                
                this.Invalidate();
            };
            this.Paint += DrawRandomShapes;
            timer.Start();
            
        }

        private void DrawRandomShapes(object sender, PaintEventArgs e)
        {
            Random rand = new Random();
            
            if (rand.Next() % 2 == 0)
            {
                // Draw a random rectangle
                int x = rand.Next(0, this.pictureBox1.Width);
                int y = rand.Next(0, this.pictureBox1.Height);
                int width = rand.Next(100, 300);
                int height = rand.Next(100, 300);
                e.Graphics.FillRectangle(Brushes.Plum , x, y, width, height);
            }
            else
            {
                // Draw a random ellipse
                int x = rand.Next(0, this.pictureBox1.Width);
                int y = rand.Next(0, this.pictureBox1.Height);
                int width = rand.Next(100, 300);
                int height = rand.Next(100, 300);
                e.Graphics.FillEllipse(Brushes.Red, x, y, width, height);
            }
        }
    }
}
