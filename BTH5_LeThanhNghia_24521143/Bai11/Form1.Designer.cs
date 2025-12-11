namespace Bai11
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbShape = new System.Windows.Forms.ToolStripComboBox();
            this.cbWidth = new System.Windows.Forms.ToolStripComboBox();
            this.btnColor = new System.Windows.Forms.ToolStripButton();
            this.cbBrushStyle = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbShape,
            this.cbWidth,
            this.btnColor,
            this.cbBrushStyle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbShape
            // 
            this.cbShape.Items.AddRange(new object[] {
            "Line",
            "Retangle",
            "Ellipse"});
            this.cbShape.Name = "cbShape";
            this.cbShape.Size = new System.Drawing.Size(120, 28);
            // 
            // cbWidth
            // 
            this.cbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(75, 28);
            this.cbWidth.SelectedIndexChanged += new System.EventHandler(this.cbWidth_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(29, 25);
            this.btnColor.Text = "Color Button";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cbBrushStyle
            // 
            this.cbBrushStyle.Items.AddRange(new object[] {
            "Solid Brush",
            "Hatch Brush",
            "Texture Brush",
            "Linear Gradient Brush"});
            this.cbBrushStyle.Name = "cbBrushStyle";
            this.cbBrushStyle.Size = new System.Drawing.Size(200, 28);
            this.cbBrushStyle.SelectedIndexChanged += new System.EventHandler(this.cbBrushStyle_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 419);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbShape;
        private System.Windows.Forms.ToolStripComboBox cbWidth;
        private System.Windows.Forms.ToolStripButton btnColor;
        private System.Windows.Forms.ToolStripComboBox cbBrushStyle;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

