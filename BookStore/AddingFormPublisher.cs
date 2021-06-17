using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Model;

namespace BookStore
{
    public partial class AddingFormPublisher : Form
    {
        private string name = "";
        private string address = "";
        private string email = "";
        private string phone = "";

        public AddingFormPublisher()
        {
            InitializeComponent();
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

                name = nameTextBox.Text;
                address = addressTextBox.Text;
                email = emailTextBox.Text;
                phone = phoneTextBox.Text;

                Publisher p = new Publisher(name, address, email, phone);
                if (PublisherDAO.Check_publisher(p)==false)
                {
                    PublisherDAO.Add_publisher(name, address, email, phone);
                    MessageBox.Show("Publisher is now added!");
                    nameTextBox.Text = "";
                    addressTextBox.Text = "";
                    emailTextBox.Text = "";
                    phoneTextBox.Text = "";
                    ActiveControl = this.nameTextBox;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("This publisher already exist");
                    nameTextBox.Text = "";
                    addressTextBox.Text = "";
                    emailTextBox.Text = "";
                    phoneTextBox.Text = "";
                    ActiveControl = this.nameTextBox;
                }
            }

            }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear all data?", "Clearing", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nameTextBox.Text = "";
                addressTextBox.Text = "";
                emailTextBox.Text = "";
                phoneTextBox.Text = "";
                ActiveControl = this.nameTextBox;
            }
        }
    }
}
