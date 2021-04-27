using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesShop
{
    public partial class AdminLogin : Form
    {
    	SQLAccess db = new SQLAccess();
    	
        public AdminLogin()
        {
            InitializeComponent();
            adminpasssword.PasswordChar = '●';
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
            string realPassword = SQLAccess.getAdminPassword();
            if (adminpasssword.Text == realPassword)
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

        private void showpasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            adminpasssword.PasswordChar = showpasswordBox.Checked ? '\0' : '●';
        }
    }
}
