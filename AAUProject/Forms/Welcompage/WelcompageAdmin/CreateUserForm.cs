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
                    semestertx.Items.Add(Reader.GetString("semester_name"));
                }
            }
        }
        private void LoadsemesternameById(int id)
        {
            var connectionString = connString;
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT semester_id, semester_name FROM semester_reg WHERE semester_name = @semestername";
                using (var command = new MySqlCommand(query, connection))
                { 
                    command.Parameters.AddWithValue("@semestername", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            return;

                        semestertx.Text = reader.GetInt32("Id").ToString();
                    }
                }
            }
        }
        

        private void SaveUserInDBButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "INSERT INTO user(user_name, user_password, user_type, semester_id) VALUES(@username, @password, @usertype, (select semester_id from semester_reg where semester_name = @semestername));";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@username", usernametx.Text);
            command.Parameters.AddWithValue("@password", passwordtx.Text);
            command.Parameters.AddWithValue("@usertype", usertypetx.Text);
            command.Parameters.AddWithValue("@semestername", semestertx.Text);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("User created");
            command.Dispose();
            connection.Close();
            this.Hide();
        }

       

       
        
    }
}
