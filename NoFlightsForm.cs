﻿using System;
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
    public partial class NoFlightsForm : Form
    {
        public NoFlightsForm()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Form1 appForm = new Form1();
            this.Hide();
            appForm.Show();
        }
    }
}
