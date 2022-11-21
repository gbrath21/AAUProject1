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

        public void insertHomework(string name, string text, TimeSpan time1, TimeSpan time3)
        {
            course_name.Text = name;
            homework.Text = text;
            time.Text = time1.ToString("hh':'mm");
            time2.Text = time3.ToString("hh':'mm");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeworkControl_Load(object sender, EventArgs e)
        {

        }
    }
}
