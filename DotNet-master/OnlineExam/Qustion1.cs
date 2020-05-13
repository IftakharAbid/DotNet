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
    public partial class Qustion1 : Form
    {
        public Qustion1()
        {
            InitializeComponent();
        }


       
        private void Timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            //btnTimer.Visible = false;
            //lblTimer.Visible = false;
            //lblTimerCover.Visible = true;
            //btnClock.Visible = true;
        }

        private void BtnClock_Click(object sender, EventArgs e)
        {
            //btnTimer.Visible = true;
            //lblTimer.Visible = true;
            //lblTimerCover.Visible = false;
            //btnClock.Visible = false;
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
            
        }

        public static string ans1 = "";
        public static string ans2 = "";
        public static string ans3 = "";
        public static string ans4 = "";
        public static string ans5 = "";
        private void BtnNext_Click(object sender, EventArgs e)
        {
            saveQ1ans();
            this.Hide();
            Question2 h = new Question2();
            h.Show();
        }

        public void saveQ1ans()
        {
            if (txtq1.Text == "10")
            {
              
                mark1 = 1;
            }

            if (txtq1.Text != "10")
            {
                mark1 = 0;
            }

            if (txtq2.Text == "10")
            {
              
                mark2 = 1;
            }

            if (txtq2.Text != "10")
            {
                mark2 = 0;
            }

            if (txtq3.Text == "10")
            {
              
                mark3 = 1;
            }

            if (txtq3.Text != "10")
            {
                mark3 = 0;
            }

            if (txtq4.Text == "10")
            {
                mark4 = 1;
            }

            if (txtq4.Text != "10")
            {
                mark4 = 0;
            }

            if (txtq5.Text == "10")
            {
               
                mark5 = 1;
            }

            if (txtq5.Text != "10")
            {
                mark5 = 0;
            }

            ans1 = txtq1.Text;
            ans2 = txtq2.Text;
            ans3 = txtq3.Text;
            ans4 = txtq4.Text;
            ans5 = txtq5.Text;

        }
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            saveQ1ans();
            Question3 q3 = new Question3();
            q3.Show();
            this.Hide();

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            lblHelp.Visible = true;
            gbHelp.Visible = true;
            lblTitle.Visible = false;
            gbQues.Visible = false;

        }

        private void LblHelp_Click(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            lblHelp.Visible = false;
            gbHelp.Visible = false;
            lblTitle.Visible = true;
            gbQues.Visible = true;
        }

        private void Qustion1_Load(object sender, EventArgs e)
        {

            lbltimes.Text = "Time Remaining: " + Help.count.ToString();

            lblHelp.Visible = false;
            gbHelp.Visible = false;
            lblTitle.Visible = true;
            gbQues.Visible = true;

            txtq1.Text = ans1;
            txtq2.Text = ans2;
            txtq3.Text = ans3;
            txtq4.Text = ans4;
            txtq5.Text = ans5;
        }

        private void Txtq1_TextChanged(object sender, EventArgs e)
        {

        }

        public static int marks=0;
        public static int mark1=0;
        public static int mark2=0;
        public static int mark3=0;
        public static int mark4=0;
        public static int mark5=0;
         
        
        
        private void BtnResult_Click(object sender, EventArgs e)
        {
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure to close the Program?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnReview_Click(object sender, EventArgs e)
        {
            saveQ1ans();
            this.Show();
        }

        private void BtnFlag_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are You sure to End exam now?You can not return to exam again", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                saveQ1ans();
                this.Hide();
                Result r = new Result();
                r.Show();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbltimes.Text = "Time Remaining: " + Help.count.ToString();
        }
    }
}
