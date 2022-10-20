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

namespace AAUProject
{
    public partial class WelcomepageTeacher : Form
    {
        String connString = "server=users.cedkilyugxhq.eu-north-1.rds.amazonaws.com;user id=admin;database=users;port=3306;password=12345678";
        public WelcomepageTeacher()
        {
            InitializeComponent();
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void crownDropDownList1_Click(object sender, EventArgs e)
        {

        }

        private void WelcomepageTeacher_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "SELECT course_name FROM course";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                while (Reader.Read())
                {
                    coursedrop.Items.Add(Reader.GetString("course_name"));
                }
            }
        }

        private void coursedrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
