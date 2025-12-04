using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txbSource.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txbDest.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSource.Text) || string.IsNullOrEmpty(txbDest.Text))
            {
                MessageBox.Show("Vui lòng chọn đủ đường dẫn nguồn và đích.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vô hiệu hóa để tránh bấm 2 lần
            btnCopy.Enabled = false;

            var arguments = new { SourcePath = txbSource.Text, DestinationFolder = txbDest.Text };

            // Chạy tác vụ ở luồng nền
            backgroundWorker1.RunWorkerAsync(arguments);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            dynamic args = e.Argument;
            string sourcePath = args.SourcePath;
            string destinationFolder = args.DestinationFolder;

            // Tên tệp tin
            string fileName = Path.GetFileName(sourcePath);
            string destinationPath = Path.Combine(destinationFolder, fileName);

            CopyFileWithProgress(worker, sourcePath, destinationPath);
        }

        private void CopyFileWithProgress(BackgroundWorker worker, string source, string destination)
        {
            const int chunkSize = 1024 * 1024;
            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                long fileSize = sourceStream.Length;
                byte[] buffer = new byte[chunkSize];
                int bytesRead;
                long totalBytesCopied = 0;

                // Báo cáo tên tệp đang sao chép
                worker.ReportProgress(0, Path.GetFileName(source));

                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                    totalBytesCopied += bytesRead;

                    int percentProgress = (int)((double)totalBytesCopied / fileSize * 100);
                    worker.ReportProgress(percentProgress, Path.GetFileName(source));
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Cập nhật ProgressBar
            progressBar1.Value = e.ProgressPercentage;

            string fileName = e.UserState.ToString();

            // Cập nhật label
            lbStatus.Text = "Đang sao chép: " + fileName;
            string tooltipText = $"{fileName} ({e.ProgressPercentage}%)";
            toolTip1.SetToolTip(progressBar1, tooltipText);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Bật lại nút sao chép sau khi chạy xog
            btnCopy.Enabled = true;

            if (e.Error != null)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {e.Error.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sao chép tập tin hoàn tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
                lbStatus.Text = "Đang sao chép: ";
                toolTip1.SetToolTip(progressBar1, "Hoàn tất!");
            }
        }
    }
}
