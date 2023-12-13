using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai25
{
    public partial class Form1 : Form
    {
        private int x = 30;
        private int y = 100;
        private int ballSpeedX = 5;
        private int ballSpeedY = 5;
        private int ballSize = 30;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Red, x, y, 30, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += ballSpeedX;
            y += ballSpeedY;

            if (x > this.ClientSize.Width - ballSize || x < 0)
            {
                ballSpeedX = -ballSpeedX;
            }

            if (y > this.ClientSize.Height - ballSize || y < 0)
            {
                ballSpeedY = -ballSpeedY;
            }

            this.Invalidate();
        }
    }
}
