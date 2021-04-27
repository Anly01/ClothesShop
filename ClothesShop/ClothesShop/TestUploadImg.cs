/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 25/04/2021
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SQLite;
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
				Image img = new Bitmap(open.FileName);    
			    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			    pictureBox1.Image = img; 
			}  
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Image img = pictureBox1.Image;
			byte[] test = imgHelper.ImageToByte(img);
			
			SQLiteConnection conn;
		    conn = new SQLiteConnection("Data Source=TestImg.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = conn.CreateCommand();
		    cmd.CommandText = "INSERT INTO image(img) VALUES(@0)";
		    SQLiteParameter parameter = new SQLiteParameter("@0", System.Data.DbType.Binary);
			parameter.Value = test;
			cmd.Parameters.Add(parameter);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=TestImg.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM image", conn);
		    SQLiteDataReader reader = cmd.ExecuteReader();
		    while (reader.Read())
		    {
		    	byte[] buffer = imgHelper.GetBytes(reader);
		    	pictureBox1.Image = imgHelper.ByteToImage(buffer);
		    }
		    conn.Close();
			
		    
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				label1.Text = "testos";
			}
		}
	}
}
