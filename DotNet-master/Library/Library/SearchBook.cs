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
    public partial class SearchBook : Form 
    {
        bool flag;
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            ShowBooks();
        }

        public void ShowBooks()
        {
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BookList";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }

        private void RichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
        //    int i = 0;
        //    sql.Close();
        //    sql.Open();
        //    SqlCommand cmd = sql.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from BookList where name like('%" + richTextBox1.Text + "%') OR author like('%" + richTextBox1.Text + "%') OR category like ('%" + richTextBox1.Text + "%')";
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    i = Convert.ToInt32(dt.Rows.Count.ToString());
        //    dataGridView1.DataSource = dt;


        //    sql.Close();
        //    if (i == 0)
        //    { MessageBox.Show("Book Not Found!!"); }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            
            
                faculty f = new faculty();
                f.Show();
            
           


        }

        private void Button3_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select * from BookList where name like('%" + richTextBox1.Text + "%') OR author like('%" + richTextBox1.Text + "%') OR category like ('%" + richTextBox1.Text + "%')";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[1].Value.ToString());


            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BookList where id=" + i + "";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                richTextBox2.Text = dr["name"].ToString();
                richTextBox4.Text = dr["author"].ToString();
                richTextBox5.Text = dr["year"].ToString();
                richTextBox6.Text = dr["cost"].ToString();
                richTextBox7.Text = dr["page"].ToString();
                richTextBox8.Text = dr["quantity"].ToString();
                comboBox1.Text = dr["category"].ToString();
                richTextBox9.Text = dr["edition"].ToString();
                richTextBox10.Text = dr["available"].ToString();
            }
            sql.Close();

        }
    }
}
