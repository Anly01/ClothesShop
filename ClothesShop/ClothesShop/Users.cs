/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 20/04/2021
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesShop
{
	/// <summary>
	/// Description of Users.
	/// </summary>
	public partial class Users : Form
	{
		public Users()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		//click clothes menubar
        private void label6_Click(object sender, EventArgs e)
        {
			Clothes log = new Clothes();
			log.Show();
			this.Hide();
		}

		//exit button
        private void label11_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

		//click dashboard menubar
        private void label8_Click(object sender, EventArgs e)
        {
			Dashboard log = new Dashboard();
			log.Show();
			this.Hide();
		}
    }
}
