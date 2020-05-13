using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Library
{
    public partial class ReturnBook : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from IssueBook where id like('%" + richTextBox1.Text + "%') ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            sql.Close();
            sql.Open();


        }

        public void fillgrid(string id)
        {
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from IssueBook";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql.Close();
            sql.Open();
            string i;
            i = (dataGridView1.SelectedCells[1].Value.ToString());
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from IssueBook where id='" + i + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                richTextBox2.Text = dr["bookname"].ToString();
                richTextBox3.Text = Convert.ToString(dr["issuedate"].ToString());
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    richTextBox2.Text = row.Cells["bookname"].Value.ToString();
            //    richTextBox3.Text = row.Cells["issuedate"].Value.ToString();

                //        //var fine = 0;
                //        //var day1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                //        //var day2 = Convert.ToInt32(dateTimePicker1.Value);
                //        //var daypassed = day1 - day2;
                //        //if(daypassed>7)
                //        //{
                //        //    fine = 10 * (daypassed - 7);
                //        //}
                //        //richTextBox4.Text = Convert.ToString(fine);



                  // }
            }

            private void Button2_Click(object sender, EventArgs e)
            {

                sql.Close();
                sql.Open();
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into ReturnBook values('" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + richTextBox4.Text + "')";
                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = sql.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update BookList set available = available + 1 where name = '" + richTextBox2.Text + "'";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Book Returned Successfully");

                SqlCommand cmd2 = sql.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "delete from IssueBook where bookname='" + richTextBox2.Text + "'";
                cmd2.ExecuteNonQuery();





                fillgrid(richTextBox1.Text);
            }

            private void Button3_Click(object sender, EventArgs e)
            {
                this.Hide();
                Home1 hm1 = new Home1();
                hm1.Show();
            }
        }
    }

