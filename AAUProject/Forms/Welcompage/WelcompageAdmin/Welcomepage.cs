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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAUProject
{
    public partial class Welcomepage : Form
    {
        int month, year;

        public static int static_month, static_year;
        public Welcomepage()
        {
            InitializeComponent();
            //m_Appointments = new List<Appointment>();

            //DateTime m_Date = DateTime.Now;

            //m_Date = m_Date.AddHours(10 - m_Date.Hour);
            //m_Date = m_Date.AddMinutes(-m_Date.Minute);

            //Appointment m_Appointment = new Appointment();
            //m_Appointment.StartDate = m_Date;
            //m_Appointment.EndDate = m_Date.AddHours(2);
            //m_Appointment.Title = "test1\r\nmultiline";

            //m_Appointments.Add(m_Appointment);

            //m_Appointment = new Appointment();
            //m_Appointment.StartDate = m_Date.AddHours(2);
            //m_Appointment.EndDate = m_Date.AddHours(3);
            //m_Appointment.Title = "test2\r\n locked one";
            //m_Appointment.Color = System.Drawing.Color.LightBlue;
            //m_Appointment.Locked = true;

            //m_Appointments.Add(m_Appointment);

            //m_Appointment = new Appointment();
            //m_Appointment.StartDate = m_Date;
            //m_Appointment.EndDate = m_Date.AddHours(4);
            //m_Appointment.Color = System.Drawing.Color.Yellow;
            //m_Appointment.Title = "test3\r\n some numbers 123456 and unicode chars (turkish) ÐÜÞÝÇÖÇI ";

            //m_Appointments.Add(m_Appointment);

            //m_Appointment = new Appointment();
            //m_Appointment.StartDate = m_Date;
            //m_Appointment.EndDate = m_Date.AddDays(2);
            //m_Appointment.Title = "More than one day";
            //m_Appointment.Color = System.Drawing.Color.Red;

            //m_Appointments.Add(m_Appointment);

            //m_Appointment = new Appointment();
            //m_Appointment.StartDate = m_Date.AddDays(1);
            //m_Appointment.EndDate = m_Date.AddDays(3);
            //m_Appointment.Title = "More than one day (2)";
            //m_Appointment.Color = System.Drawing.Color.Coral;

            //m_Appointments.Add(m_Appointment);

            

        }
      
        private void WelcomepageAdmin_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ShowUserNamelb.Text = MainForm.SetValueForUsername;
            ShowPasswordlb.Text = MainForm.SetValueForPassword;
            ShowUserTypelb.Text = MainForm.User_type;
            displayDays();
            if (MainForm.User_type != "admin")
            {
                CreateUserbtn.Hide();
            }
            //dayView1.ViewType = 
        }

        //
        //Buttons on mainform
        //
        private void Homebtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = HomeTab;
        }

        private void royalButton1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = CalendarTab;
        }

        private void royalButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = HomeworkTab;
        }
        //
        //Buttons on mainform
        //

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

        private void CreateUserbtn_Click(object sender, EventArgs e)
        {
            CreateUserForm createuserform = new CreateUserForm();
            createuserform.Show();
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
        //homework
        //

       
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            //dayView1.StartDate = monthCalendar2.SelectionStart;
        }

    }
}
