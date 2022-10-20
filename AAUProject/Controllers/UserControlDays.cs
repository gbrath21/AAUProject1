using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace AAUProject.Forms.Welcompage.WelcompageStundet
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost;user id=root;database=aau;port=3306;password=PA10na2013";
            MySqlConnection conn = new MySqlConnection(connstring);
            String sqlstatement = "SELECT * FROM course WHERE CourseDate = @coursedate";
            conn.Open();
            MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            command.Parameters.AddWithValue("@coursedate", WelcomepageAdmin.static_year + "-" + WelcomepageAdmin.static_month + "-" + lbdays.Text);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                    
                dispnl.Text = reader["CourseName"].ToString();

            }
            reader.Dispose();
            command.Dispose();
            conn.Close();
        }
        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        private void displayCourse()
        {
            string connstring = "server=localhost;user id=root;database=aau;port=3306;password=PA10na2013";
            MySqlConnection conn = new MySqlConnection(connstring);
            String sqlstatement = "SELECT * FROM course WHERE CourseDate = @coursedate";
            conn.Open();
            MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            command.Parameters.AddWithValue("@coursedate", CalendarpageStudent.static_year+ "-" + CalendarpageStudent.static_month + "-" + lbdays.Text);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                dispnl.Text = reader["CourseName"].ToString();
            }
            reader.Dispose();
            command.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayCourse();
        }

        private void dispnl_Click(object sender, EventArgs e)
        {

        }
    }
}
