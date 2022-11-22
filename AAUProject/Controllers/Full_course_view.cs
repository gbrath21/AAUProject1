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
        public Full_course_view()
        {
            InitializeComponent();
        }

        private void Full_course_view_Load(object sender, EventArgs e)
        {

        }

        public void displaycourseinfo(string name,string hw, string date)
        {
            info_headline.Text = name;
            hwtext.Text = hw;
            dato_fullview.Text = date;

        }


    }
}
