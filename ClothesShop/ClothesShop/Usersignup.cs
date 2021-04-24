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
using System.ComponentModel.DataAnnotations;

namespace ClothesShop
{
    public partial class Usersignup : Form
    {
    	static bool isDigit(string x)
    	{
    		foreach (char y in x)
    		{
    			if (y < '0' || y > '9')
    			{
    				return false;
    			}
    		}
    		
    		return true;
    	}
    	
    	static bool checkUsername(string currUsername)
    	{
    		ArrayList usernameList = SQLAccess.getUsername();
    		if (currUsername == "")
    		{
    			MessageBox.Show("Fill your username");
    			return false;
    		}
    		else if (usernameList.Contains(currUsername))
    		{
    			MessageBox.Show("Username already exist");
    			return false;
    		}
    		else
    		{
    			return true;
    		}
    	}
    	
    	static bool checkPassword(string password)
    	{
    		if (password.Length < 8)
    		{
    			MessageBox.Show("The password length have to be at least 8");
    			return false;
    		}
    		else
    		{
    			return true;
    		}
    	}
    	
    	static bool checkEmail(string email)
    	{
    		if (email == "")
    		{
    			MessageBox.Show("Fill out the Email Address");
    			return false;
    		}
    		else if (!(new EmailAddressAttribute().IsValid(email)))
    		{
    			MessageBox.Show("Invalid email");
    			return false;
    		}
    		else
    		{
    			return true;
    		}
    	}
    	
    	static bool checkPhone(string phone)
    	{
    		if (phone == "")
    		{
    			MessageBox.Show("Fill out the phone number");
    			return false;
    		}
    		else if (!(isDigit(phone)) || phone.Length < 7)
    		{
    			MessageBox.Show("Invalid phone number");
    			return false;
    		}
    		else
    		{
    			return true;
    		}
    	}
    	
    	static bool checkAddress(string address)
    	{
    		if (address == "")
    		{
    			MessageBox.Show("Fill out the address");
    			return false;
    		}
    		else
    		{
    			return true;
    		}
    	}
    	
    	
        public Usersignup()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '●';

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //click button login
        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        	string currUsername = usernameBox.Text.Trim();
        	string password = passwordBox.Text.Trim();
        	string email = emailBox.Text.Trim();
        	string phone = phoneBox.Text.Trim();
        	string address = addressBox.Text.Trim();

        	
        	if (checkUsername(currUsername) && checkPassword(password) &&
        	    checkEmail(email) && checkPhone(phone) && 
        	    checkAddress(address))
        	{
        		Login log = new Login();
            	log.Show();
           		this.Hide();
        	}
        }


        //show password check box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = showpasswordBox.Checked ? '\0' : '●';
        }
    }
}
