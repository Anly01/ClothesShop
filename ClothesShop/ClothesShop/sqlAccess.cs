using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

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
	}
}
