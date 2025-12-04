namespace Bai05
{
    partial class AddStudent
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
            this.lbStudentID = new System.Windows.Forms.Label();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.lbGPA = new System.Windows.Forms.Label();
            this.txbStudentName = new System.Windows.Forms.TextBox();
            this.txbGPA = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(127, 63);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(160, 25);
            this.lbStudentID.TabIndex = 0;
            this.lbStudentID.Text = "Mã Số Sinh Viên";
            // 
            // txbStudentID
            // 
            this.txbStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStudentID.Location = new System.Drawing.Point(366, 66);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(239, 22);
            this.txbStudentID.TabIndex = 1;
            // 
            // cbFaculty
            // 
            this.cbFaculty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFaculty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFaculty.BackColor = System.Drawing.SystemColors.Control;
            this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "An toàn thông tin",
            "Công nghệ phần mềm",
            "Công nghệ thông tin",
            "Hệ thống thông tin",
            "Khoa học dữ liệu",
            "Khoa học máy tính",
            "Kỹ thuật máy tính"});
            this.cbFaculty.Location = new System.Drawing.Point(366, 182);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(331, 24);
            this.cbFaculty.Sorted = true;
            this.cbFaculty.TabIndex = 2;
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.Location = new System.Drawing.Point(127, 120);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(136, 25);
            this.lbStudentName.TabIndex = 3;
            this.lbStudentName.Text = "Tên Sinh Viên";
            // 
            // lbFaculty
            // 
            this.lbFaculty.AutoSize = true;
            this.lbFaculty.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaculty.Location = new System.Drawing.Point(127, 181);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(58, 25);
            this.lbFaculty.TabIndex = 4;
            this.lbFaculty.Text = "Khoa";
            // 
            // lbGPA
            // 
            this.lbGPA.AutoSize = true;
            this.lbGPA.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGPA.Location = new System.Drawing.Point(127, 237);
            this.lbGPA.Name = "lbGPA";
            this.lbGPA.Size = new System.Drawing.Size(94, 25);
            this.lbGPA.TabIndex = 5;
            this.lbGPA.Text = "Điểm TB";
            // 
            // txbStudentName
            // 
            this.txbStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStudentName.Location = new System.Drawing.Point(366, 123);
            this.txbStudentName.Name = "txbStudentName";
            this.txbStudentName.Size = new System.Drawing.Size(331, 22);
            this.txbStudentName.TabIndex = 6;
            // 
            // txbGPA
            // 
            this.txbGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGPA.Location = new System.Drawing.Point(366, 240);
            this.txbGPA.Name = "txbGPA";
            this.txbGPA.Size = new System.Drawing.Size(176, 22);
            this.txbGPA.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(441, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(618, 349);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(117, 42);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbGPA);
            this.Controls.Add(this.txbStudentName);
            this.Controls.Add(this.lbGPA);
            this.Controls.Add(this.lbFaculty);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.txbStudentID);
            this.Controls.Add(this.lbStudentID);
            this.Name = "AddStudent";
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.Label lbGPA;
        private System.Windows.Forms.TextBox txbStudentName;
        private System.Windows.Forms.TextBox txbGPA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuit;
    }
}