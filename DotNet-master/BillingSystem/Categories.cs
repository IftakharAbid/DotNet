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
using System.Data;
using System.IO;


namespace BillingSystem
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtDescription.Text != "")
            {
                try
                {
                    string addedby = LoginForm.UName;
                    DateTime adddate = Users.addDate;
                    string query = "INSERT INTO [Billing_System].[dbo].[category] ([title],[description],[added_date],[added_by]) VALUES ('" + txtTitle.Text + "','" + txtDescription.Text + "','" + adddate + "','" + addedby + "')";
                    DataAccess.excuteQuery(query);
                    MessageBox.Show("Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Fillup all info");
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        string str = "Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection con;
        DataTable dt;
        SqlCommandBuilder builder;
        private void Categories_Load(object sender, EventArgs e)
        {
            lblTime.Text = Users.addDate.ToString("dd/MM/yyyy");
            try
            {


                con = new SqlConnection(str);

                da = new SqlDataAdapter("select * from category", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 100;


                }

                deletebtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //enable editing of datagridview first
            try
            {

                builder = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        void deletebtn()
        {

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "Delete";

            btn.UseColumnTextForButtonValue = true;

        }



        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Confirm Delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    try
                    {

                        builder = new SqlCommandBuilder(da);
                        da.Update(dt);
                        MessageBox.Show("Deleted");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {


                string query = "select * from category where [title] like '%" + txtSearch.Text + "%'";
                DataTable dt = DataAccess.GetDataTable(query);

                dataGridView1.DataSource = dt;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 100;
                }
            }
        }
    }
}
