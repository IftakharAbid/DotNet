using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLoginform_Click(object sender, EventArgs e)
        {
            if (txtUN.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Enter Admin's UserName And Password");
            }
            else
            {
                if (txtUN.Text == "Sharif" && txtPass.Text == "s")
                {
                    UpdatePrice u = new UpdatePrice();
                    u.Show();
                    txtUN.Text = txtPass.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Admin's UserName or Password");
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CoffeeHouse c = new CoffeeHouse();
            c.Show();
            txtUN.Text = txtPass.Text = "";
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            txtUN.Text = txtPass.Text = "";

        }
    }
}
