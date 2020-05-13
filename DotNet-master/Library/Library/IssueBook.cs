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
    public partial class IssueBook : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public IssueBook()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StudentList where id='" + richTextBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Record Not Found!!");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    richTextBox2.Text = dr["name"].ToString();
                    richTextBox3.Text = dr["id"].ToString();
                    richTextBox4.Text = dr["department"].ToString();
                    richTextBox5.Text = dr["email"].ToString();
                    richTextBox6.Text = dr["contact"].ToString();
                    //richTextBox7.Text = dr["id"].ToString();
                }
            }
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            if (sql.State == ConnectionState.Open)
            {
                sql.Close();

            }
            sql.Open();
        }

        private void RichTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_KeyUp(object sender, KeyEventArgs e)
        {




        }

        private void RichTextBox7_KeyUp(object sender, KeyEventArgs e)
        {

            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from BookList where name like('%" + richTextBox7.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["name"].ToString());
                    }
                }


            }
        }

        private void RichTextBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void ListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox7.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
                listBox1.SelectedIndex = 0;
            }
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox7.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int available_books=0;
            bool flag = true;
            SqlCommand cmd2 = sql.CreateCommand();
            cmd2.CommandType = CommandType.Text;

            cmd2.CommandText = "select * from BookList where name='"+richTextBox7.Text+"'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                available_books = Convert.ToInt32(dr2["available"].ToString());
            }

            if (available_books > 0  )  
            {
                SqlCommand cmd3 = sql.CreateCommand();
                cmd3.CommandType = CommandType.Text;

                cmd3.CommandText = "Select *from IssueBook where id='"+richTextBox1.Text+"'";
                cmd3.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                int rows = ds.Tables[0].Rows.Count;
                if (rows >= 2)
                {
                    MessageBox.Show("Cannot issue more books.\nA user can only issue 2 books.");
                    flag = false;
                }
                else { }

                //SqlCommand cmd4 = sql.CreateCommand();
                //cmd4.CommandType = CommandType.Text;

                //cmd4.CommandText = "Select *from IssueBook where name='" + richTextBox7.Text + "'";
                //cmd4.ExecuteNonQuery();
                //SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
                //DataSet ds4 = new DataSet();
                //sda4.Fill(ds4);

                //int rows4 = ds4.Tables[0].Rows.Count;

                //if(rows4>0)
                //{
                //    MessageBox.Show("Book is already issued by user");
                //    flag = false;
                //}
                //else { }


                if (flag == true)
                {

                    SqlCommand cmd = sql.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into IssueBook values('" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + richTextBox4.Text + "','" + richTextBox5.Text + "','" + richTextBox6.Text + "','" + richTextBox7.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd1 = sql.CreateCommand();
                    cmd1.CommandType = CommandType.Text;

                    cmd1.CommandText = "update BookList set available=available-1 where name='" + richTextBox7.Text + "'";
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Book Issued Successfully");
                }
               // count++;
            }
            else
            {
               
                    MessageBox.Show("Books Not Available!!");
                
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home1 h1 = new Home1();
            h1.Show();
        }
    }
}
