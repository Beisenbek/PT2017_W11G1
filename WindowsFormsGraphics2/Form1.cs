using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraphics2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle);
        }

        Graphics g;
        float x1;
        float y1;
        float x2;
        float y2;

        private void button1_Click(object sender, EventArgs e)
        {
             x1 = float.Parse(textBox1.Text);
             y1 = float.Parse(textBox2.Text);
             x2 = float.Parse(textBox3.Text);
             y2 = float.Parse(textBox4.Text);

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            g.DrawLine(new Pen(Color.Red), x1, y1, x2, y2);
        }
    }
}
