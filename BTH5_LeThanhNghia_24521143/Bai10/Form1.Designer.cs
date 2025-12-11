namespace Bai10
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
            this.lbDashStyle = new System.Windows.Forms.Label();
            this.cbDashStyle = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.cbLineJoin = new System.Windows.Forms.ComboBox();
            this.lbLineJoin = new System.Windows.Forms.Label();
            this.cbDashCap = new System.Windows.Forms.ComboBox();
            this.lbDashCap = new System.Windows.Forms.Label();
            this.cbStartCap = new System.Windows.Forms.ComboBox();
            this.lbStartCap = new System.Windows.Forms.Label();
            this.cbEndCap = new System.Windows.Forms.ComboBox();
            this.lbEndCap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDashStyle
            // 
            this.lbDashStyle.AutoSize = true;
            this.lbDashStyle.Location = new System.Drawing.Point(21, 24);
            this.lbDashStyle.Name = "lbDashStyle";
            this.lbDashStyle.Size = new System.Drawing.Size(75, 16);
            this.lbDashStyle.TabIndex = 0;
            this.lbDashStyle.Text = "Dash Style:";
            // 
            // cbDashStyle
            // 
            this.cbDashStyle.FormattingEnabled = true;
            this.cbDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.cbDashStyle.Location = new System.Drawing.Point(102, 21);
            this.cbDashStyle.Name = "cbDashStyle";
            this.cbDashStyle.Size = new System.Drawing.Size(157, 24);
            this.cbDashStyle.TabIndex = 1;
            this.cbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbDashStyle_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(281, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(429, 387);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // cbWidth
            // 
            this.cbWidth.FormattingEnabled = true;
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
            this.cbWidth.Location = new System.Drawing.Point(102, 72);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(157, 24);
            this.cbWidth.TabIndex = 4;
            this.cbWidth.SelectedIndexChanged += new System.EventHandler(this.cbWidth_SelectedIndexChanged);
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(21, 75);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(44, 16);
            this.lbWidth.TabIndex = 3;
            this.lbWidth.Text = "Width:";
            // 
            // cbLineJoin
            // 
            this.cbLineJoin.FormattingEnabled = true;
            this.cbLineJoin.Items.AddRange(new object[] {
            "Miter",
            "Bevel",
            "Round",
            "MiterClipped"});
            this.cbLineJoin.Location = new System.Drawing.Point(102, 124);
            this.cbLineJoin.Name = "cbLineJoin";
            this.cbLineJoin.Size = new System.Drawing.Size(157, 24);
            this.cbLineJoin.TabIndex = 6;
            this.cbLineJoin.SelectedIndexChanged += new System.EventHandler(this.cbLineJoin_SelectedIndexChanged);
            // 
            // lbLineJoin
            // 
            this.lbLineJoin.AutoSize = true;
            this.lbLineJoin.Location = new System.Drawing.Point(21, 127);
            this.lbLineJoin.Name = "lbLineJoin";
            this.lbLineJoin.Size = new System.Drawing.Size(63, 16);
            this.lbLineJoin.TabIndex = 5;
            this.lbLineJoin.Text = "Line Join:";
            // 
            // cbDashCap
            // 
            this.cbDashCap.FormattingEnabled = true;
            this.cbDashCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Triangle"});
            this.cbDashCap.Location = new System.Drawing.Point(102, 176);
            this.cbDashCap.Name = "cbDashCap";
            this.cbDashCap.Size = new System.Drawing.Size(157, 24);
            this.cbDashCap.TabIndex = 8;
            this.cbDashCap.SelectedIndexChanged += new System.EventHandler(this.cbDashCap_SelectedIndexChanged);
            // 
            // lbDashCap
            // 
            this.lbDashCap.AutoSize = true;
            this.lbDashCap.Location = new System.Drawing.Point(21, 179);
            this.lbDashCap.Name = "lbDashCap";
            this.lbDashCap.Size = new System.Drawing.Size(70, 16);
            this.lbDashCap.TabIndex = 7;
            this.lbDashCap.Text = "Dash Cap:";
            // 
            // cbStartCap
            // 
            this.cbStartCap.FormattingEnabled = true;
            this.cbStartCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Square",
            "Triangle",
            "ArrowAnchor",
            "RoundAnchor",
            "DiamondAnchor"});
            this.cbStartCap.Location = new System.Drawing.Point(102, 228);
            this.cbStartCap.Name = "cbStartCap";
            this.cbStartCap.Size = new System.Drawing.Size(157, 24);
            this.cbStartCap.TabIndex = 10;
            this.cbStartCap.SelectedIndexChanged += new System.EventHandler(this.cbStartCap_SelectedIndexChanged);
            // 
            // lbStartCap
            // 
            this.lbStartCap.AutoSize = true;
            this.lbStartCap.Location = new System.Drawing.Point(21, 231);
            this.lbStartCap.Name = "lbStartCap";
            this.lbStartCap.Size = new System.Drawing.Size(65, 16);
            this.lbStartCap.TabIndex = 9;
            this.lbStartCap.Text = "Start Cap:";
            // 
            // cbEndCap
            // 
            this.cbEndCap.FormattingEnabled = true;
            this.cbEndCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Square",
            "Triangle",
            "ArrowAnchor",
            "RoundAnchor",
            "DiamondAnchor"});
            this.cbEndCap.Location = new System.Drawing.Point(102, 282);
            this.cbEndCap.Name = "cbEndCap";
            this.cbEndCap.Size = new System.Drawing.Size(157, 24);
            this.cbEndCap.TabIndex = 12;
            this.cbEndCap.SelectedIndexChanged += new System.EventHandler(this.cbEndCap_SelectedIndexChanged);
            // 
            // lbEndCap
            // 
            this.lbEndCap.AutoSize = true;
            this.lbEndCap.Location = new System.Drawing.Point(21, 285);
            this.lbEndCap.Name = "lbEndCap";
            this.lbEndCap.Size = new System.Drawing.Size(62, 16);
            this.lbEndCap.TabIndex = 11;
            this.lbEndCap.Text = "End Cap:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 390);
            this.Controls.Add(this.cbEndCap);
            this.Controls.Add(this.lbEndCap);
            this.Controls.Add(this.cbStartCap);
            this.Controls.Add(this.lbStartCap);
            this.Controls.Add(this.cbDashCap);
            this.Controls.Add(this.lbDashCap);
            this.Controls.Add(this.cbLineJoin);
            this.Controls.Add(this.lbLineJoin);
            this.Controls.Add(this.cbWidth);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cbDashStyle);
            this.Controls.Add(this.lbDashStyle);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDashStyle;
        private System.Windows.Forms.ComboBox cbDashStyle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.ComboBox cbLineJoin;
        private System.Windows.Forms.Label lbLineJoin;
        private System.Windows.Forms.ComboBox cbDashCap;
        private System.Windows.Forms.Label lbDashCap;
        private System.Windows.Forms.ComboBox cbStartCap;
        private System.Windows.Forms.Label lbStartCap;
        private System.Windows.Forms.ComboBox cbEndCap;
        private System.Windows.Forms.Label lbEndCap;
    }
}

