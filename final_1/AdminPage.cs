﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_1
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGame g = new AddGame();
            g.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpDateAdmin A = new UpDateAdmin();
            A.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGame ug = new UpdateGame();
            ug.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPage AP = new AdminPage();
            AP.Close();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVendor v = new AddVendor();
            v.Show();
            this.Hide();
        }
    }
}
