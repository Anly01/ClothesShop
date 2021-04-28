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
			s.DataSource = dt;
		    s.Columns["adminID"].Visible = false;

			DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
			imageCol.HeaderText = "Image";
			imageCol = (DataGridViewImageColumn)s.Columns[0];
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

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            usernamelbl.Text = Login.username + " !";
        }
    }
}
