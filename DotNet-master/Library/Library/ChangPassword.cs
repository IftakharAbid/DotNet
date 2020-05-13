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
    public partial class ChangPassword : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public ChangPassword()
        {
            InitializeComponent();
        }

        private void RichTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            //string i;
            //i = (richTextBox3.Text.ToString());
            //string j;
            //j= (richTextBox4.Text.ToString());
            sql.Close();
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from UserData where id='"+richTextBox3.Text+"' and password='"+richTextBox4.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Old Password is Wrong");
                flag = false;
            }

            if (flag == true)
            {
                SqlCommand cmd1 = sql.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Update UserData set password='" + richTextBox1.Text + "' where id='" + richTextBox3.Text + "'";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Password Changed Successfully!!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
