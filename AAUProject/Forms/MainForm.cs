using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
        String mysqlconnection = "server=users.cedkilyugxhq.eu-north-1.rds.amazonaws.com;user id=admin;database=users;port=3306;password=12345678";
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
        private void LoginButton_Click(object sender, EventArgs e)
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
            string check_user_type = "SELECT user_type FROM user WHERE user_name = @username AND user_password = @password;";
            MySqlCommand checkuser = new MySqlCommand(check_user_type, connection);
            checkuser.Parameters.AddWithValue("@username", Username.Text);
            checkuser.Parameters.AddWithValue("@password", Password.Text);
            using (MySqlDataReader Reader = checkuser.ExecuteReader())
            {
                while (Reader.Read())
                {
                    string user_type = Reader.GetString(0);
                    if (IsLoggedIn is true)
                    {
                        SetValueForUsername = Username.Text;
                        SetValueForPassword = Password.Text;
                        SetValueForUsertype = user_type;
                        Welcomepage welcomepage = new Welcomepage();
                        welcomepage.Show();
                        Reader.Close();
                    }
                }
            }

        //    command = new MySqlCommand(sqlStatement1, connection);
        //    command.Parameters.AddWithValue("@username", Username.Text);
        //    command.Parameters.AddWithValue("@password", Password.Text);
        //    command.Parameters.AddWithValue("@usertype", UserType.Text);
        //    if (IsLoggedIn is true) 
        //    {
        //        using (MySqlDataReader Reader = command.ExecuteReader())
        //        {
        //            if (Reader.HasRows)
        //            {
        //                SetValueForUsername = Username.Text;
        //                SetValueForPassword = Password.Text;
        //                SetValueForUsertype = UserType.Text;
        //                Welcomepage welcomepage = new Welcomepage();
        //                welcomepage.Show();
        //                Reader.Close();
        //            }
        //        } 
        //    }
        //    command = new MySqlCommand(sqlStatement2, connection);
        //    command.Parameters.AddWithValue("@username", Username.Text);
        //    command.Parameters.AddWithValue("@password", Password.Text);
        //    command.Parameters.AddWithValue("@usertype", UserType.Text);
        //    if (IsLoggedIn is true)
        //    {
        //        using (MySqlDataReader Reader = command.ExecuteReader())
        //        {
        //            if (Reader.HasRows)
        //            {
        //                SetValueForUsername = Username.Text;
        //                SetValueForPassword = Password.Text;
        //                SetValueForUsertype = UserType.Text;
        //                Welcomepage welcomepage = new Welcomepage();
        //                welcomepage.Show();
        //                Reader.Close();
        //            }
        //        }
        //    }
        //    command = new MySqlCommand(sqlStatement3, connection);
        //    command.Parameters.AddWithValue("@username", Username.Text);
        //    command.Parameters.AddWithValue("@password", Password.Text);
        //    command.Parameters.AddWithValue("@usertype", UserType.Text);
        //    if (IsLoggedIn is true)
        //    {
        //        using (MySqlDataReader Reader = command.ExecuteReader())
        //        {
        //            if (Reader.HasRows)
        //            {
        //                SetValueForUsername = Username.Text;
        //                SetValueForPassword = Password.Text;
        //                SetValueForUsertype = UserType.Text;
        //                Welcomepage welcomepage = new Welcomepage();
        //                welcomepage.Show();
        //                Reader.Close();
        //            }
        //        }
        //    }
        }

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
    }
}