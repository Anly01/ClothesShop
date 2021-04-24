using System;
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
		    
		    return password;
		}
	}
}
