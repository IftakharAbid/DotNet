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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button numbers = (Button)sender;
            if(lblDisplay.Text=="0")
            {
                lblDisplay.Text = numbers.Text;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + numbers.Text;
            }
                 
        }


        double Firstnumber;
        double Secondnumber;
        double Answer;
        string operat;
        private void Arithmetic_Operators(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            Firstnumber = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            operat = operation.Text;
            lblShowOperation.Text = System.Convert.ToString(Firstnumber) + " " + operat;

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            lblShowOperation.Text = "";
            Secondnumber = double.Parse(lblDisplay.Text);

            switch(operat)
            {

                case "+":
                    Answer = (Firstnumber + Secondnumber);
                    lblDisplay.Text = System.Convert.ToString(Answer);
                    break;

                case "-":
                    Answer = (Firstnumber - Secondnumber);
                    lblDisplay.Text = System.Convert.ToString(Answer);
                    break;

                case "/":
                    Answer = (Firstnumber / Secondnumber);
                    lblDisplay.Text = System.Convert.ToString(Answer);
                    break;

                case "*":
                    Answer = (Firstnumber * Secondnumber);
                    lblDisplay.Text = System.Convert.ToString(Answer);
                    break;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Length>0)
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            lblShowOperation.Text = "";
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Contains("."))
            {
                lblDisplay.Text = lblDisplay.Text + ".";
            }
        }
    }
}
