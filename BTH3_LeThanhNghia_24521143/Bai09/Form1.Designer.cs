namespace Bai09
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMoveToLeft = new System.Windows.Forms.Button();
            this.btnMoveToRight = new System.Windows.Forms.Button();
            this.lsbSelectedSub = new System.Windows.Forms.ListBox();
            this.lsbAvailableSub = new System.Windows.Forms.ListBox();
            this.chkbFemale = new System.Windows.Forms.CheckBox();
            this.chkbMale = new System.Windows.Forms.CheckBox();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbPickSubject = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnMoveToLeft);
            this.groupBox1.Controls.Add(this.btnMoveToRight);
            this.groupBox1.Controls.Add(this.lsbSelectedSub);
            this.groupBox1.Controls.Add(this.lsbAvailableSub);
            this.groupBox1.Controls.Add(this.chkbFemale);
            this.groupBox1.Controls.Add(this.chkbMale);
            this.groupBox1.Controls.Add(this.cbMajor);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.txbID);
            this.groupBox1.Controls.Add(this.lbPickSubject);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.lbMajor);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(418, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa chọn";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(287, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Lưu thông tin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMoveToLeft
            // 
            this.btnMoveToLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMoveToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToLeft.Location = new System.Drawing.Point(393, 249);
            this.btnMoveToLeft.Name = "btnMoveToLeft";
            this.btnMoveToLeft.Size = new System.Drawing.Size(45, 36);
            this.btnMoveToLeft.TabIndex = 13;
            this.btnMoveToLeft.Text = "<";
            this.btnMoveToLeft.UseVisualStyleBackColor = false;
            this.btnMoveToLeft.Click += new System.EventHandler(this.btnMoveToLeft_Click);
            // 
            // btnMoveToRight
            // 
            this.btnMoveToRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMoveToRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToRight.Location = new System.Drawing.Point(393, 207);
            this.btnMoveToRight.Name = "btnMoveToRight";
            this.btnMoveToRight.Size = new System.Drawing.Size(45, 36);
            this.btnMoveToRight.TabIndex = 12;
            this.btnMoveToRight.Text = ">";
            this.btnMoveToRight.UseVisualStyleBackColor = false;
            this.btnMoveToRight.Click += new System.EventHandler(this.btnMoveToRight_Click);
            // 
            // lsbSelectedSub
            // 
            this.lsbSelectedSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbSelectedSub.FormattingEnabled = true;
            this.lsbSelectedSub.ItemHeight = 16;
            this.lsbSelectedSub.Location = new System.Drawing.Point(464, 197);
            this.lsbSelectedSub.Name = "lsbSelectedSub";
            this.lsbSelectedSub.Size = new System.Drawing.Size(191, 96);
            this.lsbSelectedSub.TabIndex = 11;
            // 
            // lsbAvailableSub
            // 
            this.lsbAvailableSub.FormattingEnabled = true;
            this.lsbAvailableSub.ItemHeight = 16;
            this.lsbAvailableSub.Items.AddRange(new object[] {
            "Lập trình trực quan",
            "Cơ sở dữ liệu",
            "Xác suất thống kê",
            "Tư tưởng Hồ Chí Minh"});
            this.lsbAvailableSub.Location = new System.Drawing.Point(169, 197);
            this.lsbAvailableSub.Name = "lsbAvailableSub";
            this.lsbAvailableSub.Size = new System.Drawing.Size(191, 100);
            this.lsbAvailableSub.TabIndex = 10;
            // 
            // chkbFemale
            // 
            this.chkbFemale.AutoSize = true;
            this.chkbFemale.Location = new System.Drawing.Point(418, 123);
            this.chkbFemale.Name = "chkbFemale";
            this.chkbFemale.Size = new System.Drawing.Size(46, 20);
            this.chkbFemale.TabIndex = 9;
            this.chkbFemale.Text = "Nữ";
            this.chkbFemale.UseVisualStyleBackColor = true;
            this.chkbFemale.CheckedChanged += new System.EventHandler(this.chkbFemale_CheckedChanged);
            // 
            // chkbMale
            // 
            this.chkbMale.AutoSize = true;
            this.chkbMale.Location = new System.Drawing.Point(335, 123);
            this.chkbMale.Name = "chkbMale";
            this.chkbMale.Size = new System.Drawing.Size(58, 20);
            this.chkbMale.TabIndex = 8;
            this.chkbMale.Text = "Nam";
            this.chkbMale.UseVisualStyleBackColor = true;
            this.chkbMale.CheckedChanged += new System.EventHandler(this.chkbMale_CheckedChanged);
            // 
            // cbMajor
            // 
            this.cbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Items.AddRange(new object[] {
            "Kỹ thuật phần mềm",
            "Hệ thống thông tin",
            "An toàn thông tin",
            "Khoa học máy tính",
            "Kỹ thuật máy tính",
            "Khoa học dữ liệu"});
            this.cbMajor.Location = new System.Drawing.Point(335, 82);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(196, 24);
            this.cbMajor.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(335, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(196, 22);
            this.txbName.TabIndex = 6;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(335, 12);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(118, 22);
            this.txbID.TabIndex = 5;
            // 
            // lbPickSubject
            // 
            this.lbPickSubject.AutoSize = true;
            this.lbPickSubject.Location = new System.Drawing.Point(176, 165);
            this.lbPickSubject.Name = "lbPickSubject";
            this.lbPickSubject.Size = new System.Drawing.Size(184, 16);
            this.lbPickSubject.TabIndex = 4;
            this.lbPickSubject.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(176, 128);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 16);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "Giới Tính";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Location = new System.Drawing.Point(176, 90);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(95, 16);
            this.lbMajor.TabIndex = 2;
            this.lbMajor.Text = "Chuyên Ngành";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(176, 52);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Họ Tên";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(176, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(85, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã Sinh Viên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.StudentName,
            this.Major,
            this.Gender,
            this.NumOfSub});
            this.dgvStudent.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStudent.Location = new System.Drawing.Point(12, 374);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(776, 202);
            this.dgvStudent.TabIndex = 1;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "MSSV";
            this.studentID.MinimumWidth = 6;
            this.studentID.Name = "studentID";
            this.studentID.Width = 75;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Họ Tên";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 150;
            // 
            // Major
            // 
            this.Major.HeaderText = "Chuyên Ngành";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.Width = 150;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 90;
            // 
            // NumOfSub
            // 
            this.NumOfSub.HeaderText = "Số Môn";
            this.NumOfSub.MinimumWidth = 6;
            this.NumOfSub.Name = "NumOfSub";
            this.NumOfSub.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPickSubject;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.CheckBox chkbFemale;
        private System.Windows.Forms.CheckBox chkbMale;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMoveToLeft;
        private System.Windows.Forms.Button btnMoveToRight;
        private System.Windows.Forms.ListBox lsbSelectedSub;
        private System.Windows.Forms.ListBox lsbAvailableSub;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfSub;
    }
}

