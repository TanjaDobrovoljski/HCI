using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ModifyPublisherForm : Form
    {
        private string name ;
        public ModifyPublisherForm(string name,string ad,string email, string phone,string books)
        {
            InitializeComponent();
            this.name = name;
            nameTextBox.Text = name;
            addressTextBox.Text = ad;
            emailTextBox.Text = email;
            phoneTextBox.Text = phone;
            booksTextBox.Text = books;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                ActiveControl = this.nameTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");
            }
            else if (addressTextBox.Text == "")
            {
                ActiveControl = this.addressTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (emailTextBox.Text == "")
            {
                ActiveControl = this.emailTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            else if (phoneTextBox.Text == "")
            {
                ActiveControl = this.phoneTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            

            else
            {

                Publisher p = new Publisher(name);
                Publisher p2 = new Publisher(nameTextBox.Text, addressTextBox.Text, emailTextBox.Text, phoneTextBox.Text);
                PublisherDAO.Update(p, p2);
                MessageBox.Show("Publisher successfuly updated!");

                this.Close();

            }

            }
    }
}
