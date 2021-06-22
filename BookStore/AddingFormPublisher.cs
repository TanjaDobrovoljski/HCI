using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.nameTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                { 
                ActiveControl = this.nameTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");
            }
            }
            else if (addressTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.addressTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.addressTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (emailTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.emailTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.emailTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }

            else if (phoneTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.phoneTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.phoneTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
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
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Izdavač je dodan!"); }
                    else if (Thread.CurrentThread.CurrentCulture.Name == "en")
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
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Izdavač već postoji"); }
                     else if (Thread.CurrentThread.CurrentCulture.Name == "en")

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
            if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
            {
                if (MessageBox.Show("Da li želite sve obrisati?", "Brisanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    nameTextBox.Text = "";
                    addressTextBox.Text = "";
                    emailTextBox.Text = "";
                    phoneTextBox.Text = "";
                    ActiveControl = this.nameTextBox;
                }
            }
            else if (Thread.CurrentThread.CurrentCulture.Name == "en")
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
}
