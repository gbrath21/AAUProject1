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
        String connString = "server=aaupro.mysql.database.azure.com;user id=AAU_admin@aaupro;database=users;port=3306;password=Saderlort1";
        public static int id;
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
            String sqlStatement = "SELECT course_id FROM teacher_courses WHERE teacher_id = @user_id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@user_id", MainForm.user_id);
            
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
        public static bool updated = false;

        public void editevent(string name, string hw, DateTime date, string starttime, string course, string endtime, int id_ind)
        {
            id = id_ind;
            dateTimePicker1.Value = date;
            txcoursename.Text = name;
            txhomework.Text = hw;
            course_idbox.Text = course;
            Starttimebox.Text = starttime;
            Endtimebox.Text = endtime;
            Savebtn.Text = "Save as new";
            updatebtn.Visible = true;
            deletebtn.Visible = true;
        }
        private void Savebtn_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "INSERT INTO lectures(info_hw, info_headline, course_course_id, cal_time, time_start, time_end) VALUES( @homework, @headline, @courseid, @coursedate, @timestart, @timeend)";
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "UPDATE lectures SET info_hw = @homework, info_headline = @headline, course_course_id = @courseid, cal_time = @coursedate, time_start = @timestart, time_end = @timeend WHERE info_id = @id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@coursedate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@headline", txcoursename.Text);
            command.Parameters.AddWithValue("@homework", txhomework.Text);
            command.Parameters.AddWithValue("@courseid", course_idbox.Text);
            command.Parameters.AddWithValue("@timestart", Starttimebox.Text);
            command.Parameters.AddWithValue("@timeend", Endtimebox.Text);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Updated");
            command.Dispose();
            connection.Close();
            this.Hide();
            updated = true;

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            String sqlStatement = "DELETE FROM course_info WHERE info_id = @id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            command.Dispose();
            connection.Close();
            this.Hide();
            updated = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
