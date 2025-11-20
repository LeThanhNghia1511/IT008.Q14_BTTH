using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Child : Form
    {
        Form1 parent;
        public Child(Form1 form1)
        {
            InitializeComponent();
            parent = form1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parent.list.Items.Add("Child Form Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            parent.list.Items.Add("Child Form Shown");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            parent.list.Items.Add("Child Form Activated");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            parent.list.Items.Add("Child Form Deactivate");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.list.Items.Add("Child Form Closing");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.list.Items.Add("Child Form Closed");
        }
    }
}
