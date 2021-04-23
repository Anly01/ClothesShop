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
    public partial class peopleform : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public peopleform()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = people;
            listPeopleListBox.DisplayMember = "FullName";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;

            SqliteDataAccess.SavePerson(p);
            firstNameText.Text = "";
            lastNameText.Text = "";

        }
    }
}
