using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Items.Add("Form Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            list.Items.Add("Form Shown");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            list.Items.Add("Form Activated");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            list.Items.Add("Form Deactivate");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            list.Items.Add("Form Closing");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            list.Items.Add("Form Closed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child childForm = new Child(this);
            childForm.Show();
        }
    }
}
