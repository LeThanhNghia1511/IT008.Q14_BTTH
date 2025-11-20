using System;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        ColorDialog colorDialog = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
            colorDialog.FullOpen = true;
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }
    }
}
