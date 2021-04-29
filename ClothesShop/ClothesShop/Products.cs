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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            populate();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
        private void populate()
        {
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
			conn.Open();
			SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Cloth", conn);
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dgvProduct.DataSource = dt;
		    dgvProduct.Columns["adminID"].Visible = false;

			DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
			imageCol.HeaderText = "Image";
			imageCol = (DataGridViewImageColumn)dgvProduct.Columns[0];
			imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

			/*SQLiteCommand cmd2 = new SQLiteCommand("SELECT image FROM Cloth", conn);
		    // cmd.CommandText = "SELECT image FROM Cloth";
		    SQLiteDataReader reader = cmd2.ExecuteReader();
		    while (reader.Read())
		    {
		    	byte[] buffer = imgHelper.GetBytes(reader);
		    	Image img = imgHelper.ByteToImage(buffer);
		    	dgvCloth.Rows[0].Cells[0].Value = new Bitmap(img);
		    	counter++;
		    }*/

			conn.Close();
		}
        
        private void reset()
        {
        	clothNameBox.Text = "";
        	size.Text = "";
        	priceBox.Text = "";
        	qtyBox.Text = "";
        	dgvProduct.ClearSelection();
        }
        
        static bool checkQty(string userQty, string itemQty)
        {
        	if (userQty == "")
        	{
        		MessageBox.Show("Please fill outthe quantity");
        		return false;
        	}
        	else if (!helper.isDigit(userQty))
        	{
        		MessageBox.Show("Please input the valid number");
        		return false;
        	}
        	else if (Convert.ToInt32(itemQty) - Convert.ToInt32(userQty) < 0)
        	{
        		MessageBox.Show("You can't buy more than that");
        		return false;
        	}
        	else
        	{
        		return true;
        	}
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            usernamelbl.Text = Login.username + " !";
        }


		//click wishlist button
        private void label8_Click(object sender, EventArgs e)
        {
			wishlist log = new wishlist();
			log.Show();
			this.Hide();
		}

		//click logout button
        private void label9_Click(object sender, EventArgs e)
        {
			Login log = new Login();
			log.Show();
			this.Hide();
        }
        
        // click order button
        void Label7Click(object sender, EventArgs e)
        {
			UserOrder log = new UserOrder();
        	log.Show();
        	this.Hide();         	
        }
        
		void DgvProductCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvProduct.SelectedRows.Count > 0)
			{
				int index = dgvProduct.CurrentCell.RowIndex;
				clothNameBox.Text = dgvProduct.Rows[index].Cells[2].Value.ToString();
				size.Text = dgvProduct.Rows[index].Cells[4].Value.ToString();
				priceBox.Text = dgvProduct.Rows[index].Cells[3].Value.ToString();
			}
		}

        private void addtowish_Click(object sender, EventArgs e)
        {
			int index = dgvProduct.CurrentCell.RowIndex;
			string id = dgvProduct.Rows[index].Cells[1].Value.ToString();
			string username = Login.username;
			ArrayList productList = SQLAccess.getWishlistProduct(username);
			
			if (!productList.Contains(Convert.ToInt32(id)))
			{
				SQLAccess.saveWishlistToDb(username, id);
			}
			else
			{
				MessageBox.Show("Already in wishlist");
			}
		}
        
        void DgvProductDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        	dgvProduct.ClearSelection();
        }
        
        void ResetBtnClick(object sender, EventArgs e)
        {
        	reset();
        }
        
        void OrderBtnClick(object sender, EventArgs e)
        {
        	if (dgvProduct.SelectedRows.Count > 0)
        	{
				int index = dgvProduct.CurrentCell.RowIndex;
        		string clothName = clothNameBox.Text;
        		string price = priceBox.Text;
        		string userQty = qtyBox.Text.Trim();
        		string sizes = size.Text;
        		string itemQty = dgvProduct.Rows[index].Cells[5].Value.ToString();
				string id = dgvProduct.Rows[index].Cells[1].Value.ToString();
				string username = Login.username;
        		
        		if (checkQty(userQty, itemQty))
        		{
        			int totalPrice = Convert.ToInt32(userQty) * Convert.ToInt32(price);
        			SQLAccess.saveOrderToDbAndUpdate(clothName, totalPrice, userQty, username, id, itemQty);
        			populate();
        		}
        	}
        	else
        	{
        		MessageBox.Show("Please select the product");
        	}
        }
        
        
    }
}
