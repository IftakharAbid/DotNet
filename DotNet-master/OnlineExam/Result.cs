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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }


        public static int totalmark = 0;
        private void Result_Load(object sender, EventArgs e)
        {
            
            
            if(Qustion1.mark1==1)
            {
                lblQ1Right.Visible = true;
                lblQ1Wrong.Visible = false;
                totalmark = totalmark + 14;
            }

            if (Qustion1.mark2 == 1)
            {
                lblQ2Right.Visible = true;
                lblQ2Wrong.Visible = false;
                totalmark = totalmark + 14;

            }

            if (Qustion1.mark3 == 1)
            {
                lblQ3Right.Visible = true;
                lblQ3Wrong.Visible = false;
                totalmark = totalmark + 14;
            }

            if (Qustion1.mark4 == 1)
            {
                lblQ4Right.Visible = true;
                lblQ4Wrong.Visible = false;
                totalmark = totalmark + 14;
            }

            if (Qustion1.mark5 == 1)
            {
                lblQ5Right.Visible = true;
                lblQ5Wrong.Visible = false;
                totalmark = totalmark + 14;
            }

            if (Question2.mark6 == 1)
            {
                lblQ6Right.Visible = true;
                lblQ6Wrong.Visible = false;
                totalmark = totalmark + 15;
            }

            if (Question3.mark7 == 1)
            {
                lblQ7Right.Visible = true;
                lblQ7Wrong.Visible = false;
                totalmark = totalmark + 15;


            }
            lblMark.Text = totalmark.ToString();
        }

        private void Lblmark2_Click(object sender, EventArgs e)
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
    }
}
