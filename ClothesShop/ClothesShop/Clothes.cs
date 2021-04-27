/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 20/04/2021
 * Time: 16:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Data.SQLite;
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
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
		
        static bool checkSize(string size)
        {
        	if (size == "Size")
        	{
        		MessageBox.Show("Please choose the size");
        		return false; 
        	}
        	
        	return true;
        }
        
        static bool checkImg(Image img)
        {
        	if (img == null)
        	{
        		MessageBox.Show("Please upload the image");
        		return false; 
        	}
        	
        	return true;
        }
        
        static bool checkNumber(string num)
        {
        	if (num == "")
        	{
        		MessageBox.Show("Fill out the quantity and price");
        		return false;
        	}
        	else if (!helper.isDigit(num))
        	{
        		MessageBox.Show("Please input the number at quantity and price");
        		return false;
        	}
        	
        	return true;
        }
        
        static bool checkClothName(string clothName)
    	{
    		if (clothName == "")
    		{
    			MessageBox.Show("Fill out the cloth name");
    			return false;
    		}
    		
    		return true;
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
		
		void SaveBtnClick(object sender, System.EventArgs e)
		{
			Image img = clothImg.Image;
			string clothName = clothNameBox.Text.Trim();
			string size = sizeBox.Text.Trim();
			string qty = qtyBox.Text.Trim();
			string price = priceBox.Text.Trim();
			
			if (checkImg(img) && checkClothName(clothName) && checkSize(size) &&
			    checkNumber(qty) && checkNumber(price))
			{
				MessageBox.Show("Nice");
			}
		}
		
		void UploadBtnClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Select your image to upload";
			open.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (open.ShowDialog() == DialogResult.OK) 
			{
			    // display image in picture box
				Image img = new Bitmap(open.FileName);    
			    clothImg.SizeMode = PictureBoxSizeMode.Zoom;
			    clothImg.Image = img;
			}		
		}
		
		void ResetBtnClick(object sender, EventArgs e)
		{
			clothImg.Image = null;
			clothNameBox.Text = "";
			qtyBox.Text = "";
			sizeBox.Text = "Size";
			priceBox.Text = "";
		}
    }
}
