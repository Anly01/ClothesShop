using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;

namespace ClothesShop
{
	public class SQLAccess
	{
		public static string getAdminPassword()
		{
			string password = "";
			
			SQLiteConnection conn;
		    conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Admin", conn);
		    SQLiteDataReader reader = cmd.ExecuteReader();
		    while (reader.Read())
		    {
		    	password = reader.GetString(2);
		    }
		    conn.Close();
		    return password;
		}
		
		// Get list of username
		public static ArrayList getUsername()
		{
			ArrayList usernameList = new ArrayList();
			string username = "";
			
			SQLiteConnection conn;
		    conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Users", conn);
		    SQLiteDataReader reader = cmd.ExecuteReader();
		    while (reader.Read())
		    {
		    	username = reader.GetString(0);
		    	usernameList.Add(username);
		    }
		    conn.Close();
		    
		    return usernameList;
		}

		public static ArrayList getPassword()
		{
			ArrayList passwordList = new ArrayList();
			string password = "";

			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
			conn.Open();
			SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Users", conn);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				password = reader.GetString(4);
				passwordList.Add(password);
			}
			conn.Close();

			return passwordList;
		}

		public static void signUpDataToDb(string username, string fullName, 
		                                  string address, string phone, 
		                                  string password, string gender,
		                                  string email, string birthday)
		{
			string query = string.Format("INSERT INTO Users(username, full_name, address, phone, passwd" +
			                            ", gender, email, birthday) VALUES('{0}','{1}', '{2}', '{3}'" +
			                            ", '{4}', '{5}', '{6}', '{7}')", username, fullName, address, phone, password, 
			                            gender, email, birthday);
			
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand(query, conn);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}
		
		public static void saveClothToDb(Image img, string clothName, string price,
		                                 string size, string qty)
		{
			int quantity = Convert.ToInt32(qty);
			int price2 = Convert.ToInt32(price);
			int adminID = 1;
			string query = "INSERT INTO Cloth(image, name, price, size, quantity, adminID) VALUES(@img, @name, @price, @size, @qty, @adminID)";
			
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand(query, conn);
		    SQLiteParameter parameter = new SQLiteParameter("@img", DbType.Binary);
			parameter.Value = imgHelper.ImageToByte(img);
			cmd.Parameters.Add(parameter);
		    cmd.Parameters.AddWithValue("@name", clothName);
		    cmd.Parameters.AddWithValue("@price", price2);
		    cmd.Parameters.AddWithValue("@size", size);
		    cmd.Parameters.AddWithValue("@qty", quantity);
		    cmd.Parameters.AddWithValue("@adminID", adminID);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}
		
		public static void editClothDb(string id, Image img, string clothName, string price,
		                                 string size, string qty)
		{
			int id2 = Convert.ToInt32(id);
			int quantity = Convert.ToInt32(qty);
			int price2 = Convert.ToInt32(price);
			string query = "UPDATE Cloth SET image = @img, name = @name, price = @price, size = @size, quantity = @qty WHERE productID = @id";
			
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand(query, conn);
		    SQLiteParameter parameter = new SQLiteParameter("@img", DbType.Binary);
			parameter.Value = imgHelper.ImageToByte(img);
			cmd.Parameters.Add(parameter);
		    cmd.Parameters.AddWithValue("@name", clothName);
		    cmd.Parameters.AddWithValue("@price", price2);
		    cmd.Parameters.AddWithValue("@size", size);
		    cmd.Parameters.AddWithValue("@qty", quantity);
		    cmd.Parameters.AddWithValue("@id", id2);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}
		
		public static void deleteClothDb(string id)
		{
			int id2 = Convert.ToInt32(id);
			string query = "DELETE FROM Cloth WHERE productID = @id";
			
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand(query, conn);
		    cmd.Parameters.AddWithValue("@id", id2);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}

		public static void saveWishlistToDb(string username, string id)
		{
			int id3 = Convert.ToInt32(id);
			string query = "INSERT INTO Wishlist(username, productID) VALUES(@username, @id)";
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
			conn.Open();
			SQLiteCommand cmd = new SQLiteCommand(query, conn);
			cmd.Parameters.AddWithValue("@username", username);
			cmd.Parameters.AddWithValue("@id", id3);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public static void deleteWishlist(string username, string id)
		{
			int id4 = Convert.ToInt32(id);
			string query = "DELETE FROM Wishlist WHERE username = @username AND productID = @id";

			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
			conn.Open();
			SQLiteCommand cmd = new SQLiteCommand(query, conn);
			cmd.Parameters.AddWithValue("@username", username);
			cmd.Parameters.AddWithValue("@id", id4);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public static void saveOrderToDbAndUpdate(int totalPrice, string userQty, string username, string id, string itemQty)
		{
			int id2 = Convert.ToInt32(id);
			int userQty2 = Convert.ToInt32(userQty);
			string query = "INSERT INTO Orders(price, quantity, username, productID) VALUES(@price, @qty, @username, @id)";
			
			SQLiteConnection conn;
			conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand(query, conn);
		    cmd.Parameters.AddWithValue("@price", totalPrice);
		    cmd.Parameters.AddWithValue("@qty", userQty2);
		    cmd.Parameters.AddWithValue("@username", username);
		    cmd.Parameters.AddWithValue("@id", id2);
		    cmd.ExecuteNonQuery();
		    
		    int currQty = Convert.ToInt32(itemQty) - Convert.ToInt32(userQty); 
		    query = "UPDATE Cloth SET quantity = @qty WHERE productID = @id";
		    cmd.CommandText = query;
		    cmd.Parameters.AddWithValue("@qty", currQty);
		    cmd.Parameters.AddWithValue("@id", id2);
		    cmd.ExecuteNonQuery();
		    conn.Close();
		}
		
		public static ArrayList getWishlistProduct(string username)
		{
			ArrayList productList = new ArrayList();
			int productID = 0;
			
			SQLiteConnection conn;
		    conn = new SQLiteConnection("Data Source=ClothShop.db;Version=3;");
		    conn.Open();
		    SQLiteCommand cmd = new SQLiteCommand("SELECT productID FROM Wishlist WHERE username = @username", conn);
		    cmd.Parameters.AddWithValue("@username", username);
		    SQLiteDataReader reader = cmd.ExecuteReader();
		    while (reader.Read())
		    {
		    	productID = reader.GetInt32(0);
		    	productList.Add(productID);
		    }
		    conn.Close();
		    
		    return productList;
		}
	}
}
