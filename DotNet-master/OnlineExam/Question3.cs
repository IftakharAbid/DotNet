using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExam
{
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            lblHelp.Visible = false;
            gbHelp.Visible = false;
            lblTitle.Visible = true;
            gbQues.Visible = true;
        }

        private void Question3_Load(object sender, EventArgs e)
        {

           lbltimes.Text = "Time Remaining: " + Help.count.ToString();

            lblHelp.Visible = false;
            gbHelp.Visible = false;
            lblTitle.Visible = true;
            gbQues.Visible = true;

           

            cbA.Checked = Convert.ToBoolean(checka);
            cbB.Checked = Convert.ToBoolean(checkb);
            cbC.Checked = Convert.ToBoolean(checkc);
            cbD.Checked = Convert.ToBoolean(checkd);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            lblHelp.Visible = true;
            gbHelp.Visible = true;
            lblTitle.Visible = false;
            gbQues.Visible = false;

        }

        public static int mark7=0;

        private void BtnResult_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question2 h = new Question2();
            h.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the Program?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();

        }

        public static string checka = null;
        public static string checkb = null;
        public static string checkc = null;
        public static string checkd = null;
        private void Button1_Click(object sender, EventArgs e)
        {
            saveQ3ans();
            this.Hide();
            Qustion1 h = new Qustion1();
            h.Show();
        }


        void saveQ3ans()
        {
            if (cbA.Checked == true && cbB.Checked == true)
            {
                
                mark7 = 1;
                checka = cbA.Checked.ToString();
                checkb = cbB.Checked.ToString();
            }

            if (cbA.Checked != true && cbB.Checked != true)
            {
                mark7 = 0;
                checka = null;
                checkb = null;

                if (cbA.Checked == true)
                {
                    mark7 = 0;
                    checka = cbA.Checked.ToString();
                }
                
                if (cbB.Checked == true)
                {
                    mark7 = 0;
                    checkb = cbB.Checked.ToString();
                }
                
                if (cbC.Checked == true)
                {
                    mark7 = 0;
                    checkc = cbC.Checked.ToString();
                }
                

                if (cbD.Checked == true)
                {
                    mark7 = 0;
                    checkd = cbD.Checked.ToString();
                }
                
            }

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            saveQ3ans();
            this.Hide();
           Question2 h = new Question2();
            h.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            saveQ3ans();
            this.Hide();
            Qustion1 h = new Qustion1();
            h.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are You sure to End exam now?You can not return to exam again", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                saveQ3ans();
                this.Hide();
                Result r = new Result();
                r.Show();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbltimes.Text = "Time Remaining: " + Help.count.ToString();
        }
    }
}
