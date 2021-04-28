using System;
using System.IO;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;

namespace ClothesShop
{
	/// <summary>
	/// Description of imgHelper.
	/// </summary>
	public class imgHelper
	{
		public static byte[] ImageToByte(Image img)
		{
			try
			{
			   	MemoryStream ms = new MemoryStream();
				img.Save(ms, img.RawFormat);
				return ms.ToArray();
			}
			catch
			{
				MemoryStream ms = new MemoryStream();
				Bitmap image = new Bitmap(img);
				image.Save(ms, ImageFormat.Bmp);
				return ms.ToArray();
			}
		}
		
		public static Image ByteToImage(byte[] bytes)
		{
			using (MemoryStream memstr = new MemoryStream(bytes))
		    {
		        Image img = Image.FromStream(memstr);
		        return img;
		    }
		}
		
		public static byte[] GetBytes(SQLiteDataReader reader)
	    {
	        const int CHUNK_SIZE = 2 * 1024;
	        byte[] buffer = new byte[CHUNK_SIZE];
	        long bytesRead;
	        long fieldOffset = 0;
	        using (MemoryStream stream = new MemoryStream())
	        {
	            while ((bytesRead = reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length)) > 0)
	            {
	                stream.Write(buffer, 0, (int)bytesRead);
	                fieldOffset += bytesRead;
	            }
	            return stream.ToArray();
	        }
	    }

	}
}
