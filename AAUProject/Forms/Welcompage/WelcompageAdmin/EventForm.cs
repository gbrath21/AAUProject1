using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MindFusion.Scheduling.WinForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace AAUProject.Forms.Welcompage.WelcompageStundet
{
    public partial class EventForm : Form
    {
        String connString = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";

        public EventForm()
        {
            InitializeComponent();
        }
        
        private void EventForm_Load(object sender, EventArgs e)
        {
            for (int i = 7; i < 21; i++)
            {
                Starttimebox.Items.Add(i.ToString("00") + ":00:00");
                Endtimebox.Items.Add(i.ToString("00") + ":00:00");
            }
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "SELECT course_id FROM semester WHERE semester_id = (select semester_id from user where user_name = @username)";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@username", MainForm.SetValueForUsername);

            connection.Open();
            using (MySqlDataReader Reader = command.ExecuteReader())
            {
                while (Reader.Read())
                {
                    course_idbox.Items.Add(Reader.GetString("course_id"));
                }
            }
        }
        public static bool saved = false;
        private void Savebtn_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "INSERT INTO course_info(info_hw, info_headline, course_course_id, cal_time, time_start, time_end) VALUES( @homework, @headline, @courseid, @coursedate, @timestart, @timeend)";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@coursedate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@headline", txcoursename.Text);
            command.Parameters.AddWithValue("@homework", txhomework.Text);
            command.Parameters.AddWithValue("@courseid", course_idbox.Text);
            command.Parameters.AddWithValue("@timestart", Starttimebox.Text);
            command.Parameters.AddWithValue("@timeend", Endtimebox.Text);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Saved");
            command.Dispose();
            connection.Close();
            this.Hide();
            saved = true;

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        
    }
}
