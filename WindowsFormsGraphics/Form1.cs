using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cnt = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = (++cnt).ToString();

            Pen myPen = new Pen(Color.Red, 5);
            e.Graphics.DrawLine(myPen, new Point(0, 0), new Point(100, 100));
            e.Graphics.DrawEllipse(myPen, new RectangleF(0, 0, 100, 100));
            e.Graphics.FillRectangle(myPen.Brush, new RectangleF(0, 0, 50, 50));

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
            new Point(0, 10),
            new Point(200, 10),
            Color.FromArgb(255, 255, 0, 0),   // Opaque red
            Color.FromArgb(255, 0, 0, 255));  // Opaque blue

            e.Graphics.FillEllipse(linGrBrush, new RectangleF(110, 20, 200, 200));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
