using System;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            lbDateTime.Text = "Hôm nay là ngày: " + DateTime.Now.ToString("dd/MM/yyyy")
                            + " - Bây giờ là: " + DateTime.Now.ToString("HH:mm:ss:tt");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp Media";
            openFileDialog.Filter = "Tất cả tệp|*.*|AVI|*.avi|MPEG|*.mpeg|WAV|*.wav|MIDI|*.midi|MP4|*.mp4|MP3|*.mp3";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                axWindowsMediaPlayer1.URL = filePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = "Hôm nay là ngày: " + DateTime.Now.ToString("dd/MM/yyyy")
                            + " - Bây giờ là: " + DateTime.Now.ToString("HH:mm:ss:tt");
        }
    }
}
