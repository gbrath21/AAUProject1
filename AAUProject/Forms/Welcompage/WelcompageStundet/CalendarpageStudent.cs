using MySqlX.XDevAPI.Relational;
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

namespace AAUProject.Forms.Welcompage.WelcompageStundet
{
    public partial class CalendarpageStudent : Form
    {
        int month, year;

        public static int static_month, static_year;
        public CalendarpageStudent()
        {
            InitializeComponent();
        }

        private void HomeButton1_Click(object sender, EventArgs e)
        {
            //CalendarpageStudent calendarpageStudent = new CalendarpageStudent();
            this.Hide();
            WelcomepageStudent welcomepageStudent = new WelcomepageStudent();
            welcomepageStudent.Show();
        }

        private void HomeworkButton1_Click(object sender, EventArgs e)
        {

        }

        private void CalendarButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CalendarpageStudent_Load(object sender, EventArgs e)
        {
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
            DateTime startofthemonth = new DateTime(year, month,1);
            //Count of days
            int days = DateTime.DaysInMonth(year, month);
            //convert to int
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for(int i =1;i<daysoftheweek; i++)
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

        private void PreButton_Click(object sender, EventArgs e)
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

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
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
    }
}
