using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyPrivate
{
    public partial class SuccessForm : Form
    {
        public SuccessForm()
        {
            InitializeComponent();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookSuccessful bookSForm = new BookSuccessful();
            bookSForm.Show();
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBackToApplicationBtn_Click(object sender, EventArgs e)
        {
            Form1 appForm = new Form1();
            this.Hide();
            appForm.ShowDialog();
        }
    }
}
