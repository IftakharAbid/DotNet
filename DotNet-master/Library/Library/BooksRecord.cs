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
using System.Net.Mail;
using System.Net;

namespace Library
{
    public partial class BooksRecord : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public BooksRecord()
        {
            InitializeComponent();
        }

        private void BooksRecord_Load(object sender, EventArgs e)
        {
            sql.Close();
            sql.Open();
            fillbooks();
        }

        public void fillbooks()
        {
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name,author,quantity,available from BookList";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = (dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from IssueBook where  bookname ='"+i.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void RichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name,author,quantity,available from BookList where name like ('%"+richTextBox1.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home1 hm1 = new Home1();
            hm1.Show();
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = (dataGridView2.SelectedCells[3].Value.ToString());
            richTextBox2.Text = i.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("zihad.24bd@gmail.com", "TheVamps5SoS");
            MailMessage mail = new MailMessage("zihad.24bd@gmail.com", richTextBox2.Text, "Return Book", richTextBox3.Text);
            mail.Priority = MailPriority.High;
            smtp.Send(mail);
            MessageBox.Show("Mail Sent");
        }
    }
}
