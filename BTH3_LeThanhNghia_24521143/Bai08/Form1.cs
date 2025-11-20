using System;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long lBalance = 0; // lBalance (Tổng số tiền)

        // SỬA LẠI: btnAdd_Click dùng ListView
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbAccNum.ReadOnly = false;
            // Kiểm tra xem thông tin có được nhập đầy đủ hay không
            if (string.IsNullOrWhiteSpace(txbAccNum.Text) ||
                string.IsNullOrWhiteSpace(txbName.Text) ||
                string.IsNullOrWhiteSpace(txbAddress.Text) ||
                string.IsNullOrWhiteSpace(txbBalance.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Thử chuyển đổi số dư để kiểm tra dữ liệu hợp lệ
            if (!long.TryParse(txbBalance.Text, out long newBalanceValue))
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập số.");
                return;
            }

            // Lấy thông tin từ txb
            string accNum = txbAccNum.Text;
            string name = txbName.Text;
            string address = txbAddress.Text;
            string balance = txbBalance.Text;

            // Tìm tài khoản
            int resultIndex = IsAccExist(accNum);

            if (resultIndex != -1) // Acc đã tồn tại thì cập nhật lại thông tin
            {
                // Cập nhật lại total
                long oldBalanceValue = long.Parse(lvAccount.Items[resultIndex].SubItems[4].Text);
                lBalance = lBalance - oldBalanceValue + newBalanceValue;

                // Cập nhật SubItems cho Item đã tồn tại
                lvAccount.Items[resultIndex].SubItems[2].Text = name;    // Tên khách hàng
                lvAccount.Items[resultIndex].SubItems[3].Text = address; // Địa chỉ
                lvAccount.Items[resultIndex].SubItems[4].Text = balance; // Số tiền

                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
            else // Acc chưa tồn tại thì thêm mới
            {
                // STT sẽ là số lượng Item hiện tại + 1
                string stt = (lvAccount.Items.Count + 1).ToString();

                // Tạo một ListViewItem mới. Giá trị đầu tiên (stt) là Item chính
                ListViewItem newItem = new ListViewItem(stt);

                newItem.SubItems.Add(accNum);  // Cột 1: Mã tài khoản
                newItem.SubItems.Add(name);    // Cột 2: Tên khách hàng
                newItem.SubItems.Add(address); // Cột 3: Địa chỉ
                newItem.SubItems.Add(balance); // Cột 4: Số tiền

                // Thêm Item vào ListView
                lvAccount.Items.Add(newItem);

                // Cập nhật tổng số dư
                lBalance += newBalanceValue;

                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }

            // Cập nhật tổng tiền vào total
            txbTotal.Text = lBalance.ToString("N0");

            // Xóa thông tin trong txb sau khi thêm vào lv
            txbAccNum.Clear();
            txbName.Clear();
            txbAddress.Clear();
            txbBalance.Clear();
        }

        private int IsAccExist(string accNum)
        {
            // Duyệt qua tất cả các item trong lv
            for (int i = 0; i < lvAccount.Items.Count; i++)
            {
                if (lvAccount.Items[i].SubItems[1].Text == accNum)
                {
                    return i; // Trả về index của hàng nếu tìm thấy
                }
            }
            return -1;
        }

        // SỬA LẠI: btnDelete_Click dùng ListView
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count > 0) // Kiểm tra SelectedItems (hàng được chọn)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa các tài khoản đã chọn không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    for (int i = lvAccount.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem itemToRemove = lvAccount.SelectedItems[i];

                        // Cập nhật lại tổng tiền sau khi xóa
                        long oldBalanceValue = long.Parse(itemToRemove.SubItems[4].Text);
                        lBalance -= oldBalanceValue;
                        lvAccount.Items.Remove(itemToRemove);
                    }

                    // Cập nhật lại STT sau khi xóa
                    UpdateSTT();

                    // Cập nhật tổng tiền sau khi xóa
                    txbTotal.Text = lBalance.ToString("N0");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!");
            }
        }

        //Hàm cập nhật STT
        private void UpdateSTT()
        {
            for (int i = 0; i < lvAccount.Items.Count; i++)
            {
                lvAccount.Items[i].Text = (i + 1).ToString();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count > 0)
            {
                ListViewItem item = lvAccount.SelectedItems[0];

                txbAccNum.Text = item.SubItems[1].Text;
                txbName.Text = item.SubItems[2].Text;
                txbAddress.Text = item.SubItems[3].Text;
                txbBalance.Text = item.SubItems[4].Text;
                txbAccNum.ReadOnly = true;
            }
            else
            {
                txbAccNum.Clear();
                txbName.Clear();
                txbAddress.Clear();
                txbBalance.Clear();
                txbAccNum.ReadOnly = false;
            }
        }
    }
}