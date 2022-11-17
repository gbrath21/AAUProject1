﻿using System;
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
using MySql.Data.MySqlClient;
using AAUProject.Forms.Welcompage.WelcompageStundet;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace AAUProject.Controllers
{
    public partial class UserControldayschedule : UserControl
    {
        public UserControldayschedule()
        {
            InitializeComponent();
        }
        
        
        private void UserControldayschedule_Load(object sender, EventArgs e)
        {
            displayHomework();
            
        }
        public static string dato = "";
        public static DateTime asd = Welcomepage.SetDate;
        public void date(int daynum)
        {
            //sætter datecal lig med SetDate fra welcomepage som er datoen fra calenderen
            DateTime datecal = asd;

            var Datestring = datecal.AddDays(daynum).ToString("yyyy-MM-dd");
            //var Datestring1 = datecal.AddDays(daynum + 1).ToString("yyyy-MM-dd");
            var today = datecal.AddDays(daynum);
            Datelb.Text = Datestring;
            Weekdaylb.Text = today.ToString("dddd");
            //dato = Datestring1;
            //if (Datelb.Text == datecal.AddDays(daynum).ToString("yyyy-MM-dd"))
            //{
            //    Datelb.Text = Datestring;
            //    MessageBox.Show(Datelb.Text);
            //}
            //else if (Datelb.Text == "")
            //{
            //    Datelb.Text = dato;
            //    MessageBox.Show(Datelb.Text);
            //}

        }

        public void displayHomework()
        {
            
            if (Datelb.Text == "")
            {
                Datelb.Text = Welcomepage.SetDate.ToString("yyyy-MM-dd");
                MessageBox.Show(Datelb.Text );
            }
            string connstring = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
            MySqlConnection conn = new MySqlConnection(connstring);
            String sqlstatement = "SELECT info_hw FROM course_info WHERE cal_time = @cal_time";
            conn.Open();
            MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            command.Parameters.AddWithValue("@cal_time", Datelb.Text);  
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {          
                Homeworklist.Items.Add(reader.GetString("info_hw"));
            }
            reader.Dispose();
            command.Dispose();
            conn.Close();
        }
    }
}

