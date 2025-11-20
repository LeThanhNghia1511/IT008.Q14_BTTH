namespace Bai05
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.txbAnswer = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(138, 60);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(65, 16);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Number 1";
            // 
            // txbNum1
            // 
            this.txbNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNum1.Location = new System.Drawing.Point(241, 54);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(172, 22);
            this.txbNum1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(133, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbNum2
            // 
            this.txbNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNum2.Location = new System.Drawing.Point(241, 103);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(172, 22);
            this.txbNum2.TabIndex = 3;
            // 
            // txbAnswer
            // 
            this.txbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAnswer.Location = new System.Drawing.Point(216, 257);
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.ReadOnly = true;
            this.txbAnswer.Size = new System.Drawing.Size(172, 22);
            this.txbAnswer.TabIndex = 4;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(138, 109);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(65, 16);
            this.lblNum2.TabIndex = 5;
            this.lblNum2.Text = "Number 2";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(134, 263);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(51, 16);
            this.lbAnswer.TabIndex = 6;
            this.lbAnswer.Text = "Answer";
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(206, 166);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(67, 45);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevide.Location = new System.Drawing.Point(352, 166);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(67, 45);
            this.btnDevide.TabIndex = 8;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(279, 166);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(67, 45);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 350);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txbAnswer);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.TextBox txbAnswer;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnMultiply;
    }
}

