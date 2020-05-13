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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 30)
            {
                this.Dispose(false);
                Home l = new Home();
                l.Show();
            }
        }
    }
}
