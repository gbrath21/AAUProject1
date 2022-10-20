﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AAUProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        public bool IsLoggedIn = false;
        private void label1_Click(object sender, EventArgs e) { }

        

        public void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        public static string SetValueForUsername = "";
        public static string SetValueForPassword = "";
        public static string SetValueForUsertype = "";
        private void Login_Click(object sender, EventArgs e)
        {
            
            string conn = "server=users.cedkilyugxhq.eu-north-1.rds.amazonaws.com;user id=admin;database=users;port=3306;password=12345678";
            string sqlStatement = "SELECT * From user WHERE user_name = @username AND user_password = @password AND user_type = @usertype;";
            string sqlStatement1 = "SELECT user_type From user WHERE user_name = @username AND user_password = @password AND user_type = 'Student';";
            string sqlStatement2 = "SELECT user_type From user WHERE user_name = @username AND user_password = @password AND user_type = 'Teacher';";
            string sqlStatement3 = "SELECT user_type From user WHERE user_name = @username AND user_password = @password AND user_type = 'Admin';";
            MySqlConnection connection = new MySqlConnection(conn);

            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            
            command.Parameters.AddWithValue("@username", Username.Text);
            command.Parameters.AddWithValue("@password", Password.Text);
            command.Parameters.AddWithValue("@usertype", UserType.Text);

            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                if (Reader.HasRows)
                {
                    this.Hide();
                    IsLoggedIn = true;
                    Reader.Close();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                }
            }
            command = new MySqlCommand(sqlStatement1, connection);
            command.Parameters.AddWithValue("@username", Username.Text);
            command.Parameters.AddWithValue("@password", Password.Text);
            command.Parameters.AddWithValue("@usertype", UserType.Text);

            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                if (Reader.HasRows)
                {
                    SetValueForUsername = Username.Text;
                    SetValueForPassword = Password.Text;
                    SetValueForUsertype = UserType.Text;
                    WelcomepageStudent welcomepageStudent = new WelcomepageStudent();
                    welcomepageStudent.Show();
                    Reader.Close();
                }
            }
            command = new MySqlCommand(sqlStatement2, connection);
            command.Parameters.AddWithValue("@username", Username.Text);
            command.Parameters.AddWithValue("@password", Password.Text);
            command.Parameters.AddWithValue("@usertype", UserType.Text);
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                if (Reader.HasRows)
                {
                    SetValueForUsername = Username.Text;
                    SetValueForPassword = Password.Text;
                    SetValueForUsertype = UserType.Text;
                    WelcomepageTeacher welcomepageTeacher = new WelcomepageTeacher();
                    welcomepageTeacher.Show();                   
                    Reader.Close();
                }
            }
            command = new MySqlCommand(sqlStatement3, connection);
            command.Parameters.AddWithValue("@username", Username.Text);
            command.Parameters.AddWithValue("@password", Password.Text);
            command.Parameters.AddWithValue("@usertype", UserType.Text);
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                if (Reader.HasRows)
                {
                    SetValueForUsername = Username.Text;
                    SetValueForPassword = Password.Text;
                    SetValueForUsertype = UserType.Text;
                    WelcomepageAdmin welcomepageAdmin = new WelcomepageAdmin();
                    welcomepageAdmin.Show();
                    Reader.Close();
                }
            }
        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}