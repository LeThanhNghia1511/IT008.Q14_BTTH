using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txbNum1.Text);
                float num2 = float.Parse(txbNum2.Text);

                float result = num1 + num2;
                txbAnswer.Text = result.ToString();
            }
            catch
            {
                txbAnswer.Text = "NAN";
                MessageBox.Show("Error");
            }
        }


        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txbNum1.Text);
                float num2 = float.Parse(txbNum2.Text);

                float result = num1 - num2;
                txbAnswer.Text = result.ToString();
            }
            catch
            {
                txbAnswer.Text = "NAN";
                MessageBox.Show("Error");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txbNum1.Text);
                float num2 = float.Parse(txbNum2.Text);

                float result = num1 * num2;
                txbAnswer.Text = result.ToString();
            }
            catch
            {
                txbAnswer.Text = "NAN";
                MessageBox.Show("Error");
            }
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txbNum1.Text);
                float num2 = float.Parse(txbNum2.Text);

                if (num2 == 0)
                {
                    txbAnswer.Text = "--";
                    MessageBox.Show("Number 1 cant be devided by 0");
                }
                else
                {
                    float result = num1 / num2;
                    txbAnswer.Text = result.ToString();
                }

            }
            catch
            {
                txbAnswer.Text = "NAN";
                MessageBox.Show("Error");
            }
        }
    }
}
