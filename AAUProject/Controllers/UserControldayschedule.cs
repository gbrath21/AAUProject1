using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using MySql.Data.MySqlClient;
using AAUProject.Forms.Welcompage.WelcompageStundet;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace AAUProject.Controllers
{
    public partial class UserControldayschedule : UserControl
    {
        public UserControldayschedule()
        {
            InitializeComponent();
        }
        
        
        private void UserControldayschedule_Load(object sender, EventArgs e)
        {
            
        }
        public void date(DateTime date)
        {

            Datelb.Text = date.ToString("yyyy-MM-dd");
            Weekdaylb.Text = date.ToString("dddd");
            displayHomework(Datelb.Text);
        }

        public void displayHomework(string date)
        {

            string connstring = "server=aaupro.mysql.database.azure.com;user id=AAU_admin@aaupro;database=users;port=3306;password=Saderlort1";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            foreach (var item in AAUProject.MainForm.courselist)
            {
                String sqlstatement = "SELECT * FROM lectures WHERE cal_time = @cal_time AND course_course_id = @course_id ORDER BY time_start";
                MySqlCommand command = new MySqlCommand(sqlstatement, conn);
                command.Parameters.AddWithValue("@course_id", item);
                command.Parameters.AddWithValue("@cal_time", date);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string course_name = reader.GetString("course_course_id");
                    string homework = reader.GetString("info_hw");
                    TimeSpan time1 = reader.GetTimeSpan("time_start");
                    TimeSpan time3 = reader.GetTimeSpan("time_end");
                    HomeworkControl hwcon = new HomeworkControl();
                    hwcon.insertHomework(course_name,homework,time1,time3);
                    Appointmentpanel.Controls.Add(hwcon);
                }
                reader.Dispose();


                command.Dispose();
            }

            conn.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

