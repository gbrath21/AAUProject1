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
    public partial class EventForm : Form
    {
        String connString = "server=localhost;user id=root;database=aau;port=3306;password=PA10na2013";

        public EventForm()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = WelcomepageAdmin.static_year + "/" + WelcomepageAdmin.static_month + "/" + UserControlDays.static_day;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "INSERT INTO course(CourseDate, CourseName) VALUES(@coursedate, @coursename)";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@coursedate", txdate.Text);
            command.Parameters.AddWithValue("@coursename", txcourse.Text);
            connection.Open();                      
            command.ExecuteNonQuery();
            MessageBox.Show("Saved");
            command.Dispose();
            connection.Close();
            this.Hide();
            
        }
    }
}
