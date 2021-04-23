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
			SQLiteConnection conn;
		    conn = new SQLiteConnection("Data Source=birthdays.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO birthdays(name, day, month) VALUES('Rontin', 25, 12)", conn);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}
	}
}
