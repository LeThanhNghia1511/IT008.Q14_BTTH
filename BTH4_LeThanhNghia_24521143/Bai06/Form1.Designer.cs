namespace Bai06
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.txbDest = new System.Windows.Forms.TextBox();
            this.lbDestPath = new System.Windows.Forms.Label();
            this.lbSourcePath = new System.Windows.Forms.Label();
            this.txbSource = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(661, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.btnBrowseDest);
            this.groupBox1.Controls.Add(this.btnBrowseSource);
            this.groupBox1.Controls.Add(this.txbDest);
            this.groupBox1.Controls.Add(this.lbDestPath);
            this.groupBox1.Controls.Add(this.lbSourcePath);
            this.groupBox1.Controls.Add(this.txbSource);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(33, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBrowseDest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDest.ForeColor = System.Drawing.Color.Blue;
            this.btnBrowseDest.Location = new System.Drawing.Point(609, 109);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(52, 33);
            this.btnBrowseDest.TabIndex = 5;
            this.btnBrowseDest.Text = "...";
            this.btnBrowseDest.UseVisualStyleBackColor = false;
            this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBrowseSource.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSource.ForeColor = System.Drawing.Color.Blue;
            this.btnBrowseSource.Location = new System.Drawing.Point(609, 49);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(52, 33);
            this.btnBrowseSource.TabIndex = 4;
            this.btnBrowseSource.Text = "...";
            this.btnBrowseSource.UseVisualStyleBackColor = false;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // txbDest
            // 
            this.txbDest.AllowDrop = true;
            this.txbDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDest.Location = new System.Drawing.Point(262, 114);
            this.txbDest.Name = "txbDest";
            this.txbDest.Size = new System.Drawing.Size(316, 22);
            this.txbDest.TabIndex = 3;
            // 
            // lbDestPath
            // 
            this.lbDestPath.AutoSize = true;
            this.lbDestPath.ForeColor = System.Drawing.Color.Black;
            this.lbDestPath.Location = new System.Drawing.Point(74, 120);
            this.lbDestPath.Name = "lbDestPath";
            this.lbDestPath.Size = new System.Drawing.Size(148, 16);
            this.lbDestPath.TabIndex = 2;
            this.lbDestPath.Text = "Đường dẫn thư mục đích";
            // 
            // lbSourcePath
            // 
            this.lbSourcePath.AutoSize = true;
            this.lbSourcePath.ForeColor = System.Drawing.Color.Black;
            this.lbSourcePath.Location = new System.Drawing.Point(74, 61);
            this.lbSourcePath.Name = "lbSourcePath";
            this.lbSourcePath.Size = new System.Drawing.Size(160, 16);
            this.lbSourcePath.TabIndex = 1;
            this.lbSourcePath.Text = "Đường dẫn thư mục nguồn";
            // 
            // txbSource
            // 
            this.txbSource.AllowDrop = true;
            this.txbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSource.Location = new System.Drawing.Point(262, 55);
            this.txbSource.Name = "txbSource";
            this.txbSource.Size = new System.Drawing.Size(316, 22);
            this.txbSource.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(33, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(262, 180);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(154, 32);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Sao Chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 425);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(104, 16);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Đang sao chép: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sao chép tập tin";
            this.toolTip1.SetToolTip(this, "Đang sao chép: ");
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbDest;
        private System.Windows.Forms.Label lbDestPath;
        private System.Windows.Forms.Label lbSourcePath;
        private System.Windows.Forms.TextBox txbSource;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnBrowseDest;
        private System.Windows.Forms.Button btnCopy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbStatus;
    }
}

