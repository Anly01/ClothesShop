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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            userpassword.PasswordChar = '●';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //click on admin login
        private void label7_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Usersignup log = new Usersignup();
            log.Show();
            this.Hide();
        }

        private void showpasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            userpassword.PasswordChar = showpasswordBox.Checked ? '\0' : '●';
        }
    }
}
