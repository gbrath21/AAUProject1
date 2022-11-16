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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AAUProject.Controllers
{
    public partial class UserControlAppointment : UserControl
    {
        public UserControlAppointment()
        {
            InitializeComponent();
        }
        public void displayHomework()
        {
            string connstring = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
            MySqlConnection conn = new MySqlConnection(connstring);
            String sqlstatement = "SELECT * FROM course_info WHERE caltime = @cal_time";
            conn.Open();
            MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            command.Parameters.AddWithValue("@cal_time", "2022, 15, 11");
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                Homeworktxt.Items.Add(reader.GetString("info_headline"));

            }
            reader.Dispose();
            command.Dispose();
            conn.Close();
        }

        private void UserControlAppointment_Load(object sender, EventArgs e)
        {
            displayHomework();
        }
    }
}
