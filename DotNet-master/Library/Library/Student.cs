using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    
    public partial class Student : Form
    {
        bool flag;
        public Student()
        {
            InitializeComponent();
        }

        private void SearchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBook sb = new SearchBook();
            sb.Show();
            flag = true;
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangPassword cp = new ChangPassword();
            cp.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
