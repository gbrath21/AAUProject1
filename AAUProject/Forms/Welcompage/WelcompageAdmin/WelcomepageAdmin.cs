using AAUProject.Forms.Welcompage.WelcompageAdmin;
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

namespace AAUProject
{
    public partial class WelcomepageAdmin : Form
    {
        public WelcomepageAdmin()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            WelcomepageAdmin welcomepageAdmin = new WelcomepageAdmin();
            welcomepageAdmin.Refresh();
        }

        private void WelcomepageAdmin_Load(object sender, EventArgs e)
        {
            ShowUsernameLabel.Text = MainForm.SetValueForUsername;
            ShowPasswordLabel.Text = MainForm.SetValueForPassword;
            ShowUserTypeLabel.Text = MainForm.SetValueForUsertype;
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm createuserform = new CreateUserForm();
            createuserform.Show();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            CalendarpageAdmin calendarpageAdmin = new CalendarpageAdmin();
            calendarpageAdmin.Show();
        }
    }
}
