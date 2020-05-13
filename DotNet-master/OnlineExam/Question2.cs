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

    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            lblHelp.Visible = true;
            gbHelp.Visible = true;
            lblTitle.Visible = false;
            gbQues.Visible = false;



        }

        private void Question2_Load(object sender, EventArgs e)
        {
            lbltimes.Text = "Time Remaining: " + Help.count.ToString();

            lblHelp.Visible = false; 
            gbHelp.Visible = false;
            lblTitle.Visible = true;
            gbQues.Visible = true;

           

            rbA.Checked=Convert.ToBoolean(a) ;
            rbB.Checked=Convert.ToBoolean(b) ;
            rbC.Checked=Convert.ToBoolean(c) ;
            rbD.Checked=Convert.ToBoolean(d) ;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            lblHelp.Visible = false;
            gbHelp.Visible = false;
            lblTitle.Visible = true;
            gbQues.Visible = true;
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnResult_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are You sure to End exam now?You can not return to exam again", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                saveQ2ans();
                this.Hide();
                Result r = new Result();
                r.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the Program?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();
        }


        public static int mark6 = 0;
        
        public static string a;
        public static string b;
        public static string c;
        public static string d;
        private void BtnNext_Click(object sender, EventArgs e)
        {
            saveQ2ans();
            this.Hide();
            Question3 h = new Question3();
            h.Show();

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            saveQ2ans();
            this.Hide();
            Qustion1 h = new Qustion1();
            h.Show();

        }


        private void BtnReview_Click(object sender, EventArgs e)
        {
            saveQ2ans();
            this.Hide();
            Qustion1 h = new Qustion1();
            h.Show();
        }

        void saveQ2ans()
        {
            if (rbA.Checked == true)
            {
               
                mark6 = 1;
                a = rbA.Checked.ToString();
            }
            if (rbA.Checked != true)
            {
                mark6 = 0;
                a = null;
            }

            if (rbB.Checked == true)
            {
                mark6 = 0;
                b = rbB.Checked.ToString();
            }

            

            if (rbC.Checked == true)
            {
                mark6 = 0;
                c = rbC.Checked.ToString();
            }

            

            if (rbD.Checked == true)
            {
                mark6 = 0;
                c = rbD.Checked.ToString();
            }

            
        }

        private void BtnFlag_Click(object sender, EventArgs e)
        {

            var confirm = MessageBox.Show("Are You sure to End exam now?You can not return to exam again", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                saveQ2ans();
                this.Hide();
                Result r = new Result();
                r.Show();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbltimes.Text = "Time Remaining: " + Help.count.ToString();
        }
    }
}
