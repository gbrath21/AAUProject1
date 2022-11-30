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
    public partial class UpdateUser : Form
    {
        String connString = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
        public UpdateUser()
        {
            InitializeComponent();
        }
        int user_id;
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "SELECT * FROM user";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                while (Reader.Read())
                {
                    usernames.Items.Add(Reader.GetString("user_name"));
                }
            }
            String semestercom = "SELECT semester_name FROM semester_reg";
            MySqlCommand semcommand = new MySqlCommand(semestercom, connection);
            using (MySqlDataReader Reader = semcommand.ExecuteReader())
            {
                semester.Items.Add("");
                while (Reader.Read())
                {
                    semester.Items.Add(Reader.GetString("semester_name"));
                }
            }

        }
        
        private void updatebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "UPDATE user SET user_name = @username, user_password = @password, user_type = @usertype, semester_id = @semestername WHERE user_id = @user_id;";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@username", usernames.Text);
            command.Parameters.AddWithValue("@password", passwords.Text);
            command.Parameters.AddWithValue("@usertype", user_types.Text);
            if (semester.Text == "")
            {
                command.Parameters.AddWithValue("@semestername", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@semestername", semester.Text);
            }
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User Updated");
            command.Dispose();
            connection.Close();
            this.Hide();
        }

        private void usernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "SELECT * FROM user WHERE user_name = @username";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@username", usernames.Text);
            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                while (Reader.Read())
                {
                    user_id = Reader.GetInt32("user_id");
                    passwords.Text = Reader.GetString("user_password");
                    if (!Reader.IsDBNull(4))
                    {
                        semester.Text = Reader.GetString("semester_id");
                    }
                    user_types.Text = Reader.GetString("user_type");
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "DELETE FROM user WHERE user_id = @user_id;";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@user_id", user_id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User Deleted");
            command.Dispose();
            connection.Close();
            this.Hide();
        }

        private void semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
