using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MysqlStudentCRUD
{
    public partial class FormStudent : Form
    {
        private readonly StudentInfo _parent;
        public FormStudent(StudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Clear()
        {
            txtName.Text = txtReg.Text = txtClass.Text = txtSection.Text = string.Empty;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is empty.");
                return;
            }
            if(txtReg.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student reg is empty.");
                return;
            }
            if(txtClass.Text.Trim().Length < 0)
            {
                MessageBox.Show("Student class is empty.");
                return;
            }
            if(txtSection.Text.Trim().Length < 0)
            {
                MessageBox.Show("Student section is empty.");
                return;
            }
            if(btnSave.Text == "Save")
            {
                Student std = new Student(txtName.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DBStudent.AddStudent(std);
                Clear();
            }
            _parent.Display();
        }
    }
}
