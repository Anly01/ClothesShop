using System;
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
    public partial class wishlist : Form
    {
        public wishlist()
        {
            InitializeComponent();
            populate();
        }

        private void wishlist_Load(object sender, EventArgs e)
        {
            usernamelbl.Text = Login.username + " !";
        }

        private void populate()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT image, name, size, price FROM Wishlist JOIN Cloth ON Cloth.productID = Wishlist.productID WHERE username = @username", conn);
            cmd.Parameters.AddWithValue("@username", Login.username);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvWishlist.DataSource = dt;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.HeaderText = "Image";
            imageCol = (DataGridViewImageColumn)dgvWishlist.Columns[0];
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

        //click X button
        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //click product button
        private void label6_Click(object sender, EventArgs e)
        {
            Products log = new Products();
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
		
        void Label7Click(object sender, EventArgs e)
        {
			UserOrder log = new UserOrder();
        	log.Show();
        	this.Hide();        	
        }

        
        void DgvWishlistDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
			dgvWishlist.ClearSelection();
        }
        
        
    }
}
