using System;
using System.Drawing;
using System.Windows.Forms;
namespace lr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillEllipse(Brushes.White, 150, 50, 100, 100);
            g.FillEllipse(Brushes.White, 140, 140, 120, 120);
            g.FillEllipse(Brushes.White, 133, 240, 140, 140);

            Point[] nose = {
                new Point(190, 100), 
                new Point(210, 100),
                new Point(200, 130)
            };

            g.FillPolygon(Brushes.Orange, nose);
            g.FillEllipse(Brushes.Black, 210, 80, 10, 10);
            g.FillEllipse(Brushes.Black, 180, 80, 10, 10);

            Point[] hat = {
                new Point(175, 15),
                new Point(155, 75),
                new Point(245, 75),
                new Point(225, 15)
            };

            g.FillPolygon(Brushes.Red, hat);

            Pen pen = new Pen(Color.Black, 1);
            g.DrawPolygon(pen, hat);
            g.DrawEllipse(Pens.Black, 197, 180, 10, 10);
            g.DrawEllipse(Pens.Black, 197, 230, 10, 10);
            g.DrawEllipse(Pens.Black, 197, 280, 10, 10);

            Point[] br = {
                new Point(320, 100),
                new Point(320, 370)
            };

            Pen pen1 = new Pen(Color.Black, 5);

            g.DrawPolygon(pen1, br);

            Point[] h1 = {
                new Point(260, 200),
                new Point(320, 150)
            };

            Pen pen2 = new Pen(Color.Black, 5);

            g.DrawPolygon(pen2, h1);

            Point[] h2 = {
                new Point(80, 150),
                new Point(140, 200)
            };

            Pen pen3 = new Pen(Color.Black, 5);

            g.DrawPolygon(pen3, h2);

            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(0, 500);
                int y = random.Next(0, 400);
                g.FillEllipse(Brushes.White, x, y, 10, 10);
            }
        }
    }
}