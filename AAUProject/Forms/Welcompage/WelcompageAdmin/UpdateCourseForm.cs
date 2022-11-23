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
    public partial class UpdateCourseForm : Form
    {
        public UpdateCourseForm()
        {
            InitializeComponent();
        }
        string course_id;
        private void UpdateCourseForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainForm.mysqlconnection);
            String sqlStatement = "SELECT * FROM course";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                while (Reader.Read())
                {
                    CourseIDcomboBox.Items.Add(Reader.GetString("course_id"));
                }
            }
            for (int i = 1; i < 100; i++)
            {
                AvailabilitycomboBox.Items.Add(i.ToString());
            }
        }

        private void CourseIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainForm.mysqlconnection);
            String sqlStatement = "SELECT * FROM course WHERE course_id = @course_id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@course_id", CourseIDcomboBox.Text);
            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                while (Reader.Read())
                {
                    course_id = Reader.GetString("course_id");
                    Coursenametxt.Text = Reader.GetString("course_name");
                    AvailabilitycomboBox.Text = Reader.GetInt32("course_avalability").ToString();
                    ActivitycomboBox.Text = Reader.GetInt32("course_active").ToString();
                }
            }
        }

        private void UpdateCourseBTN_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainForm.mysqlconnection);
            String sqlStatement = "Update users.course SET course_name = @coursename, course_avalability = @courseavalability, course_active = @courseactive WHERE course_id = @courseid;";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@courseid", CourseIDcomboBox.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainForm.mysqlconnection);
            String sqlStatement = "Update users.course SET course_name = @coursename, course_avalability = @courseavalability, course_active = @courseactive WHERE course_id = @courseid;";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@courseid", CourseIDcomboBox.Text);
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

        private void DeleteCourseBTN_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainForm.mysqlconnection);
            String sqlStatement = "DELETE FROM users.course WHERE course_id = @courseid;";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@courseid", CourseIDcomboBox.Text); 
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course Deleted");
            command.Dispose();
            connection.Close();
            this.Hide();
        }
    }
}
