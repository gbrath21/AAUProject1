using AAUProject.Forms.Welcompage.WelcompageStundet;
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
    public partial class Full_course_view : UserControl
    {
        DateTime date_date;
        string starttime;
        string endtime;
        string coursename;
        int ID;
        public Full_course_view()
        {
            InitializeComponent();
        }

        private void Full_course_view_Load(object sender, EventArgs e)
        {

        }

        public void displaycourseinfo(string name,string course, string hw, DateTime date, string user_type,string start, string end, int id)
        {
            info_headline.Text = name;
            hwtext.Text = hw;
            date_date = date;
            dato_fullview.Text = date.ToString("dd-MM-yyyy");
            starttime = start;
            endtime = end;
            ID = id;
            coursename = course;

            if (user_type != "teacher")
            {
                button1.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventForm eventform = new EventForm();
            eventform.editevent(info_headline.Text, hwtext.Text, date_date, starttime, coursename, endtime, ID);
            eventform.Show();
        }
    }
}
