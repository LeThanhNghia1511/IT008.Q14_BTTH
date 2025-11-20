using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Random rand = new Random();
            Graphics g = e.Graphics;
            int x = rand.Next(0, this.ClientSize.Width - 20);
            int y = rand.Next(0, this.ClientSize.Height - 20);

            SolidBrush brush = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            g.DrawString("Paint Event", new Font(this.Font.FontFamily, rand.Next(15, 41)), brush, x, y);
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
