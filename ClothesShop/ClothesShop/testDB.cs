/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 22/04/2021
 * Time: 14:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesShop
{
	/// <summary>
	/// Description of testDB.
	/// </summary>
	public partial class testDB : Form
	{
		public testDB()
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
			string connectionString;
		    SqlConnection cnn;
		    connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=ClothShopDb; Trusted_Connection=True";
		    cnn = new SqlConnection(connectionString);
		    cnn.Open();
		    MessageBox.Show("Connection Open  !");
		    cnn.Close();			
		}
	}
}
