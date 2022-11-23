using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace AAUProject.Forms.Welcompage.WelcompageAdmin
{
    public partial class CreateCourseForm : Form
    {
        public CreateCourseForm()
        {
            InitializeComponent();
        }
        private void CreateCourseForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                AvailabilitycomboBox.Items.Add(i.ToString());
            }
        }

        private void CreateCourseBTN_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainForm.mysqlconnection);
            String sqlStatement = "INSERT INTO users.course(course_id, course_name, course_avalability, course_active) VALUES(@courseid, @coursename, @courseavalability, @courseactive);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@courseid", CourseIdtxt.Text);
            command.Parameters.AddWithValue("@coursename", Coursenametxt.Text);
            command.Parameters.AddWithValue("@courseavalability", AvailabilitycomboBox.Text);
            command.Parameters.AddWithValue("@courseactive", ActivitycomboBox.Text);         
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course Created");
            command.Dispose();
            connection.Close();
            this.Hide();
        }
    }
}
