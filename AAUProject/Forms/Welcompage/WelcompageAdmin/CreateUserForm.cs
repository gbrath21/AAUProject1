using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace AAUProject.Forms.Welcompage.WelcompageAdmin
{
    public partial class CreateUserForm : Form
    {
        String connString = "server=users.cedkilyugxhq.eu-north-1.rds.amazonaws.com;user id=admin;database=users;port=3306;password=12345678";
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "SELECT semester_name FROM semester_reg";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                while (Reader.Read())
                {
                    semestertxt.Items.Add(Reader.GetString("semester_name"));
                }
            }
        }
        //private void LoadsemesternameById(int id)
        //{
        //    var connectionString = connString;
        //    using (var connection = new MySqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        var query = "SELECT semester_id, semester_name FROM semester_reg WHERE semester_name = @semestername";
        //        using (var command = new MySqlCommand(query, connection))
        //        { 
        //            command.Parameters.AddWithValue("@semestername", id);
        //            using (var reader = command.ExecuteReader())
        //            {
        //                if (!reader.HasRows)
        //                    return;

        //                semestertx.Text = reader.GetInt32("Id").ToString();
        //            }
        //        }
        //    }
        //}
        

        private void createuser_button_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "INSERT INTO users.user(user_name, user_password, user_type, semester_id) VALUES(@username, @password, @usertype, (select semester_id from semester_reg where semester_name = @semestername));";
            String sqlStatement1 = "UPDATE users.course set course.course_avalability = (course_avalability - 1) where course.course_id in (SELECT `course_id` FROM `users`.`semester` where semester_id in (select semester_id from semester_reg where semester_name = @semestername));";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@username", usernametxt.Text);
            command.Parameters.AddWithValue("@password", passwordtxt.Text);
            command.Parameters.AddWithValue("@usertype", usertypetxt.Text);
            command.Parameters.AddWithValue("@semestername", semestertxt.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            
            if(usertypetxt.Text == "Student") 
            {
                connection.Open();
                MySqlCommand command1 = new MySqlCommand(sqlStatement1, connection);
                command1.Parameters.AddWithValue("@semestername", semestertxt.Text);
                command1.ExecuteNonQuery();
            }

            MessageBox.Show("User created");
            command.Dispose();
            connection.Close();
            this.Hide();
        }

        private void usertypetx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void semestertx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usertypetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
