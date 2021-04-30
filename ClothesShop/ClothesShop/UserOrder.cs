/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 29/04/2021
 * Time: 14:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
	/// <summary>
	/// Description of UserOrder.
	/// </summary>
	public partial class UserOrder : Form
	{
		public UserOrder()
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
		
		void Label11Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to exit the app ?", "Exit", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			Products log = new Products();
            log.Show();
            this.Hide();
		}
		
		void Label8Click(object sender, EventArgs e)
		{
			wishlist log = new wishlist();
			log.Show();
			this.Hide();			
		}
		
		
		
		void Label9Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to logout ?", "Logout", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Login log = new Login();
				log.Show();
				this.Hide();
			}
		}
		
		void UserOrder_Load(object sender, EventArgs e)
		{
			usernamelbl.Text = Login.username + " !";
		}
		
		private void populate()
		{
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
			conn.Open();
			SQLiteCommand cmd = new SQLiteCommand("SELECT image, Orders.productID, Orders.name, Orders.price, Orders.quantity FROM Orders JOIN Cloth ON Cloth.productID = Orders.productID WHERE username = @username", conn);
            cmd.Parameters.AddWithValue("@username", Login.username);
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dgvUserOrder.DataSource = dt;

			DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
			imageCol.HeaderText = "Image";
			imageCol = (DataGridViewImageColumn)dgvUserOrder.Columns[0];
			imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
			
			conn.Close();
		}
	}
}
