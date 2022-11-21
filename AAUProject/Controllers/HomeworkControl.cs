using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAUProject.Controllers
{
    public partial class HomeworkControl : UserControl
    {
        public HomeworkControl()
        {
            InitializeComponent();
        }

        private void course_name_Click(object sender, EventArgs e)
        {

        }


        public void insertHomework(string date)
        {
            //string connstring = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
            //MySqlConnection conn = new MySqlConnection(connstring);

            //conn.Open();
            //foreach (var item in AAUProject.MainForm.courselist)
            //{
            //    String sqlstatement = "SELECT * FROM course_info WHERE cal_time = @cal_time AND course_course_id = @course_id ORDER BY time_start";
            //    MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            //    command.Parameters.AddWithValue("@course_id", item);
            //    command.Parameters.AddWithValue("@cal_time", date);
            //    MySqlDataReader reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        Homeworklist.Items.Add(reader.GetString("info_hw"));
            //    }
            //    reader.Dispose();
            //    command.Dispose();
            //}

            //conn.Close();
            string connstring = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            foreach (var item in AAUProject.MainForm.courselist)
            {
                String sqlstatement = "SELECT * FROM course_info WHERE cal_time = @cal_time AND course_course_id = @course_id ORDER BY time_start";
                MySqlCommand command = new MySqlCommand(sqlstatement, conn);
                command.Parameters.AddWithValue("@course_id", item);
                command.Parameters.AddWithValue("@cal_time", date);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    course_name.Text = reader.GetString("course_course_id");
                    homework.Text = reader.GetString("info_hw");
                    TimeSpan time1 = reader.GetTimeSpan("time_start");
                    TimeSpan time3 = reader.GetTimeSpan("time_end");
                    time.Text = time1.ToString("hh':'mm");
                    time2.Text = time3.ToString("hh':'mm");

                }
                reader.Dispose();


                command.Dispose();
            }

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
