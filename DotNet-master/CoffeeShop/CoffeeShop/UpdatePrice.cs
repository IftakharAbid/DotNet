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
    
    public partial class UpdatePrice : Form
    {
        //price of coffee
        public static double latte = 2.0;
        public static double espresso = 3.5;
        public static double vale = 4.0;
        public static double cappu = 5.0;
        public static double icedcappu = 5.5;
        public static double icedlatte = 2.5;
        public static double american = 7.0;

        //price of cakes

        public static double coffCake = 8.0;
        public static double RValvetCake = 2.0;
        public static double BFCake = 3.2;
        public static double lagosCake = 4.5;
        public static double kiburnCake = 5.5;
        public static double bostonCake = 8.5;
        public static double queenCake = 3.0;


        public UpdatePrice()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            switch(txtFoodName.Text)
            {
                case "Latte":
                    latte = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Espresso":
                    espresso = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Vale Coffee":
                    vale = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Cappusino":
                    cappu = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Iced Cappusino":
                    icedcappu = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Iced Latte":
                    icedlatte = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "American Coffee":
                    american = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Coffee Cake":
                    coffCake = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Red Valvet Cake":
                    RValvetCake = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Queen's Cake":
                    queenCake = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Black Forest Cake":
                    BFCake = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Lagos Cake":
                    lagosCake = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Kiburn Cake":
                    kiburnCake = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;
                case "Boston Cake":
                    bostonCake = Int32.Parse(txtUpdatedPrice.Text);
                    MessageBox.Show("Price Updated");
                    txtFoodName.Text = txtUpdatedPrice.Text = "";
                    break;

                default:
                    MessageBox.Show("Name not Match");
                    break;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            
            CoffeeHouse ch = new CoffeeHouse();
            ch.Show();
            txtFoodName.Text = txtUpdatedPrice.Text = "";
            this.Hide();
        }

        private void UpdatePrice_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            txtFoodName.Text = txtUpdatedPrice.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
