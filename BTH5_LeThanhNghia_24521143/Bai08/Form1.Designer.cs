namespace Bai08
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
            this.pnlClock = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlClock
            // 
            this.pnlClock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlClock.Location = new System.Drawing.Point(-2, 0);
            this.pnlClock.Name = "pnlClock";
            this.pnlClock.Size = new System.Drawing.Size(571, 525);
            this.pnlClock.TabIndex = 0;
            this.pnlClock.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClock_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 523);
            this.Controls.Add(this.pnlClock);
            this.Name = "Form1";
            this.Text = "Analog Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClock;
        private System.Windows.Forms.Timer timer1;
    }
}

