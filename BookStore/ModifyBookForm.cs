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
    public partial class ModifyBookForm : Form
    {
        private string title ;
        private string publishing_year ;
        private string publisher ;
        private string author;

        public ModifyBookForm(string title,string py,string publisher,string author,string description,string image)
        {
            InitializeComponent();
            this.title = title;
            titleTextBox.Text = title;
            publishingYearTextBox.Text = py;
            publisherTextBox.Text = publisher;
            authorTextBox.Text = author;
            imageTextBox.Text = image;
            descriptionTextBox.Text = description;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "")
            {
                ActiveControl = this.titleTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");
            }
            else if (publishingYearTextBox.Text == "")
            {
                ActiveControl = this.publishingYearTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (publisherTextBox.Text == "")
            {
                ActiveControl = this.publisherTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (authorTextBox.Text == "")
            {
                ActiveControl = this.authorTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (imageTextBox.Text == "")
            {
                ActiveControl = this.imageTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (descriptionTextBox.Text == "")
            {
                ActiveControl = this.descriptionTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            else
            {

                Book b = new Book(title);
                Book b2 = new Book(titleTextBox.Text, Int32.Parse(publishingYearTextBox.Text), PublisherDAO.getByID(PublisherDAO.getID(publisherTextBox.Text)), descriptionTextBox.Text, imageTextBox.Text);

                BookDAO.Update(b, b2);
                MessageBox.Show("Book successfuly updated!");

                this.Close();

            }
            }
    }
}
