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
    public partial class AddBooks : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public AddBooks()
        {
            InitializeComponent();
            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql.Close();
            sql.Open();
            SqlCommand cmd = new SqlCommand("insert into AddBooks(name,id,author,year,cost,page,quantity,category,edition,available)VALUES('" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + richTextBox4.Text + "','" + richTextBox5.Text + "','" + richTextBox6.Text + "','" + richTextBox7.Text + "','" + comboBox1.Text + "','" + richTextBox8.Text + "','"+richTextBox9.Text+"')", sql);
            SqlCommand cmd1 = new SqlCommand("insert into BookList(name,id,author,year,cost,page,quantity,category,edition,available)VALUES('" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + richTextBox4.Text + "','" + richTextBox5.Text + "','" + richTextBox6.Text + "','" + richTextBox7.Text + "','" + comboBox1.Text + "','" + richTextBox8.Text + "','"+richTextBox9.Text+"')", sql);
            cmd1.ExecuteNonQuery();
            int a = cmd.ExecuteNonQuery();
            if(a>0)
            { MessageBox.Show("Book Inserted Successfully!"); } 
            sql.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home1 hm1 = new Home1();
            hm1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
