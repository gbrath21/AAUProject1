using AAUProject.Forms.Welcompage.WelcompageAdmin;
using AAUProject.Forms.Welcompage.WelcompageStundet;
using ReaLTaiizor.Child.Crown;
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

namespace AAUProject
{
    public partial class WelcomepageAdmin : Form
    {
        int month, year;

        public static int static_month, static_year;
        public WelcomepageAdmin()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            //WelcomepageAdmin welcomepageAdmin = new WelcomepageAdmin();
            //welcomepageAdmin.Refresh();
            tabControl1.SelectedTab = tabPage1;
        }

        private void WelcomepageAdmin_Load(object sender, EventArgs e)
        {
            ShowUsernameLabel.Text = MainForm.SetValueForUsername;
            ShowPasswordLabel.Text = MainForm.SetValueForPassword;
            ShowUserTypeLabel.Text = MainForm.SetValueForUsertype;
            displayDays();

        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm createuserform = new CreateUserForm();
            createuserform.Show();
            
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //CalendarpageAdmin calendarpageAdmin = new CalendarpageAdmin();
            //calendarpageAdmin.Show();
            tabControl1.SelectedTab = tabPage2;
            
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

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

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
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

        private void PreButton_Click_1(object sender, EventArgs e)
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
    }
}
