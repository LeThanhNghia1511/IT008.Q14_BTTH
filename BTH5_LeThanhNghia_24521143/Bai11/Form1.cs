using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        ColorDialog colorDialog = new ColorDialog();
        Bitmap bitmap;
        Graphics bitmapGraphics;
        Pen pen = new Pen(Color.Red);
        Point lastPos;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.White);
            pictureBox.Image = bitmap;

            // Gan gia tri mac dinh cho cb
            if (cbShape.Items.Count > 0)
            {
                cbShape.SelectedIndex = 0;
            }
            btnColor.BackColor = Color.Red;
            if (cbWidth.Items.Count > 0)
            {
                cbWidth.SelectedIndex = 0; 
            }
            if (cbBrushStyle.Items.Count > 0)
            {
                cbBrushStyle.SelectedIndex = 0;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                pen.Color = colorDialog.Color;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = e.Location;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (cbShape.SelectedItem.ToString() == "Line")
            {
                if (e.Button == MouseButtons.Left)
                {
                    bitmapGraphics.DrawLine(pen, lastPos, e.Location);
                    lastPos = e.Location;
                    pictureBox.Refresh();
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (cbShape.SelectedItem.ToString() == "Retangle")
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = Math.Min(lastPos.X, e.X);
                    int y = Math.Min(lastPos.Y, e.Y);
                    int width = Math.Abs(e.X - lastPos.X);
                    int height = Math.Abs(e.Y - lastPos.Y);
                    bitmapGraphics.FillRectangle(pen.Brush, x, y, width, height);
                    pictureBox.Refresh();
                }
            }
            else if (cbShape.SelectedItem.ToString() == "Ellipse")
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = Math.Min(lastPos.X, e.X);
                    int y = Math.Min(lastPos.Y, e.Y);
                    int width = Math.Abs(e.X - lastPos.X);
                    int height = Math.Abs(e.Y - lastPos.Y);
                    bitmapGraphics.FillEllipse(pen.Brush, x, y, width, height);
                    pictureBox.Refresh();
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

        private void cbBrushStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrushStyle.SelectedIndex > -1)
            {
                if (cbBrushStyle.SelectedItem.ToString() == "Solid Brush")
                {
                    pen.Brush = new SolidBrush(pen.Color);
                }
                else if (cbBrushStyle.SelectedItem.ToString() == "Hatch Brush")
                {
                    pen.Brush = new System.Drawing.Drawing2D.HatchBrush(
                        System.Drawing.Drawing2D.HatchStyle.Horizontal,
                        Color.Blue,
                        Color.Green);
                }
                else if (cbBrushStyle.SelectedItem.ToString() == "Texture Brush")
                {
                    int textureSize = 16;
                    Bitmap textureBitmap = new Bitmap(textureSize, textureSize);
                    using (Graphics g = Graphics.FromImage(textureBitmap))
                    {
                        g.Clear(Color.LightGray);
                        SolidBrush dotBrush = new SolidBrush(Color.Black);
                        g.FillEllipse(dotBrush,
                                      textureSize / 4,
                                      textureSize / 4,
                                      textureSize / 2,
                                      textureSize / 2); // Vẽ hình tròn nhỏ ở giữa
                    }
                    pen.Brush = new TextureBrush(textureBitmap);
                }
                else if (cbBrushStyle.SelectedItem.ToString() == "Linear Gradient Brush")
                {
                    pen.Brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                        new Point(0, 0),
                        new Point(0, 10),
                        Color.Red,
                        Color.Green);
                }
            }
        }
    }
}
