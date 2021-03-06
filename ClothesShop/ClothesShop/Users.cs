/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 20/04/2021
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesShop
{
	/// <summary>
	/// Description of Users.
	/// </summary>
	public partial class Users : Form
	{
		public Users()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			populate();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		SQLiteConnection conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		private void populate()
        {
			conn.Open();
			string query = "select * from Users";
			SQLiteCommand cmd = new SQLiteCommand(query, conn);
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			userDGV.DataSource = dt;
			conn.Close();
		}

		//click clothes menubar
        private void label6_Click(object sender, EventArgs e)
        {
			Clothes log = new Clothes();
			log.Show();
			this.Hide();
		}

		//exit button
        private void label11_Click(object sender, EventArgs e)
        {
			var result = MessageBox.Show("Are you sure you want to exit the app ?", "Exit", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		//click dashboard menubar
        private void Label8Click(object sender, EventArgs e)
		{
			Dashboard log = new Dashboard();
			log.Show();
			this.Hide();		
		}

		//click button logout
		private void Label9Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to logout ?", "Logout", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Login log = new Login();
				log.Show();
				this.Hide();
			}
		}
		
		void OrderClick(object sender, EventArgs e)
		{
			AdminOrder log = new AdminOrder();
            log.Show();
            this.Hide();
		}
    }
}
