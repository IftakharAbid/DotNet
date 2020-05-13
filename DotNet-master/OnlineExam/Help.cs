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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        public static int count = 60;
       
        private void BtnOK_Click(object sender, EventArgs e)
        {
            
            var confirm =MessageBox.Show("Are You sure to start exam now?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirm==DialogResult.Yes)
            {
                MessageBox.Show("Your Time Starts now");
               timer1.Enabled = true;
                this.Hide();
                Qustion1 q1 = new Qustion1();
                q1.Show();

            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the Program?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (count > 50)
            {
                count--;
            }
            if (count == 50)
            {
                MessageBox.Show("Your Time is finished.Click OK to see result");
                
                timer1.Enabled = false;

                Result r = new Result();
                r.Show();
            }
        }
    }
}
