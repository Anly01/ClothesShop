﻿/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 20/04/2021
 * Time: 16:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;

namespace ClothesShop
{
    /// <summary>
    /// Description of Dashboard.
    /// </summary>
    public partial class Clothes : Form
    {
        public Clothes()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        //click button exit
        private void label11_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        //click menubar user
        private void label7_Click(object sender, System.EventArgs e)
        {
            Users log = new Users();
            log.Show();
            this.Hide();
        }

        //click menubar dashboard
        private void label8_Click(object sender, System.EventArgs e)
        {
            Dashboard log = new Dashboard();
            log.Show();
            this.Hide();
        }

        //click button logout
        private void label9_Click(object sender, System.EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
