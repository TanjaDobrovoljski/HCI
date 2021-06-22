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
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.titleTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                
                {
                    ActiveControl = this.titleTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (publishingYearTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.publishingYearTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if(Thread.CurrentThread.CurrentCulture.Name == "en") 
                {
                    ActiveControl = this.publishingYearTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (publisherTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.publisherTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.publisherTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (authorTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.authorTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.authorTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            

            else
            {

                Book b = new Book(title);
                Book b2 = new Book(titleTextBox.Text, Int32.Parse(publishingYearTextBox.Text), PublisherDAO.getByID(PublisherDAO.getID(publisherTextBox.Text)), descriptionTextBox.Text, imageTextBox.Text);

                BookDAO.Update(b, b2);
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                { MessageBox.Show("Knjiga je uspiješno modifikovana!"); }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                    MessageBox.Show("Book successfuly updated!");

                this.Close();

            }
            }
    }
}
