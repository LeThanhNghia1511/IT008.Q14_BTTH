using System;
using System.Data;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Length
        {
            public int index;
            public int[] array;

            public Length(int n = 0)
            {
                this.array = new int[n];
            }
        };
        Length length = new Length(100);

        bool isEqualButtonClicked = false;

        private void Number_Click(object sender, EventArgs e)
        {
            if (isEqualButtonClicked == true)
            {
                txbInput.Text = "";
            }
            isEqualButtonClicked = false;
            Button btn = (Button)sender;
            string inputNum = btn.Text;
            txbInput.Text += inputNum;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txbInput.Text += ".";
            isEqualButtonClicked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
            txbInput.Text += "+";
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
            txbInput.Text += "-";
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
            txbInput.Text += "*";
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
            txbInput.Text += "/";
            length.array[length.index] = txbInput.Text.Length;
            length.index++;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = true;
            txbInput.Text = txbInput.Text.Replace("%", "/100");
            try
            {
                var result = new DataTable().Compute(txbInput.Text, "");
                double roundedResult = Math.Round(Convert.ToDouble(result), 4);
                txbInput.Text = roundedResult.ToString();
                if (txbInput.Text == "NaN" ||  txbInput.Text == "∞")
                {
                    txbInput.Text = "";
                    // Cap nhat lai index
                    length.index = 0;
                    MessageBox.Show("Math Error!");
                }
            }
            catch
            {
                txbInput.Text = "";
                // Cap nhat lai index
                length.index = 0;
                MessageBox.Show("Input Error!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbInput.Text.Length > 0)
            {
                txbInput.Text = txbInput.Text.Remove(txbInput.Text.Length - 1);
                // Cap nhat lai length
                if (length.index > 0 && length.array[length.index] > length.array[length.index - 1])
                {
                    length.array[length.index]--;
                }
                else if (length.index > 0 && length.array[length.index] <= length.array[length.index - 1])
                {
                    length.index--;
                }
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e) // Clear the nearest number
        {
            isEqualButtonClicked = false;
            if (length.index == 0)
            {
                txbInput.Text = "";
            }
            else
            {
                txbInput.Text = txbInput.Text.Substring(0, length.array[length.index - 1]);
                length.index--;
            }
        }

        private void btnClear_Click(object sender, EventArgs e) // Clear all
        {
            isEqualButtonClicked = false;
            txbInput.Text = "";
            // Cap nhat lai length
            UpdateLength();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            btnEqual_Click(sender, e);
            double result = Math.Sqrt(double.Parse(txbInput.Text));
            result = Math.Round(result, 4);
            txbInput.Text = result.ToString();
            // Cap nhat lai length
            UpdateLength();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            try
            {
                btnEqual_Click(sender, e);
                double result = double.Parse(txbInput.Text);
                result = result / 100;
                txbInput.Text = result.ToString();
                UpdateLength();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập liệu!");
                txbInput.Text = "";
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            btnEqual_Click(sender, e);
            double result = 1/double.Parse(txbInput.Text);
            result = Math.Round(result, 4);
            txbInput.Text = result.ToString();
            // Cap nhat lai length
            UpdateLength();
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            isEqualButtonClicked = false;
            btnEqual_Click(sender, e);
            double result = double.Parse(txbInput.Text);
            result *= -1;
            txbInput.Text = result.ToString();
            // Cap nhat lai length
            UpdateLength();
        }

        double memoryNum = 0;
        private void btnMC_Click(object sender, EventArgs e) // Memory clear
        {
            isEqualButtonClicked = false;
            memoryNum = 0;
        }

        private void btnMR_Click(object sender, EventArgs e) // Memory recall
        {
            isEqualButtonClicked = false;
            txbInput.Text = memoryNum.ToString();
            length.index = 1;
            length.array[length.index] = txbInput.Text.Length;
            // Cap nhat lai length
            UpdateLength();
        }

        private void btnMS_Click(object sender, EventArgs e) // Memory save
        {
            isEqualButtonClicked = false;
            memoryNum = Convert.ToDouble(txbInput.Text);
        }

        private void btnMAdd_Click(object sender, EventArgs e) // M+: Memory add
        {
            isEqualButtonClicked = false;
            memoryNum += Convert.ToDouble(txbInput.Text);
        }

        private void UpdateLength()
        {
            if (txbInput.Text == "")
            {
                length.index = 0;
            }
            else
            {
                length.index = 1;
                if (double.Parse(txbInput.Text) < 0)
                {
                    length.array[length.index] = 2;
                }
                else
                {
                    length.array[length.index] = 1;
                }
            }
        }
    }
}
