namespace Bai04
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
            this.lbFont = new System.Windows.Forms.Label();
            this.grAlignText = new System.Windows.Forms.GroupBox();
            this.rbtnRight = new System.Windows.Forms.RadioButton();
            this.rbtnLeft = new System.Windows.Forms.RadioButton();
            this.rbtnCenter = new System.Windows.Forms.RadioButton();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.chbItalic = new System.Windows.Forms.CheckBox();
            this.chbUnderline = new System.Windows.Forms.CheckBox();
            this.grAlignText.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFont.Location = new System.Drawing.Point(49, 31);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(63, 29);
            this.lbFont.TabIndex = 0;
            this.lbFont.Text = "Font";
            // 
            // grAlignText
            // 
            this.grAlignText.Controls.Add(this.rbtnRight);
            this.grAlignText.Controls.Add(this.rbtnLeft);
            this.grAlignText.Controls.Add(this.rbtnCenter);
            this.grAlignText.Location = new System.Drawing.Point(54, 167);
            this.grAlignText.Name = "grAlignText";
            this.grAlignText.Size = new System.Drawing.Size(200, 100);
            this.grAlignText.TabIndex = 1;
            this.grAlignText.TabStop = false;
            this.grAlignText.Text = "Align Text";
            // 
            // rbtnRight
            // 
            this.rbtnRight.AutoSize = true;
            this.rbtnRight.Location = new System.Drawing.Point(16, 73);
            this.rbtnRight.Name = "rbtnRight";
            this.rbtnRight.Size = new System.Drawing.Size(59, 20);
            this.rbtnRight.TabIndex = 13;
            this.rbtnRight.TabStop = true;
            this.rbtnRight.Text = "Right";
            this.rbtnRight.UseVisualStyleBackColor = true;
            this.rbtnRight.CheckedChanged += new System.EventHandler(this.rbtnRight_CheckedChanged);
            // 
            // rbtnLeft
            // 
            this.rbtnLeft.AutoSize = true;
            this.rbtnLeft.Location = new System.Drawing.Point(16, 21);
            this.rbtnLeft.Name = "rbtnLeft";
            this.rbtnLeft.Size = new System.Drawing.Size(49, 20);
            this.rbtnLeft.TabIndex = 3;
            this.rbtnLeft.TabStop = true;
            this.rbtnLeft.Text = "Left";
            this.rbtnLeft.UseVisualStyleBackColor = true;
            this.rbtnLeft.CheckedChanged += new System.EventHandler(this.rbtnLeft_CheckedChanged);
            // 
            // rbtnCenter
            // 
            this.rbtnCenter.AutoSize = true;
            this.rbtnCenter.Location = new System.Drawing.Point(16, 47);
            this.rbtnCenter.Name = "rbtnCenter";
            this.rbtnCenter.Size = new System.Drawing.Size(67, 20);
            this.rbtnCenter.TabIndex = 12;
            this.rbtnCenter.TabStop = true;
            this.rbtnCenter.Text = "Center";
            this.rbtnCenter.UseVisualStyleBackColor = true;
            this.rbtnCenter.CheckedChanged += new System.EventHandler(this.rbtnCenter_CheckedChanged);
            // 
            // chbBold
            // 
            this.chbBold.AutoSize = true;
            this.chbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBold.Location = new System.Drawing.Point(54, 105);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(53, 33);
            this.chbBold.TabIndex = 2;
            this.chbBold.Text = "B";
            this.chbBold.UseVisualStyleBackColor = true;
            this.chbBold.CheckedChanged += new System.EventHandler(this.chbBold_CheckedChanged);
            // 
            // cbFont
            // 
            this.cbFont.BackColor = System.Drawing.SystemColors.Menu;
            this.cbFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(118, 36);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(167, 23);
            this.cbFont.TabIndex = 4;
            this.cbFont.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFont_DrawItem);
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(415, 82);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(40, 34);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(307, 184);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(210, 76);
            this.rtbText.TabIndex = 6;
            this.rtbText.Text = "";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(336, 87);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(73, 29);
            this.lbColor.TabIndex = 10;
            this.lbColor.Text = "Color";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(351, 36);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(63, 29);
            this.lbSize.TabIndex = 11;
            this.lbSize.Text = "Size";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cbSize.Location = new System.Drawing.Point(415, 36);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(77, 24);
            this.cbSize.TabIndex = 12;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // chbItalic
            // 
            this.chbItalic.AutoSize = true;
            this.chbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbItalic.Location = new System.Drawing.Point(113, 105);
            this.chbItalic.Name = "chbItalic";
            this.chbItalic.Size = new System.Drawing.Size(41, 33);
            this.chbItalic.TabIndex = 13;
            this.chbItalic.Text = "I";
            this.chbItalic.UseVisualStyleBackColor = true;
            this.chbItalic.CheckedChanged += new System.EventHandler(this.chbItalic_CheckedChanged);
            // 
            // chbUnderline
            // 
            this.chbUnderline.AutoSize = true;
            this.chbUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUnderline.Location = new System.Drawing.Point(160, 105);
            this.chbUnderline.Name = "chbUnderline";
            this.chbUnderline.Size = new System.Drawing.Size(53, 33);
            this.chbUnderline.TabIndex = 14;
            this.chbUnderline.Text = "U";
            this.chbUnderline.UseVisualStyleBackColor = true;
            this.chbUnderline.CheckedChanged += new System.EventHandler(this.chbUnderline_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 316);
            this.Controls.Add(this.chbUnderline);
            this.Controls.Add(this.chbItalic);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbFont);
            this.Controls.Add(this.chbBold);
            this.Controls.Add(this.grAlignText);
            this.Controls.Add(this.lbFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grAlignText.ResumeLayout(false);
            this.grAlignText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFont;
        private System.Windows.Forms.GroupBox grAlignText;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.RadioButton rbtnLeft;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.RadioButton rbtnCenter;
        private System.Windows.Forms.RadioButton rbtnRight;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.CheckBox chbItalic;
        private System.Windows.Forms.CheckBox chbUnderline;
    }
}

