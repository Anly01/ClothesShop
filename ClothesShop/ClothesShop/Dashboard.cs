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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        //click button exit
        private void label11_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the app ?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Click Clothes Menubar
        private void label6_Click(object sender, EventArgs e)
        {
            Clothes log = new Clothes();
            log.Show();
            this.Hide();
        }
        //click User Menu Bar
        private void label7_Click(object sender, EventArgs e)
        {
            Users log = new Users();
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
        
        private void OrderClick(object sender, EventArgs e)
        {
        	AdminOrder log = new AdminOrder();
            log.Show();
            this.Hide();	
        }
       
        SQLiteConnection conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
        private void Dashboard_Load(object sender, EventArgs e)
        {
;           conn.Open();
            // untuk total stock
            SQLiteCommand cmdStock = new SQLiteCommand("select sum(quantity) from Cloth", conn);
            SQLiteDataAdapter adapterStock = new SQLiteDataAdapter(cmdStock);
            DataTable clothesstock = new DataTable();
            adapterStock.Fill(clothesstock) ;
            ClothesStock.Text = clothesstock.Rows[0][0].ToString();

            //untuk total user
            SQLiteCommand cmdUser = new SQLiteCommand("select count(*) from Users", conn);
            SQLiteDataAdapter adapterUser = new SQLiteDataAdapter(cmdUser);
            DataTable usertotal = new DataTable();
            adapterUser.Fill(usertotal);
            ourUser.Text = usertotal.Rows[0][0].ToString();
            conn.Close();

            //untuk total amount uang
            SQLiteCommand cmdAmount = new SQLiteCommand("select sum(price) from Orders", conn);
            SQLiteDataAdapter adapterAmount = new SQLiteDataAdapter(cmdAmount);
            DataTable amount = new DataTable();
            adapterAmount.Fill(amount);
            amountLbl.Text = amount.Rows[0][0].ToString();
            conn.Close();

            //untuk total order
            SQLiteCommand cmdOrder = new SQLiteCommand("select count(*) from Orders", conn);
            SQLiteDataAdapter adapterOrder = new SQLiteDataAdapter(cmdOrder);
            DataTable order = new DataTable();
            adapterOrder.Fill(order);
            amountOrder.Text = order.Rows[0][0].ToString();
            conn.Close();
        }
        
       
    }
}
