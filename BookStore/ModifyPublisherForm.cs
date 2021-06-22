using BookStore.Model;
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

                Publisher p = new Publisher(name);
                Publisher p2 = new Publisher(nameTextBox.Text, addressTextBox.Text, emailTextBox.Text, phoneTextBox.Text);
                PublisherDAO.Update(p, p2);
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                { MessageBox.Show("Izdavač je uspiješno modifikovan!"); }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                    MessageBox.Show("Publisher successfuly updated!");

                this.Close();

            }

            }
    }
}
