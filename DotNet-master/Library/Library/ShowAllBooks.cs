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
    public partial class ShowAllBooks : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public ShowAllBooks()
        {
            InitializeComponent();
        }

        private void ShowAllBooks_Load(object sender, EventArgs e)
        {
            ShowBooks();

        } // name like('%"+richTextBox1.Text+"%')";
        //"select * from BookList where name like('%" + richTextBox1.Text + "%') OR author like('%"+richTextBox1.Text+"%') OR category like ('%"+richTextBox1.Text+"%')";
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

        private void RichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BookList where name like('%" + richTextBox1.Text + "%') OR author like('%" + richTextBox1.Text + "%') OR category like ('%" + richTextBox1.Text + "%')";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;

            
            sql.Close();
            if(i==0)
            { MessageBox.Show("Book Not Found!!"); }
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            panel1.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[1].Value.ToString());

            
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BookList where id="+i+"";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
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

        private void Button4_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[1].Value.ToString());
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update BookList set name='"+ richTextBox2.Text + "', author='"+ richTextBox4.Text + "',year='"+ richTextBox5.Text + "',cost='"+ richTextBox6.Text + "',page='"+ richTextBox7.Text + "',quantity='"+ richTextBox8.Text + "',category='"+comboBox1.Text+"',edition='"+ richTextBox9.Text + "',available='"+ richTextBox10.Text + "' where id="+i+"";
            cmd.ExecuteNonQuery();
            ShowBooks();
            MessageBox.Show("Record Updated!!!");
            panel1.Visible = false;
            sql.Close();

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
         

        private void Button5_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[1].Value.ToString());
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from BookList where id="+i+"";
            cmd.ExecuteNonQuery();
            ShowBooks();
            
            MessageBox.Show("Record Deleted!!!");
            panel1.Visible = false;
            sql.Close();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
