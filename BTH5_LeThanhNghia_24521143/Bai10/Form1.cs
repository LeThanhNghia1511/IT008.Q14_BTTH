using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics bitmapGraphics;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.White);
            pictureBox.Image = bitmap;
            pen = new Pen(Color.Red);
            float[] dashPattern = { 1f, 5f };
            pen.DashPattern = dashPattern;

            // Gan cac gia tri mac dinh cho cb
            if (cbDashStyle.Items.Count > 0)
                cbDashStyle.SelectedIndex = 0;
            if (cbWidth.Items.Count > 0)
                cbWidth.SelectedIndex = 0;
            if (cbLineJoin.Items.Count > 0)
                cbLineJoin.SelectedIndex = 0;
            if (cbDashCap.Items.Count > 0)
                cbDashCap.SelectedIndex = 0;
            if (cbStartCap.Items.Count > 0)
                cbStartCap.SelectedIndex = 0;
            if (cbEndCap.Items.Count > 0)
                cbEndCap.SelectedIndex = 0;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            bitmapGraphics.Clear(Color.White); // Reset lai bitmapGraphics moi lan ve

            // Ve duong thang
            Point p1 = new Point(30, 30);
            Point p2 = new Point(150, 150);
            bitmapGraphics.DrawLine(pen, p1, p2);

            // Ve duong gay khuc
            Point[] polyPoints = new Point[]
                {
                    new Point(30, 180),
                    new Point(150, 300), 
                    new Point(200, 180)
                };
            bitmapGraphics.DrawLines(pen, polyPoints);

            pictureBox.Refresh();
        }

        private void cbDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDashStyle.SelectedIndex > -1)
            {
                string selectedValue = cbDashStyle.SelectedItem.ToString();
                try
                {
                    pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)Enum.Parse(
                    typeof(System.Drawing.Drawing2D.DashStyle),
                    selectedValue);
                }
                catch
                {
                    // Bỏ qua lỗi nếu chuỗi không hợp lệ
                }
            }
        }

        private void cbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWidth.SelectedIndex > -1)
            {
                if (float.TryParse(cbWidth.SelectedItem.ToString(), out float width))
                {
                    pen.Width = width;
                }
            }
        }

        private void cbLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLineJoin.SelectedIndex > -1)
            {
                try
                {
                    pen.LineJoin = (System.Drawing.Drawing2D.LineJoin)Enum.Parse(
                    typeof(System.Drawing.Drawing2D.LineJoin),
                    cbLineJoin.SelectedItem.ToString());
                }
                catch
                {
                    // Bỏ qua lỗi nếu chuỗi không hợp lệ
                }
            }
        }

        private void cbDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDashCap.SelectedIndex > -1)
            {
                try
                {
                    pen.DashCap = (System.Drawing.Drawing2D.DashCap)Enum.Parse(
                    typeof(System.Drawing.Drawing2D.DashCap),
                    cbDashCap.SelectedItem.ToString());
                }
                catch
                {
                    // Bỏ qua lỗi nếu chuỗi không hợp lệ
                }
            }
        }

        private void cbStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStartCap.SelectedIndex > -1)
            {
                try
                {
                    pen.StartCap = (System.Drawing.Drawing2D.LineCap)Enum.Parse(
                    typeof(System.Drawing.Drawing2D.LineCap),
                    cbStartCap.SelectedItem.ToString());
                }
                catch
                {
                    // Bỏ qua lỗi nếu chuỗi không hợp lệ
                }
            }
        }

        private void cbEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEndCap.SelectedIndex > -1)
            {
                try
                {
                    pen.EndCap = (System.Drawing.Drawing2D.LineCap)Enum.Parse(
                    typeof(System.Drawing.Drawing2D.LineCap),
                    cbEndCap.SelectedItem.ToString());
                }
                catch
                {
                    // Bỏ qua lỗi nếu chuỗi không hợp lệ
                }
            }
        }
    }
}
