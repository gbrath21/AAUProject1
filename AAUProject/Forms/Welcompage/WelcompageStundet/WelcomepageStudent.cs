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
    public partial class WelcomepageStudent : Form
    {
        public WelcomepageStudent()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcomepage_Load(object sender, EventArgs e)
        {
            ShowUsernameLabel.Text = MainForm.SetValueForUsername;
            ShowPasswordLabel.Text = MainForm.SetValueForPassword;
            ShowUserTypeLabel.Text = MainForm.SetValueForUsertype;
        }

        

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ShowUserTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Userinfopanel_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            
            WelcomepageStudent welcomepageStudent = new WelcomepageStudent();
            welcomepageStudent.Refresh();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarpageStudent calendarpageStudent = new CalendarpageStudent();
            calendarpageStudent.Show();

        }

        
    }
}
