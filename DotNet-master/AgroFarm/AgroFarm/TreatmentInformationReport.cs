﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AgroFarm
{
    public partial class TreatmentInformationReport : Form
    {
        
        SqlConnection m = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=farm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public TreatmentInformationReport()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                m.Close();
                m.Open();
                SqlCommand cmd = new SqlCommand("delete from [dbo].[treatment] where Tid='" + textBox1.Text + "'", m);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Deleted");
                    textBox1.Clear();
                    this.Hide();
                    TreatmentInformationReport f1 = new TreatmentInformationReport();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
                m.Close();
            }
            catch
            {
                
            }
        }

        private void TreatmentInformationReport_Load(object sender, EventArgs e)
        {
            try
            {
                m.Close();
                m.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from [dbo].[treatment]", m);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int a = dataGridView1.Rows.Add();
                    dataGridView1.Rows[a].Cells[0].Value = item[0];
                    dataGridView1.Rows[a].Cells[1].Value = item[1];
                    dataGridView1.Rows[a].Cells[2].Value = item[2];
                    dataGridView1.Rows[a].Cells[3].Value = item[3];
                    dataGridView1.Rows[a].Cells[4].Value = item[4];
                }
                m.Close();
            }

            catch
            {
                
            }
        }

        private void dataGridView1_click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            }
            catch
            {
                
            }
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                m.Close();
                m.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from [dbo].[treatment]  where Symptom='"+textBox2.Text+"'", m);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {

                        MessageBox.Show("Use this Pesticide named " + item[3] + "\nUse this Fertilizer named " + item[4]);
                        textBox2.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("No Match");
                    textBox2.Text = "";
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
