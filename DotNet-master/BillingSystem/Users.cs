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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

       
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog()!=DialogResult.Cancel)
            {
                img_file = o.FileName;
                lblAddimage.Visible = false;
                picUser.Image = Image.FromFile(o.FileName);
            }
        }

        string img_file = null;
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
            con.Open();
            if (txtName.Text != "" && txtUN.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtContact.Text != "" && txtAddress.Text != "" && cmbGen.Text != "" && cmbUserType.Text != "")
            {
                if(img_file!=null)
                {
                    addDate.ToString("dd/MM/yyyy");

                    string query = "INSERT INTO [Billing_System].[dbo].[users] ([Name],[email],[username],[password],[contact],[address],[gender],[user_type],[added_date],[picture]) VALUES('" + txtName.Text+ "','" + txtEmail.Text + "','" + txtUN.Text + "','" + txtPass.Text + "','" + txtContact.Text + "','" + txtAddress.Text + "','" + cmbGen.Text + "','" + cmbUserType.Text + "','"+addDate+"',@pic)";
                    AddDataAndImage(query);
                    MessageBox.Show("Added");
                    img_file = null;
                }
                else
                {
                    MessageBox.Show("Please Add Image");
                }

            }
            else
            {
                MessageBox.Show("Please Add All Data");
            }

            loadGrid();
            clear();
            con.Close();
        }

         void AddDataAndImage(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
            con.Open();
            FileStream fsi = new FileStream(img_file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] image = new byte[fsi.Length];
            fsi.Read(image, 0, Convert.ToInt32(fsi.Length));
            fsi.Close();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
            cmd.Parameters.Add(prm);
            cmd.ExecuteNonQuery();

            con.Close();
        }
       public static DateTime addDate;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            addDate = DateTime.Now;
            lblTime.Text = addDate.ToString("dd/MM/yyyy");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
            loadGrid();
           
        }

        DataSet ds;
        SqlDataAdapter adp;
        SqlCommandBuilder builder;
        void loadGrid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
            con.Open();

            string query = "select * from users";
            SqlCommand cmd = new SqlCommand(query, con);


            ds = new DataSet();
            adp = new SqlDataAdapter(cmd);
            builder = new SqlCommandBuilder(adp);
            adp.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 100;
            }
            con.Close();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
            con.Open();

            string UserId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string query = "select * from users where id='"+UserId+"'";
            DataTable dt= DataAccess.GetDataTable(query);
            lblAddimage.Visible = false;
            txtUId.Text = dt.Rows[0][0].ToString();
            txtName.Text = dt.Rows[0][1].ToString();
            txtEmail.Text = dt.Rows[0][2].ToString();
            txtUN.Text = dt.Rows[0][3].ToString();
            txtPass.Text = dt.Rows[0][4].ToString();
            txtContact.Text = dt.Rows[0][5].ToString();
            txtAddress.Text = dt.Rows[0][6].ToString();
            cmbGen.Text = dt.Rows[0][7].ToString();
            cmbUserType.Text = dt.Rows[0][8].ToString();

            byte[] img = (byte[])dt.Rows[0][11];
            MemoryStream ms = new MemoryStream(img);
            picUser.Image = Image.FromStream(ms);

            con.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
            con.Open();    


            if (txtName.Text != "" && txtUN.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtContact.Text != "" && txtAddress.Text != "" && cmbGen.Text != "" && cmbUserType.Text != "")
            {
                if (img_file != null)
                {

                    string query = "update users set [Name]='" + txtName.Text + "',[email]='" + txtEmail.Text + "',[username]='" + txtUN.Text + "',[password]='" + txtPass.Text + "',[contact]='" + txtContact.Text + "',[address]='" + txtAddress.Text + "',[gender]='" + cmbGen.Text + "',[user_type]='" + cmbUserType.Text + "',[picture]=@pic where id='" + txtUId.Text + "'";
               
                        AddDataAndImage(query);
                        MessageBox.Show("data and pic Updated");
                       
                    }
                    else
                    {
                    string query = "update users set [Name]='" + txtName.Text + "',[email]='" + txtEmail.Text + "',[username]='" + txtUN.Text + "',[password]='" + txtPass.Text + "',[contact]='" + txtContact.Text + "',[address]='" + txtAddress.Text + "',[gender]='" + cmbGen.Text + "',[user_type]='" + cmbUserType.Text + "' where id='" + txtUId.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data Updated");
                    }
                loadGrid();
                clear();
                con.Close();
                }
                

            else
            {
                MessageBox.Show("Fill all the data");
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void clear()
        {
           txtUId.Text= txtName.Text = txtUN.Text = txtEmail.Text = txtPass.Text = txtContact.Text = txtAddress.Text = cmbGen.Text = cmbUserType.Text = "";
            picUser.Image = null;
                img_file = null;
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
            con.Open();
            if (MessageBox.Show("Confirm Delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM [Billing_System].[dbo].[users] WHERE id='" + txtUId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data deleted");
                loadGrid();
                clear();
            }

            con.Close();
        
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text!="")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
                con.Open();

                string query = "select * from users where [Name] like '%"+txtSearch.Text+ "%'";
                SqlCommand cmd = new SqlCommand(query, con);


                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                builder = new SqlCommandBuilder(adp);
                adp.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 100;
                }
                con.Close();
            }
        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories cc = new Categories();
            cc.Show();
        }
    }
}
