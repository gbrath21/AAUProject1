using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Username.Select();
        }
        
        public static string mysqlconnection = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
        
        public static List<string> courselist = new List<string>();
        public bool IsLoggedIn = false;
        private void label1_Click(object sender, EventArgs e) { }


        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        public static string SetValueForUsername = "";
        public static string SetValueForPassword = "";
        public static string SetValueForUsertype = "";
        public static string User_type = "";
        public static string Semester_id = "";


        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            string sqlStatement = "SELECT * From user WHERE user_name = @username AND user_password = @password;";
            MySqlConnection connection = new MySqlConnection(mysqlconnection);
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);

            command.Parameters.AddWithValue("@username", Username.Text);
            command.Parameters.AddWithValue("@password", Password.Text);
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
            string check_user_type = "SELECT * FROM user WHERE user_name = @username AND user_password = @password;";
            MySqlCommand checkuser = new MySqlCommand(check_user_type, connection);
            checkuser.Parameters.AddWithValue("@username", Username.Text);
            checkuser.Parameters.AddWithValue("@password", Password.Text);
            using (MySqlDataReader Reader = checkuser.ExecuteReader())
            {
                if (Reader.Read())
                {
                    User_type = Reader.GetString(3);
                    Semester_id = Reader.GetString(4);
                    if (IsLoggedIn is true)
                    {
                        SetValueForUsername = Username.Text;
                        SetValueForPassword = Password.Text;
                        SetValueForUsertype = User_type;
                        
                    }

                }
            }
            string sem_courses = "SELECT course_id FROM semester WHERE semester_id = @semester;";
            MySqlCommand semcourses = new MySqlCommand(sem_courses, connection);
            semcourses.Parameters.AddWithValue("@semester", Semester_id);
            using (MySqlDataReader Reader = semcourses.ExecuteReader())
            {
                while (Reader.Read())
                {
                    courselist.Add(Reader.GetString("course_id"));
                   
                }
                if (IsLoggedIn is true)
                {
                    Welcomepage welcomepage = new Welcomepage();
                    welcomepage.Show();
                }
            }


        }
        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        }
    }
}