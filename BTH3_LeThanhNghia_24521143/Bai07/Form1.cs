using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PickChair_Click(object sender, EventArgs e)
        {
            var chair = sender as Button;
            if (chair.BackColor ==  Color.White)
            {
                chair.BackColor = Color.Blue;
            }
            else if (chair.BackColor == Color.Blue)
            {
                chair.BackColor = Color.White;
            }
            else if (chair.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được chọn. Vui lòng chọn lại!");
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            long total = 0;
            foreach (Control chair in panelSeats.Controls)
            {
                string tag = chair.Tag as string;
                if (chair.BackColor == Color.Blue)
                {
                    chair.BackColor = Color.Yellow;
                    if (tag == "A")
                    {
                        total += 5000;
                    }
                    else if (tag == "B")
                    {
                        total += 6500;
                    }
                    else if (tag == "C")
                    {
                        total += 8000;
                    }
                }
            }
            txbTotal.Text = total.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control chair in panelSeats.Controls)
            {
                if (chair.BackColor == Color.Blue)
                {
                    chair.BackColor = Color.White;
                }
            }
            txbTotal.Text = "0";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
