using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint, true);
            this.UpdateStyles();
            DrawDial(); // Vẽ mặt đồng hồ khi khởi động
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlClock.Invalidate(); // Yêu cầu vẽ lại pnlClock
        }

        private void pnlClock_Paint(object sender, PaintEventArgs e)
        {
            DateTime now = DateTime.Now;

            int centerX = pnlClock.Width / 2;
            int centerY = pnlClock.Height / 2;
            int radius = (int)(Math.Min(centerX, centerY) * 0.9);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // -- Vẽ kim đồng hồ dựa vào thời gian hiện tại -- 
            // Vẽ kim giờ
            GraphicsState hourState = g.Save();
            float hourAngle = (now.Hour % 12 * 30) + (now.Minute * 0.5f) - 90;
            DrawWire(g, centerX, centerY, hourAngle, (int)(radius * 0.7), 18, Pens.White, true);
            g.Restore(hourState);

            //Vẽ kim phút
            GraphicsState minState = g.Save();
            float minAngle = (now.Minute * 6) + (now.Second * 0.1f) - 90;
            DrawWire(g, centerX, centerY, minAngle, (int)(radius * 0.8), 8, Pens.White, true);
            g.Restore(minState);

            // Vẽ kim giây
            GraphicsState secState = g.Save();
            float secAngle = (now.Second * 6) - 90;
            DrawWire(g, centerX, centerY, secAngle, (int)(radius * 0.8), 1, Pens.White, false);
            g.Restore(secState);

            g.ResetTransform(); // Reset
        }

        // Vẽ khung thời gian của đồng hồ
        private void DrawDial()
        {
            // Kích thước
            int width = pnlClock.Width;
            int height = pnlClock.Height;
            int centerX = width / 2;
            int centerY = height / 2;
            int radius = (int)(Math.Min(centerX, centerY) * 0.9);

            // Tạo đối tượng Bitmap (Canvas)
            Bitmap dialBitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(dialBitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Thiết lập nền đen cho Bitmap
            g.Clear(Color.Black);

            // Các Pen và Brush cần thiết
            Pen whitePen = new Pen(Color.White, 1);
            Brush dotBrush = Brushes.White;
            int dotSizeHour = 20;
            int dotSizeMinute = 7;

            for (int i = 0; i < 60; i++)
            {
                double angle = (i * 6) - 90;
                double rad = Math.PI * angle / 180; // Doi sang Radian

                int x = centerX + (int)(radius * Math.Cos(rad));
                int y = centerY + (int)(radius * Math.Sin(rad));

                if (i % 5 == 0) // Dấu chấm giờ
                {
                    g.FillEllipse(dotBrush, x - dotSizeHour / 2, y - dotSizeHour / 2, dotSizeHour, dotSizeHour);
                }
                else // Dấu chấm phút
                {
                    g.FillEllipse(dotBrush, x - dotSizeMinute / 2, y - dotSizeMinute / 2, dotSizeMinute, dotSizeMinute);
                }
            }

            g.Dispose();

            if (pnlClock.BackgroundImage != null)
            {
                pnlClock.BackgroundImage.Dispose();
            }
            pnlClock.BackgroundImage = dialBitmap;
        }

        // Vẽ kim đồng hồ
        private void DrawWire(Graphics g, int cx, int cy, float angle, int length, int width, Pen pen, bool isRhombus)
        {
            // Lưu lại trạng thái gốc của Graphics
            g.TranslateTransform(cx, cy); // Dịch chuyển tâm (0,0) về tâm đồng hồ
            g.RotateTransform(angle);     // Xoay hệ tọa độ theo góc quay

            Pen customPen = new Pen(pen.Color, 1);

            if (isRhombus)
            {
                Point[] rhombusPoints = new Point[]
                {
                    new Point(0, -width),               // Đỉnh trên
                    new Point(length, 0),                   // Đỉnh ngoài (Đầu kim)
                    new Point(0, width),                // Đỉnh dưới
                    new Point(- (int)(length * 0.2), 0)     // Đỉnh trong (Phần đối trọng, 20% chiều dài)
                };

                g.DrawPolygon(customPen, rhombusPoints);

            }
            else // Vẽ kim giây (đường thẳng)
            {
                g.DrawLine(customPen, 0, 0, length, 0);
            }

            customPen.Dispose();
        }
    }
}
