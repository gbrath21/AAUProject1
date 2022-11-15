﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace AAUProject.Forms.Welcompage.WelcompageStundet
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            string connstring = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
            MySqlConnection conn = new MySqlConnection(connstring);
            String sqlstatement = "SELECT * FROM course_info WHERE cal_time = @cal_time";
            conn.Open();
            MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            command.Parameters.AddWithValue("@cal_time", Welcomepage.static_year + "-" + Welcomepage.static_month + "-" + lbdays.Text);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())
            {

                coursedis.Items.Add(reader.GetString("info_headline"));

            }
            reader.Dispose();
            command.Dispose();
            conn.Close();
        }
        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        private void displayCourse()
        {
            string connstring = "server=aauapp.mysql.database.azure.com;user id=Admin1;database=users;port=3306;password=AAU1234!";
            MySqlConnection conn = new MySqlConnection(connstring);
            String sqlstatement = "SELECT * FROM course_info WHERE caltime = @cal_time";
            conn.Open();
            MySqlCommand command = new MySqlCommand(sqlstatement, conn);
            command.Parameters.AddWithValue("@cal_time", Welcomepage.static_year + "-" + Welcomepage.static_month + "-" + lbdays.Text);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                coursedis.Items.Add(reader.GetString("info_headline"));

            }
            reader.Dispose();
            command.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayCourse();
        }

        private void dispnl_Click(object sender, EventArgs e)
        {

        }
    }
}
