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

namespace WindowsFormsGraphicsPath
{
    public partial class Form1 : Form
    {
        GraphicsPath gp = new GraphicsPath();
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(Handle);
        }


        Graphics g;
        private void button1_Click(object sender, EventArgs e)
        {
            gp.AddLine(10, 10, 100, 100);
            gp.AddEllipse(10, 10, 100, 100);
            // g.DrawPath(new Pen(Color.Red), gp);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(Color.Red), gp);
        }
    }
}
