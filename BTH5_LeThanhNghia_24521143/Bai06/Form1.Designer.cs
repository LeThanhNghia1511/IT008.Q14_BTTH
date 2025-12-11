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
            this.lsbFontFamily = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbFontFamily
            // 
            this.lsbFontFamily.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lsbFontFamily.FormattingEnabled = true;
            this.lsbFontFamily.Location = new System.Drawing.Point(23, 12);
            this.lsbFontFamily.Name = "lsbFontFamily";
            this.lsbFontFamily.Size = new System.Drawing.Size(445, 537);
            this.lsbFontFamily.TabIndex = 0;
            this.lsbFontFamily.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsbFontFamily_DrawItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 589);
            this.Controls.Add(this.lsbFontFamily);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFontFamily;
    }
}

