﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesShop
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        //click button exit
        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Click Clothes Menubar
        private void label6_Click(object sender, EventArgs e)
        {
            Clothes log = new Clothes();
            log.Show();
            this.Hide();
        }
        //click User Menu Bar
        private void label7_Click(object sender, EventArgs e)
        {
            Users log = new Users();
            log.Show();
            this.Hide();
        }

        //click button logout
        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}