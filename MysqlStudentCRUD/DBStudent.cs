using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MysqlStudentCRUD
{
    class DBStudent
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "Server=localhost;Database=student;Uid=root;Pwd=";

            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("MySqlException" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public void AddStudent(Student std)
        {
            string sql = "INSERT INTO STUDENT_TABLE VALUES (NULL, @StudentName, @StudentReg, @StudentClass, @StudentSection, NULL )";
        }
    }
}
