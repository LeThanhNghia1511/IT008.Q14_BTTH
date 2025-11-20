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
            this.lbTitle = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAccNum = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txbAccNum = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbBalance = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lvAccount = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(4, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(709, 48);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTotal.Location = new System.Drawing.Point(555, 533);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(211, 22);
            this.txbTotal.TabIndex = 1;
            this.txbTotal.Text = "0";
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(321, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm/Cập nhật";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAccNum
            // 
            this.lbAccNum.AutoSize = true;
            this.lbAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccNum.Location = new System.Drawing.Point(137, 95);
            this.lbAccNum.Name = "lbAccNum";
            this.lbAccNum.Size = new System.Drawing.Size(91, 18);
            this.lbAccNum.TabIndex = 4;
            this.lbAccNum.Text = "Số tài khoản";
            this.lbAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(115, 126);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(113, 18);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Tên khách hàng";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(95, 157);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(133, 18);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Địa chỉ khách hàng";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(72, 187);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(156, 18);
            this.lbBalance.TabIndex = 7;
            this.lbBalance.Text = "Số tiền trong tài khoản";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(457, 535);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(83, 20);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Tổng tiền:";
            // 
            // txbAccNum
            // 
            this.txbAccNum.Location = new System.Drawing.Point(246, 89);
            this.txbAccNum.Name = "txbAccNum";
            this.txbAccNum.Size = new System.Drawing.Size(440, 22);
            this.txbAccNum.TabIndex = 9;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(246, 122);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(440, 22);
            this.txbName.TabIndex = 10;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(246, 153);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(440, 22);
            this.txbAddress.TabIndex = 11;
            // 
            // txbBalance
            // 
            this.txbBalance.Location = new System.Drawing.Point(246, 183);
            this.txbBalance.Name = "txbBalance";
            this.txbBalance.Size = new System.Drawing.Size(440, 22);
            this.txbBalance.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(481, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(600, 230);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 30);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lvAccount
            // 
            this.lvAccount.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvAccount.AllowDrop = true;
            this.lvAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.AccNum,
            this.ClientName,
            this.Address,
            this.Balance});
            this.lvAccount.FullRowSelect = true;
            this.lvAccount.GridLines = true;
            this.lvAccount.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAccount.HideSelection = false;
            this.lvAccount.Location = new System.Drawing.Point(12, 282);
            this.lvAccount.Name = "lvAccount";
            this.lvAccount.Size = new System.Drawing.Size(754, 233);
            this.lvAccount.TabIndex = 15;
            this.lvAccount.UseCompatibleStateImageBehavior = false;
            this.lvAccount.View = System.Windows.Forms.View.Details;
            this.lvAccount.SelectedIndexChanged += new System.EventHandler(this.lvAccount_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 45;
            // 
            // AccNum
            // 
            this.AccNum.Text = "Mã tài khoản";
            this.AccNum.Width = 110;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Tên khách hàng";
            this.ClientName.Width = 160;
            // 
            // Address
            // 
            this.Address.Text = "Địa chỉ";
            this.Address.Width = 160;
            // 
            // Balance
            // 
            this.Balance.Text = "Số tiền";
            this.Balance.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 566);
            this.Controls.Add(this.lvAccount);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbBalance);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbAccNum);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAccNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbAccNum;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txbAccNum;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbBalance;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListView lvAccount;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader AccNum;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Balance;
    }
}

