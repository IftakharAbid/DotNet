using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string UName;
        public static string Type;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUN.Text != "" && txtPass.Text != "" && cmbType.Text != "")
            {
                try
                {


                    string query = "select * from [users] where [username]='" + txtUN.Text + "' AND [password]='" + txtPass.Text + "' AND [user_type]='"+cmbType.Text+"'";
                    DataTable dt = DataAccess.GetDataTable(query);
                    if (dt.Rows.Count == 1)
                    {
                        if (cmbType.Text == "Admin")
                        {
                            UName = txtUN.Text;
                            Type = cmbType.Text;
                            this.Hide();
                            AdminHome ah = new AdminHome();
                            ah.Show();
                        }
                        
                        if (cmbType.Text == "User")
                        {

                            UName = txtUN.Text;
                            Type = cmbType.Text;
                            this.Hide();
                            UserHome ah = new UserHome();
                            ah.Show();
                        }
                        


                    }
                    else
                    {
                        MessageBox.Show("Invalid info");
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Fillup All Info");
            }
        }

        private void LblShowPass_MouseHover(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void LblShowPass_MouseLeave(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '#';
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

