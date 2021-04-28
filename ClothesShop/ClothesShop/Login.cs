using System;
using System.Collections;
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

        public static string username = "";

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            ArrayList usernameList = SQLAccess.getUsername();
            if (username=="" && password == "")
            {
                MessageBox.Show("Input your username and password");
            } else
            {
                string query = "SELECT * FROM Users WHERE username= @user AND passwd= @password";
                SQLiteConnection conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query,conn);
                cmd.Parameters.AddWithValue("@user",usernameBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordBox.Text);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Products log = new Products();
                    log.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }


            }
        }
    }
}
