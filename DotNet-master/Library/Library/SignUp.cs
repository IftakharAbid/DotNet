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
    public partial class SignUp : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into UserData (name,id,username,email,type,password,department) values ('"+richTextBox1.Text+"','"+richTextBox5.Text+"','"+richTextBox2.Text+"','"+richTextBox3.Text+"','"+comboBox1.Text+"','"+richTextBox4.Text+"','"+comboBox2.Text+"') ";
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = sql.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into StudentReg (name,id,department,email) values ('" + richTextBox1.Text + "','" + richTextBox5.Text + "','" + comboBox1.Text + "','" + richTextBox3.Text + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = sql.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into StudentList(name,id,department,email) values ('" + richTextBox1.Text + "','" + richTextBox5.Text + "','" + comboBox1.Text + "','" + richTextBox3.Text + "')";
            int a = cmd2.ExecuteNonQuery();

            if (a > 0)
            { MessageBox.Show("Registered Successfully!!"); }
            sql.Close();
        }
    }
}
