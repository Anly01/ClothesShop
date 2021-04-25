/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 25/04/2021
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClothesShop
{
	/// <summary>
	/// Description of TestUploadImg.
	/// </summary>
	public partial class TestUploadImg : Form
	{
		public TestUploadImg()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Select your image to upload";
			open.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (open.ShowDialog() == DialogResult.OK) 
			{
			    // display image in picture box
				Bitmap img = new Bitmap(open.FileName);		    
			    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			    pictureBox1.Image = img; 
			}  
		}
	}
}
