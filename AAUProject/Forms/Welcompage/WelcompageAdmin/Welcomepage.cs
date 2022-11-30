using AAUProject.Controllers;
using AAUProject.Forms.Welcompage.WelcompageAdmin;
using AAUProject.Forms.Welcompage.WelcompageStundet;
using MindFusion.Vsx;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Child.Crown;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg;

namespace AAUProject
{
    public partial class Welcomepage : Form
    {
        int month, year;
        public static string sem_navn = "";

        public static int static_month, static_year;
        public Welcomepage()
        {
            InitializeComponent();
        }

        private void WelcomepageAdmin_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ShowUserNamelb.Text = MainForm.SetValueForUsername;
            ShowUserTypelb.Text = MainForm.User_type;
            displayDays();
            if (MainForm.User_type != "Admin")
            {
                CreateUserbtn.Hide();
                updateuserbtn.Hide();
                UpdateCourseBTN.Hide();
                CreateCoursebtn.Hide();
                CalenderBTN.Show();
                HomeworkBTN.Show();

                CreateCoursebtn.Hide();             
            }
            if (MainForm.User_type == "Admin")
            {
                CalenderBTN.Hide();
                HomeworkBTN.Hide();
            }
            if (MainForm.User_type == "Student")
            {
                CreateEventBTN.Hide();
                createevent2.Hide();
            }
            if (EventForm.saved is true)
            {
                daycontainer.Controls.Clear();
                displayDays();
            }

            foreach (string i in MainForm.courselist)
            {
                comboBox1.Items.Add(i);
                CourseslistBox1.Items.Add(i);
            }
        }

        public static bool click = false;
        //
        //Buttons on mainform
        //
        private void Homebtn_Click(object sender, EventArgs e)
        {
            Couseoverviewtab.SelectedTab = HomeTab;
        }

        private void royalButton1_Click_1(object sender, EventArgs e)
        {
            Couseoverviewtab.SelectedTab = CalendarTab;
        }

        private void royalButton2_Click(object sender, EventArgs e)
        {
            Couseoverviewtab.SelectedTab = HomeworkTab;
            weekdayDisplay();

        }
        private void CreateUserbtn_Click(object sender, EventArgs e)
        {
            CreateUserForm createuserform = new CreateUserForm();
            createuserform.Show();
        }
        //
        //Buttons on mainform
        //


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void crownDropDownList1_Click(object sender, EventArgs e)
        {

        }

        private void crownDockPanel1_Load(object sender, EventArgs e)
        {

        }


        //
        //Calendar
        //
        private void CreateEventBTN_Leave(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthnam = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthnam + " " + year;

            static_month = month;
            static_year = year;
            //firstday
            DateTime startofthemonth = new DateTime(year, month, 1);
            //Count of days
            int days = DateTime.DaysInMonth(year, month);
            //convert to int
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < daysoftheweek; i++)
            {
                BlankUserControl ucblank = new BlankUserControl();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void Prebtn_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            String monthnam = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthnam + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            //Count of days
            int days = DateTime.DaysInMonth(year, month);
            //convert to int
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < daysoftheweek; i++)
            {
                BlankUserControl ucblank = new BlankUserControl();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        private void Nextbtn_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            String monthnam = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthnam + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            //Count of days
            int days = DateTime.DaysInMonth(year, month);
            //convert to int
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < daysoftheweek; i++)
            {
                BlankUserControl ucblank = new BlankUserControl();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        //
        //Calendar
        //

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateEventBTN_Click(object sender, EventArgs e)
        {
            EventForm eventform = new EventForm();
            eventform.Show();
        }
        //
        //Drag form + buttons
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //
        //Drag form + buttons
        //



        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void royalButton1_Click(object sender, EventArgs e)
        {

        }




        //
        //homework
        //
        public static DateTime SetDate = DateTime.Now;

        private void prev_week_Click(object sender, EventArgs e)
        {
            WeekdaysPanel.Controls.Clear();
            SetDate = SetDate.AddDays(-7);
            int days = 7;
            int x = 0;
            for (int i = 1; i <= days; i++)
            {
                UserControldayschedule ucschedule = new UserControldayschedule();
                WeekdaysPanel.Controls.Add(ucschedule);
                ucschedule.date(SetDate.AddDays(x));
                x++;
            }
        }

        private void next_week_Click(object sender, EventArgs e)
        {
            WeekdaysPanel.Controls.Clear();
            SetDate = SetDate.AddDays(7);
            int days = 7;
            int x = 0;
            for (int i = 1; i <= days; i++)
            {
                UserControldayschedule ucschedule = new UserControldayschedule();
                WeekdaysPanel.Controls.Add(ucschedule);
                ucschedule.date(SetDate.AddDays(x));
                x++;
            }
        }

        private void Previous_WeekBTN_Click(object sender, EventArgs e)
        {
            WeekdaysPanel.Controls.Clear();
            SetDate = SetDate.AddDays(-7);
            int days = 7;
            int x = 0;
            for (int i = 1; i <= days; i++)
            {
                UserControldayschedule ucschedule = new UserControldayschedule();
                WeekdaysPanel.Controls.Add(ucschedule);
                ucschedule.date(SetDate.AddDays(x));
                x++;
            }
        }

        private void Next_WeekBTN_Click(object sender, EventArgs e)
        {
            WeekdaysPanel.Controls.Clear();
            SetDate = SetDate.AddDays(7);
            int days = 7;
            int x = 0;
            for (int i = 1; i <= days; i++)
            {
                UserControldayschedule ucschedule = new UserControldayschedule();
                WeekdaysPanel.Controls.Add(ucschedule);
                ucschedule.date(SetDate.AddDays(x));
                x++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        public static string datelblblb = DateTime.Now.ToString("dd");

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CourseslistBox1.SelectedItem = comboBox1.SelectedItem;

        }

        private void weekdayDisplay()
        {
            //days in a week
            int days = 7;
            int x = 0;
            for (int i = 1; i <= days; i++)
            {
                UserControldayschedule ucschedule = new UserControldayschedule();
                WeekdaysPanel.Controls.Add(ucschedule);
                ucschedule.date(SetDate.AddDays(x));
                x++;
            } 

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm logud = new MainForm();
            logud.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm logud = new MainForm();
            logud.Show();
            MainForm.courselist.Clear();
        }

        private void CreateCoursebtn_Click(object sender, EventArgs e)
        {
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.Show();
        }

        private void updateuserbtn_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.Show();
        }

        private void UpdateCourseBTN_Click(object sender, EventArgs e)
        {
            UpdateCourseForm updateCourseForm = new UpdateCourseForm();
            updateCourseForm.Show();
        }

        private void createevent2_Click(object sender, EventArgs e)
        {
            EventForm eventform = new EventForm();
            eventform.Show();
        }


        //
        //homework
        //

        //
        //Course Overview
        //
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Full_view();
        }

        public void Full_view()
        {
            Couseoverviewtab.SelectedTab = tabPage1;
            CoursesflowLayoutPanel.Controls.Clear();
            string selected = this.CourseslistBox1.GetItemText(this.CourseslistBox1.SelectedItem);
            string connstring = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            String sqlstatement = "SELECT * FROM lectures WHERE course_course_id = @course_id ORDER BY time_start";
            MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            command.Parameters.AddWithValue("@course_id", selected);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string course_name = reader.GetString("course_course_id");
                string course_headline = reader.GetString("course_course_id");
                string start = reader.GetString("time_start");
                string end = reader.GetString("time_end");
                int id = reader.GetInt32("info_id");
                string homework = reader.GetString("info_hw");
                DateTime date = reader.GetDateTime("cal_time");
                //SKAL ÆNDRES TIL MainForm.User_Type
                string user_type = MainForm.User_type;
                Full_course_view fullview = new Full_course_view();
                fullview.displaycourseinfo(course_headline, course_name, homework, date, user_type, start, end, id);
                CoursesflowLayoutPanel.Controls.Add(fullview);
            }
            reader.Dispose();
            command.Dispose();
            conn.Close();
            comboBox1.SelectedItem = CourseslistBox1.SelectedItem;
        }

        //
        //Course Overview
        //
    }
}
