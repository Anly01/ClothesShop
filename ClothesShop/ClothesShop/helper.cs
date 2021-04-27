/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 27/04/2021
 * Time: 16:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Data.SQLite;
using System.Drawing;
namespace ClothesShop
	
{
	public class helper
	{
		public static bool isDigit(string x)
    	{	
    		foreach (char y in x)
    		{
    			if (y < '0' || y > '9')
    			{
    				return false;
    			}
    		}
    		
    		return true;
    	}
	}
}
