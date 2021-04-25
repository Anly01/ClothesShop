using System;
using System.Collections;
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
            passwordBox.PasswordChar = '●';

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
            passwordBox.PasswordChar = showpasswordBox.Checked ? '\0' : '●';
        }

        static bool checkUsername(string username)
        {
            ArrayList usernameList = SQLAccess.getUsername();
            if (username == "")
            {
                MessageBox.Show("Fill your username");
                return false;
            }
            else if (usernameList.Contains(username))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool checkPassword(string userPass)
        {
            ArrayList passwordList = SQLAccess.getPassword();
            if (userPass == "")
            {
                MessageBox.Show("Fill your username");
                return false;
            }
            else if (passwordList.Contains(userPass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            ArrayList usernameList = SQLAccess.getUsername();

            if (checkUsername(username) && checkPassword(password)) 
            {
                Dashboard log = new Dashboard();
                log.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Username / Password");
            }
        }
    }
}
