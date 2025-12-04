using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public BindingList<Student> studentsList = new BindingList<Student>();
        private BindingSource studentBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentsList;
            dgvStudent.DataSource = studentBindingSource;
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();

            if (addStudent.ShowDialog() == DialogResult.OK)
            {
                Student student = addStudent.NewStudent;

                student.Stt = studentsList.Count + 1;
                studentsList.Add(student);
                studentBindingSource.ResetBindings(false);
            }
        }

        private void btnMenuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchStudentByName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                studentBindingSource.DataSource = studentsList;
            }
            else
            {
                var filteredList = studentsList.Where(s => s.StudentName.ToLower().Contains(searchText)).ToList();
                studentBindingSource.DataSource = new BindingList<Student>(filteredList);
            }
            studentBindingSource.ResetBindings(false);
        }
    }

    public class Student
    {
        public int Stt { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Faculty { get; set; }
        public float Gpa { get; set; }
    }
}