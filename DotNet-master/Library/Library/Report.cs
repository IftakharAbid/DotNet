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
    public partial class Report : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SHAHID AFRIDI ZIHAD\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
        public Report()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql.Close();
            sql.Open();
            DataSet1 ds = new DataSet1();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from IssueBook where id='"+richTextBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            CrystalReport1 myreport = new CrystalReport1();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;

            

        }

        private void Report_Load(object sender, EventArgs e)
        {
            sql.Close();
            sql.Open();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home1 hm1 = new Home1();
            hm1.Show();

        }
    }
}
