namespace Bai07
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
            this.lbScreen = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.btnChair1 = new System.Windows.Forms.Button();
            this.btnChair13 = new System.Windows.Forms.Button();
            this.btnChair8 = new System.Windows.Forms.Button();
            this.btnChair14 = new System.Windows.Forms.Button();
            this.btnChair9 = new System.Windows.Forms.Button();
            this.btnChair15 = new System.Windows.Forms.Button();
            this.btnChair10 = new System.Windows.Forms.Button();
            this.btnChair12 = new System.Windows.Forms.Button();
            this.btnChair7 = new System.Windows.Forms.Button();
            this.btnChair11 = new System.Windows.Forms.Button();
            this.btnChair6 = new System.Windows.Forms.Button();
            this.btnChair5 = new System.Windows.Forms.Button();
            this.btnChair4 = new System.Windows.Forms.Button();
            this.btnChair3 = new System.Windows.Forms.Button();
            this.btnChair2 = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSeats.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbScreen
            // 
            this.lbScreen.AutoSize = true;
            this.lbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbScreen.Location = new System.Drawing.Point(186, 8);
            this.lbScreen.Name = "lbScreen";
            this.lbScreen.Size = new System.Drawing.Size(155, 33);
            this.lbScreen.TabIndex = 0;
            this.lbScreen.Text = "MÀN ẢNH";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(106, 318);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(75, 16);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Thành tiền: ";
            // 
            // txbTotal
            // 
            this.txbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTotal.Location = new System.Drawing.Point(256, 312);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(143, 22);
            this.txbTotal.TabIndex = 2;
            this.txbTotal.Text = "0";
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChair1
            // 
            this.btnChair1.BackColor = System.Drawing.Color.White;
            this.btnChair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair1.Location = new System.Drawing.Point(12, 13);
            this.btnChair1.Name = "btnChair1";
            this.btnChair1.Size = new System.Drawing.Size(56, 52);
            this.btnChair1.TabIndex = 3;
            this.btnChair1.Tag = "A";
            this.btnChair1.Text = "1";
            this.btnChair1.UseVisualStyleBackColor = false;
            this.btnChair1.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair13
            // 
            this.btnChair13.BackColor = System.Drawing.Color.White;
            this.btnChair13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair13.Location = new System.Drawing.Point(136, 129);
            this.btnChair13.Name = "btnChair13";
            this.btnChair13.Size = new System.Drawing.Size(56, 52);
            this.btnChair13.TabIndex = 4;
            this.btnChair13.Tag = "C";
            this.btnChair13.Text = "13";
            this.btnChair13.UseVisualStyleBackColor = true;
            this.btnChair13.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair8
            // 
            this.btnChair8.BackColor = System.Drawing.Color.White;
            this.btnChair8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair8.Location = new System.Drawing.Point(136, 71);
            this.btnChair8.Name = "btnChair8";
            this.btnChair8.Size = new System.Drawing.Size(56, 52);
            this.btnChair8.TabIndex = 5;
            this.btnChair8.Tag = "B";
            this.btnChair8.Text = "8";
            this.btnChair8.UseVisualStyleBackColor = true;
            this.btnChair8.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair14
            // 
            this.btnChair14.BackColor = System.Drawing.Color.White;
            this.btnChair14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair14.Location = new System.Drawing.Point(198, 129);
            this.btnChair14.Name = "btnChair14";
            this.btnChair14.Size = new System.Drawing.Size(56, 52);
            this.btnChair14.TabIndex = 6;
            this.btnChair14.Tag = "C";
            this.btnChair14.Text = "14";
            this.btnChair14.UseVisualStyleBackColor = true;
            this.btnChair14.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair9
            // 
            this.btnChair9.BackColor = System.Drawing.Color.White;
            this.btnChair9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair9.Location = new System.Drawing.Point(198, 71);
            this.btnChair9.Name = "btnChair9";
            this.btnChair9.Size = new System.Drawing.Size(56, 52);
            this.btnChair9.TabIndex = 7;
            this.btnChair9.Tag = "B";
            this.btnChair9.Text = "9";
            this.btnChair9.UseVisualStyleBackColor = true;
            this.btnChair9.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair15
            // 
            this.btnChair15.BackColor = System.Drawing.Color.White;
            this.btnChair15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair15.Location = new System.Drawing.Point(261, 129);
            this.btnChair15.Name = "btnChair15";
            this.btnChair15.Size = new System.Drawing.Size(56, 52);
            this.btnChair15.TabIndex = 8;
            this.btnChair15.Tag = "C";
            this.btnChair15.Text = "15";
            this.btnChair15.UseVisualStyleBackColor = true;
            this.btnChair15.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair10
            // 
            this.btnChair10.BackColor = System.Drawing.Color.White;
            this.btnChair10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair10.Location = new System.Drawing.Point(260, 71);
            this.btnChair10.Name = "btnChair10";
            this.btnChair10.Size = new System.Drawing.Size(56, 52);
            this.btnChair10.TabIndex = 9;
            this.btnChair10.Tag = "B";
            this.btnChair10.Text = "10";
            this.btnChair10.UseVisualStyleBackColor = true;
            this.btnChair10.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair12
            // 
            this.btnChair12.BackColor = System.Drawing.Color.White;
            this.btnChair12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair12.Location = new System.Drawing.Point(74, 129);
            this.btnChair12.Name = "btnChair12";
            this.btnChair12.Size = new System.Drawing.Size(56, 52);
            this.btnChair12.TabIndex = 10;
            this.btnChair12.Tag = "C";
            this.btnChair12.Text = "12";
            this.btnChair12.UseVisualStyleBackColor = true;
            this.btnChair12.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair7
            // 
            this.btnChair7.BackColor = System.Drawing.Color.White;
            this.btnChair7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair7.Location = new System.Drawing.Point(74, 71);
            this.btnChair7.Name = "btnChair7";
            this.btnChair7.Size = new System.Drawing.Size(56, 52);
            this.btnChair7.TabIndex = 11;
            this.btnChair7.Tag = "B";
            this.btnChair7.Text = "7";
            this.btnChair7.UseVisualStyleBackColor = true;
            this.btnChair7.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair11
            // 
            this.btnChair11.BackColor = System.Drawing.Color.White;
            this.btnChair11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair11.Location = new System.Drawing.Point(12, 129);
            this.btnChair11.Name = "btnChair11";
            this.btnChair11.Size = new System.Drawing.Size(56, 52);
            this.btnChair11.TabIndex = 12;
            this.btnChair11.Tag = "C";
            this.btnChair11.Text = "11";
            this.btnChair11.UseVisualStyleBackColor = true;
            this.btnChair11.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair6
            // 
            this.btnChair6.BackColor = System.Drawing.Color.White;
            this.btnChair6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair6.Location = new System.Drawing.Point(12, 71);
            this.btnChair6.Name = "btnChair6";
            this.btnChair6.Size = new System.Drawing.Size(56, 52);
            this.btnChair6.TabIndex = 13;
            this.btnChair6.Tag = "B";
            this.btnChair6.Text = "6";
            this.btnChair6.UseVisualStyleBackColor = true;
            this.btnChair6.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair5
            // 
            this.btnChair5.BackColor = System.Drawing.Color.White;
            this.btnChair5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair5.Location = new System.Drawing.Point(260, 13);
            this.btnChair5.Name = "btnChair5";
            this.btnChair5.Size = new System.Drawing.Size(56, 52);
            this.btnChair5.TabIndex = 14;
            this.btnChair5.Tag = "A";
            this.btnChair5.Text = "5";
            this.btnChair5.UseVisualStyleBackColor = true;
            this.btnChair5.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair4
            // 
            this.btnChair4.BackColor = System.Drawing.Color.White;
            this.btnChair4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair4.Location = new System.Drawing.Point(198, 13);
            this.btnChair4.Name = "btnChair4";
            this.btnChair4.Size = new System.Drawing.Size(56, 52);
            this.btnChair4.TabIndex = 15;
            this.btnChair4.Tag = "A";
            this.btnChair4.Text = "4";
            this.btnChair4.UseVisualStyleBackColor = true;
            this.btnChair4.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair3
            // 
            this.btnChair3.BackColor = System.Drawing.Color.White;
            this.btnChair3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair3.Location = new System.Drawing.Point(136, 13);
            this.btnChair3.Name = "btnChair3";
            this.btnChair3.Size = new System.Drawing.Size(56, 52);
            this.btnChair3.TabIndex = 16;
            this.btnChair3.Tag = "A";
            this.btnChair3.Text = "3";
            this.btnChair3.UseVisualStyleBackColor = true;
            this.btnChair3.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChair2
            // 
            this.btnChair2.BackColor = System.Drawing.Color.White;
            this.btnChair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair2.Location = new System.Drawing.Point(74, 13);
            this.btnChair2.Name = "btnChair2";
            this.btnChair2.Size = new System.Drawing.Size(56, 52);
            this.btnChair2.TabIndex = 17;
            this.btnChair2.Tag = "A";
            this.btnChair2.Text = "2";
            this.btnChair2.UseVisualStyleBackColor = false;
            this.btnChair2.Click += new System.EventHandler(this.PickChair_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(109, 385);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(86, 31);
            this.btnChoose.TabIndex = 18;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(220, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(327, 385);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(86, 31);
            this.btnFinish.TabIndex = 20;
            this.btnFinish.Text = "Kết thúc";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panelSeats
            // 
            this.panelSeats.Controls.Add(this.btnChair9);
            this.panelSeats.Controls.Add(this.btnChair1);
            this.panelSeats.Controls.Add(this.btnChair13);
            this.panelSeats.Controls.Add(this.btnChair8);
            this.panelSeats.Controls.Add(this.btnChair2);
            this.panelSeats.Controls.Add(this.btnChair14);
            this.panelSeats.Controls.Add(this.btnChair3);
            this.panelSeats.Controls.Add(this.btnChair15);
            this.panelSeats.Controls.Add(this.btnChair4);
            this.panelSeats.Controls.Add(this.btnChair10);
            this.panelSeats.Controls.Add(this.btnChair5);
            this.panelSeats.Controls.Add(this.btnChair12);
            this.panelSeats.Controls.Add(this.btnChair6);
            this.panelSeats.Controls.Add(this.btnChair7);
            this.panelSeats.Controls.Add(this.btnChair11);
            this.panelSeats.Location = new System.Drawing.Point(109, 83);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(330, 194);
            this.panelSeats.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbScreen);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 57);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lbTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSeats.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScreen;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btnChair1;
        private System.Windows.Forms.Button btnChair13;
        private System.Windows.Forms.Button btnChair8;
        private System.Windows.Forms.Button btnChair14;
        private System.Windows.Forms.Button btnChair9;
        private System.Windows.Forms.Button btnChair15;
        private System.Windows.Forms.Button btnChair10;
        private System.Windows.Forms.Button btnChair12;
        private System.Windows.Forms.Button btnChair7;
        private System.Windows.Forms.Button btnChair11;
        private System.Windows.Forms.Button btnChair6;
        private System.Windows.Forms.Button btnChair5;
        private System.Windows.Forms.Button btnChair4;
        private System.Windows.Forms.Button btnChair3;
        private System.Windows.Forms.Button btnChair2;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Panel panel1;
    }
}

