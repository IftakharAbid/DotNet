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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        } //SELECT id_employee FROM employee WHERE employee_number= @txtUserName AND passWord= @txtPassword";
        //"select count(*) from data1 where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'" , sql

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("select type from UserData where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                this.Hide();
                if (dt.Rows[0][0].ToString() == "Student")
                {

                    Student s = new Student();
                    s.Show();
                }

                if (dt.Rows[0][0].ToString() == "Faculty")
                {
                    faculty f = new faculty();
                    f.Show();
                }

                if (dt.Rows[0][0].ToString() == "Admin")
                {
                    Home1 hm = new Home1();
                    hm.Show();
                }

               
            }




            else { MessageBox.Show("Invalid user name or password"); }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp s = new SignUp();
            s.Show();
        }
    }
}
