using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        public Student NewStudent { get; private set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentID = txbStudentID.Text.Trim();
            string studentName = txbStudentName.Text.Trim();
            string faculty = cbFaculty.SelectedItem?.ToString() ?? string.Empty;
            float gpa = 0;

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên", "Thiếu dữ liệu");
                return;
            }
            else if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thiếu dữ liệu");
                return;
            }
            else if (string.IsNullOrEmpty(faculty))
            {
                MessageBox.Show("Vui lòng chọn khoa", "Thiếu dữ liệu");
                return;
            }

            if (!float.TryParse(txbGPA.Text, out gpa))
            {
                MessageBox.Show("Vui lòng nhập điểm đúng định dạng (số)", "Lỗi");
                return;
            }

            if (gpa > 4)
            {
                gpa = 4;
            }
            else if (gpa < 0)
            {
                gpa = 0;
            }

            Student newStudent = new Student()
            {
                StudentId = studentID,
                StudentName = studentName,
                Faculty = faculty,
                Gpa = gpa
            };

            this.NewStudent = newStudent;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}