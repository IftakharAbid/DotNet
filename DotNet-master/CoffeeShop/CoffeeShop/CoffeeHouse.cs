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
    public partial class CoffeeHouse : Form
    {
        public CoffeeHouse()
        {
            InitializeComponent();
        }

        private void CoffeeHouse_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            init();

        }

        private void init()
        {
            rtxtRecipt.Clear();

            txtAfricanCoffee.Text = "0";
            txtCappuccino.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCappuccino.Text = "0";
            txtIcedLatte.Text = "0";
            txtLatte.Text = "0";
            txtValeCoffee.Text = "0";

            txtRedValvetCake.Text = "0";
            txtQueensCake.Text = "0";
            txtLagosCake.Text = "0";
            txtKiburnCake.Text = "0";
            txtCoffeeCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBostonCake.Text = "0";

            lblCakesCost.Text = "0";
            lblDrinksCost.Text = "0";
            lblService.Text = "1.75";
            lblTax.Text = "";
            lblSubTotal.Text = "";
            lblTotal.Text ="";


            txtAfricanCoffee.Enabled = false;
            txtCappuccino.Enabled = false;
            txtEspresso.Enabled = false;
            txtIcedCappuccino.Enabled = false;
            txtIcedLatte.Enabled = false;
            txtLatte.Enabled = false;
            txtValeCoffee.Enabled = false;

            txtRedValvetCake.Enabled = false;
            txtQueensCake.Enabled = false;
            txtLagosCake.Enabled = false;
            txtKiburnCake.Enabled = false;
            txtCoffeeCake.Enabled = false;
            txtBlackForestCake.Enabled = false;
            txtBostonCake.Enabled = false;


            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkValeCoffee.Checked = false;
            chkCappuccino.Checked = false;
            chkCappuccino.Checked = false;
            chkIcedCappuccino.Checked = false;
            chkIcedLatte.Checked = false;

            chkQueensCake.Checked = false;
            chkBostonCake.Checked = false;
            chkKiburnCake.Checked = false;
            chkLagosCake.Checked = false;
            chkBlackForestCake.Checked = false;
            chkRedValvetCake.Checked = false;
            chkCoffeeCake.Checked = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            init();

        }

        private void ChkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLatte.Enabled = true;
                txtLatte.Text = "";
            }
            if (chkLatte.Checked == false)
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void ChkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
                txtEspresso.Text = "";
            }
            if (chkEspresso.Checked == false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void ChkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeCoffee.Checked == true)
            {
                txtValeCoffee.Enabled = true;
                txtValeCoffee.Text = "";
            }
            if (chkValeCoffee.Checked == false)
            {
                txtValeCoffee.Enabled = false;
                txtValeCoffee.Text = "0";
            }
        }

        private void ChkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccino.Enabled = true;
                txtCappuccino.Text = "";
            }
            if (chkCappuccino.Checked == false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void ChkIcedCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedCappuccino.Checked == true)
            {
                txtIcedCappuccino.Enabled = true;
                txtIcedCappuccino.Text = "";
            }
            if (chkIcedCappuccino.Checked == false)
            {
                txtIcedCappuccino.Enabled = false;
                txtIcedCappuccino.Text = "0";
            }
        }

        private void ChkIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == true)
            {
                txtIcedLatte.Enabled = true;
                txtIcedLatte.Text = "";
            }
            if (chkIcedLatte.Checked == false)
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }
        }

        private void ChkAfricanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfricanCoffee.Checked == true)
            {
                txtAfricanCoffee.Enabled = true;
                txtAfricanCoffee.Text = "";
            }
            if (chkAfricanCoffee.Checked == false)
            {
                txtAfricanCoffee.Enabled = false;
                txtAfricanCoffee.Text = "0";
            }
        }

        private void ChkCoffeeCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffeeCake.Checked == true)
            {
                txtCoffeeCake.Enabled = true;
                txtCoffeeCake.Text = "";
            }
            if (chkCoffeeCake.Checked == false)
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
        }

        private void ChkRedValvetCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvetCake.Checked == true)
            {
                txtRedValvetCake.Enabled = true;
                txtRedValvetCake.Text = "";
            }
            if (chkRedValvetCake.Checked == false)
            {
                txtRedValvetCake.Enabled = false;
                txtRedValvetCake.Text = "0";
            }
        }

        private void ChkBlackForestCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForestCake.Checked == true)
            {
                txtBlackForestCake.Enabled = true;
                txtBlackForestCake.Text = "";
            }
            if (chkBlackForestCake.Checked == false)
            {
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.Text = "0";
            }
        }

        private void ChkLagosCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagosCake.Checked == true)
            {
                txtLagosCake.Enabled = true;
                txtLagosCake.Text = "";
            }
            if (chkLagosCake.Checked == false)
            {
                txtLagosCake.Enabled = false;
                txtLagosCake.Text = "0";
            }
        }

        private void ChkKiburnCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiburnCake.Checked == true)
            {
                txtKiburnCake.Enabled = true;
                txtKiburnCake.Text = "";
            }
            if (chkKiburnCake.Checked == false)
            {
                txtKiburnCake.Enabled = false;
                txtKiburnCake.Text = "0";
            }
        }

        private void ChkBostonCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCake.Checked == true)
            {
                txtBostonCake.Enabled = true;
                txtBostonCake.Text = "";
            }
            if (chkBostonCake.Checked == false)
            {
                txtBostonCake.Enabled = false;
                txtBostonCake.Text = "0";
            }
        }

        private void ChkQueensCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueensCake.Checked == true)
            {
                txtQueensCake.Enabled = true;
                txtQueensCake.Text = "";
            }
            if (chkQueensCake.Checked == false)
            {
                txtQueensCake.Enabled = false;
                txtQueensCake.Text = "0";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtRecipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtRecipt.Clear();
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtRecipt.Cut();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtRecipt.Copy();
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtRecipt.Paste();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtxtRecipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Test";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtxtRecipt.Text);
            }
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            rtxtRecipt.Clear();
            rtxtRecipt.AppendText(Environment.NewLine);
            rtxtRecipt.AppendText("\t\t" + "Coffee House " + Environment.NewLine);
            rtxtRecipt.AppendText("-------------------------------------------------------" + Environment.NewLine);
            rtxtRecipt.AppendText("  African Coffee \t \t" + txtAfricanCoffee.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Cappuccino \t\t" + txtCappuccino.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Espresso \t\t" + txtEspresso.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Iced Cappuccino \t" + txtIcedCappuccino.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Iced Latte \t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Latte \t\t\t" + txtLatte.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Vale Coffee \t\t" + txtValeCoffee.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Red Valvet Cake \t" + txtRedValvetCake.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Queen's Cake \t\t" + txtQueensCake.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Lagos Cake \t\t" + txtLagosCake.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Kiburn Cake \t\t" + txtKiburnCake.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Coffee Cake \t\t" + txtCoffeeCake.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Black Forest Cake \t" + txtBlackForestCake.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Boston Cake \t\t" + txtBostonCake.Text + Environment.NewLine);
            rtxtRecipt.AppendText("------------------------------------------------------- " + Environment.NewLine);
            rtxtRecipt.AppendText("  Sub Total \t" + lblSubTotal.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Tax \t\t" + lblTax.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Service \t" + lblService.Text + Environment.NewLine);
            rtxtRecipt.AppendText("  Total \t\t" + lblTotal.Text + Environment.NewLine);
            rtxtRecipt.AppendText("------------------------------------------------------- " + Environment.NewLine);
            rtxtRecipt.AppendText(lblTime.Text + "  " + lblDate.Text + Environment.NewLine);

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            total();
        }

        private void total()
        {
            //total price of coffee
            

           double clatte = UpdatePrice.latte * Int32.Parse(txtLatte.Text);
            double cexpresso = UpdatePrice.espresso * Int32.Parse(txtEspresso.Text);
            double cvale = UpdatePrice.vale * Int32.Parse(txtValeCoffee.Text);
            double ccappu = UpdatePrice.cappu * Int32.Parse(txtCappuccino.Text);
            double cicedcappu = UpdatePrice.icedcappu * Int32.Parse(txtIcedCappuccino.Text);
            double cicedlatte = UpdatePrice.icedlatte * Int32.Parse(txtIcedLatte.Text);
            double camerican = UpdatePrice.american * Int32.Parse(txtAfricanCoffee.Text);

            double  total_drinks = clatte + cexpresso+ cvale+ ccappu+ cicedcappu+ cicedlatte + camerican;
            lblDrinksCost.Text = total_drinks.ToString();

            //total price of cake


           

            double ccoffCake = UpdatePrice.coffCake * Int32.Parse(txtCoffeeCake.Text);
            double cRValvetCake = UpdatePrice.RValvetCake * Int32.Parse(txtRedValvetCake.Text);
            double cBFCake = UpdatePrice.BFCake * Int32.Parse(txtBlackForestCake.Text);
            double clagosCake = UpdatePrice.lagosCake * Int32.Parse(txtLagosCake.Text);
            double ckiburnCake = UpdatePrice.kiburnCake * Int32.Parse(txtKiburnCake.Text);
            double cbostonCake = UpdatePrice.bostonCake * Int32.Parse(txtBostonCake.Text);
            double cqueenCake = UpdatePrice.queenCake * Int32.Parse(txtQueensCake.Text);

            double total_cakes = ccoffCake + cRValvetCake + cBFCake + clagosCake + ckiburnCake + cbostonCake + cqueenCake;
            lblCakesCost.Text = total_cakes.ToString();

            //sub total
            
           
            double sub_total = total_drinks + total_cakes;
            lblSubTotal.Text = sub_total.ToString();

            //tax

            double tax = (total_drinks + total_cakes) * 0.1;
            lblTax.Text = tax.ToString();

            //total
            double Service = 1.75;
            double total = sub_total + tax+ Service;
            lblTotal.Text = total.ToString();



        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
           
            rtxtRecipt.Clear();
            rtxtRecipt.AppendText(Environment.NewLine);
            rtxtRecipt.AppendText("\t\t" + "Coffee House " + Environment.NewLine);
            rtxtRecipt.AppendText("-------------------------------------------------------" + Environment.NewLine);
            rtxtRecipt.AppendText("  African Coffee \t \t" + UpdatePrice.american +"$"+ Environment.NewLine);
            rtxtRecipt.AppendText("  Cappuccino \t\t" + UpdatePrice.cappu  +"$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Espresso \t\t" + UpdatePrice.espresso  +"$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Iced Cappuccino \t" + UpdatePrice.icedcappu  +"$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Iced Latte \t\t" + UpdatePrice.icedlatte + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Latte \t\t\t" + UpdatePrice.latte + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Vale Coffee \t\t" + UpdatePrice.vale + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Red Valvet Cake \t" + UpdatePrice.RValvetCake + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Queen's Cake \t\t" + UpdatePrice.queenCake + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Lagos Cake \t\t" + UpdatePrice.lagosCake + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Kiburn Cake \t\t" + UpdatePrice.kiburnCake + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Coffee Cake \t\t" + UpdatePrice.coffCake + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Black Forest Cake \t" + UpdatePrice.BFCake + "$" + Environment.NewLine);
            rtxtRecipt.AppendText("  Boston Cake \t\t" + UpdatePrice.bostonCake + "$" + Environment.NewLine);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login l= new Login();
            l.Show();
            init();
            this.Hide();
            
        }

        private void LblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
