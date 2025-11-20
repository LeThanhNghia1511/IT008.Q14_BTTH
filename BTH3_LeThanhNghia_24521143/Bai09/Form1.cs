using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiem tra xem thong tin co duoc nhap day du ko
            if (string.IsNullOrWhiteSpace(txbID.Text) || string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            string gender = "";
            if (chkbMale.Checked)
            {
                gender = "Nam";
            }
            else if (chkbFemale.Checked)
            {
                gender = "Nữ";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 giới tính");
                return;
            }

            string mssv = txbID.Text;
            string hoTen = txbName.Text;
            string chuyenNganh = cbMajor.SelectedItem.ToString();
            int soMonDangKy = lsbAvailableSub.Items.Count;

            
            int rowIndex = FindStudentRow(mssv);

            if (rowIndex != -1) // Tim thay sv -> Cập nhật thông tin
            {
                
                dgvStudent.Rows[rowIndex].Cells["HoTen"].Value = hoTen;
                dgvStudent.Rows[rowIndex].Cells["ChuyenNganh"].Value = chuyenNganh;
                dgvStudent.Rows[rowIndex].Cells["GioiTinh"].Value = gender;
                dgvStudent.Rows[rowIndex].Cells["SoMon"].Value = soMonDangKy;
                MessageBox.Show($"Đã cập nhật thông tin sinh viên {hoTen}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Khong tìm thấy sv -> Thêm mới sv
            {
                
                dgvStudent.Rows.Add(mssv, hoTen, chuyenNganh, gender, soMonDangKy);
                MessageBox.Show($"Đã thêm mới sinh viên");
            }

            ResetForm();
        }

        // Ham tim thong tin sinh vien xem da ton tai hay chua, dua vao MSSV
        private int FindStudentRow(string mssv)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells["studentID"].Value != null && row.Cells["studentID"].Value.ToString() == mssv)
                {
                    // Tim thay sv voi mssv truyen vao
                    return row.Index;
                }
            }
            return -1; // Khong tim thay
        }

        private void ResetForm()
        {
            txbID.Clear();
            txbName.Clear();
            cbMajor.SelectedIndex = 0;
            chkbMale.Checked = false;
            chkbFemale.Checked = false;

            if (lsbSelectedSub.Items.Count > 0)
            {
                lsbAvailableSub.Items.AddRange(lsbSelectedSub.Items.Cast<object>().ToArray());
                lsbSelectedSub.Items.Clear();
            }

            lsbAvailableSub.ClearSelected();
            lsbSelectedSub.ClearSelected();
            txbID.Focus();
        }

        private void btnMoveToRight_Click(object sender, EventArgs e)
        {
            List<string> itemsToMove = new List<string>();
            foreach (var item in lsbAvailableSub.SelectedItems)
            {
                itemsToMove.Add(item.ToString());
            }

            // Chuyen mon hoc sang ben phai
            foreach (var item in itemsToMove)
            {
                lsbSelectedSub.Items.Add(item);
                lsbAvailableSub.Items.Remove(item);
            }
        }

        private void btnMoveToLeft_Click(object sender, EventArgs e)
        {
            List<string> itemsToMove = new List<string>();
            foreach (var item in lsbSelectedSub.SelectedItems)
            {
                itemsToMove.Add(item.ToString());
            }

            // Chuyen mon sang ben trai
            foreach (var item in itemsToMove)
            {
                lsbAvailableSub.Items.Add(item);
                lsbSelectedSub.Items.Remove(item);
            }
        }

        private void chkbMale_CheckedChanged(object sender, EventArgs e)
        {
            chkbFemale.Checked = false;          
        }

        private void chkbFemale_CheckedChanged(object sender, EventArgs e)
        {
            chkbMale.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sinh viên đang chọn khỏi danh sách không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    for (int i = dgvStudent.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        int rowIndex = dgvStudent.SelectedRows[i].Index;
                        dgvStudent.Rows.RemoveAt(rowIndex);
                    }
                    MessageBox.Show("Đã xóa thông tin sinh viên thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}