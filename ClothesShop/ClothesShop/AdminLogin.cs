using System;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //click user login
        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        //click login button
        private void button1_Click(object sender, EventArgs e)
        {
            adminpasssword.PasswordChar = '*';
            if (adminpasssword.Text =="admin")
            {
                Clothes log = new Clothes();
                log.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
