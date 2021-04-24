/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 23/04/2021
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ClothesShop
{
	/// <summary>
	/// Description of TestDB2.
	/// </summary>
	public partial class TestDB2 : Form
	{
		public TestDB2()
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
			// CEK DI bin/debug/birthdays.db bakal ketambah Rontin, 25 ,12
			label1.Text = "";
			SQLiteConnection conn;
		    conn = new SQLiteConnection("Data Source=birthdays.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM birthdays", conn);
		    SQLiteDataReader reader = cmd.ExecuteReader();
		    
		    // Baca DB
		    while (reader.Read()) 
		    {
		    	label1.Text += string.Format("{0} {1} {2} {3}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),reader.GetInt32(3)) + Environment.NewLine;
		    }
		    
		    // Insert DB
		    cmd = new SQLiteCommand("INSERT INTO birthdays(name, day, month) VALUES('acun', 27, 12)", conn);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}
	}
}
