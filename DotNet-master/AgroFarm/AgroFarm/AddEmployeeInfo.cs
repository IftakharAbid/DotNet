﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgroFarm
{
    public partial class AddEmployeeInfo : Form
    {
        
        SqlConnection m = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=farm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public AddEmployeeInfo()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Profile p1 = new Profile();
            this.Hide();
            p1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Login.pos.Equals("Owner"))
            {
                this.Hide();
                Reports_Owner r1 = new Reports_Owner();
                r1.Show();
            }
            else
            {
                Reports r1 = new Reports();
                this.Hide();
                r1.Show();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ChangePassword c1 = new ChangePassword();
            this.Hide();
            c1.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void AddEmployeeInfo_Load(object sender, EventArgs e)
        {
            textBox1.Clear();          
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                m.Close();
                m.Open();
                SqlCommand cmd = new SqlCommand("insert into [dbo].[employee](FullName,Address,Phone,Position,Salary) values ('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", m);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Added Successfully");
                    textBox1.Clear();
                    
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                m.Close();
            }

            catch
            {
                MessageBox.Show("Error!!");
            }
        }
    }
}
