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

namespace AAUProject.Controllers
{
    public partial class UserControldayschedule : UserControl
    {
        public UserControldayschedule()
        {
            InitializeComponent();
        }
        int day;
        string date1 = "";
        
        private void UserControldayschedule_Load(object sender, EventArgs e)
        {
            
        }
        public void date(int daynum)
        {
            var Date = DateTime.Now.AddDays(daynum).ToShortDateString();
            var today = DateTime.Now.AddDays(daynum);
            Datelb.Text = Date;
            Weekdaylb.Text = today.ToString("dddd");
        }

        private void Homeworklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

