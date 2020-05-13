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
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
           

        }

        private void AddBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBooks ab = new AddBooks();
            ab.Show();
        }

        private void ShowAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllBooks sab = new ShowAllBooks();
            sab.Show();


        }

      

        private void StudentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration sr = new StudentRegistration();
            sr.Show();

        }

       
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void LogOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void IssueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBook ib = new IssueBook();
            ib.Show();
        }

        private void MenuStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void AddBooksToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void BooksRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksRecord br = new BooksRecord();
            br.Show();
        }

        private void Home1_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangPassword cp = new ChangPassword();
            cp.Show();
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r = new Report();
            r.Show();
        }
    }
}
