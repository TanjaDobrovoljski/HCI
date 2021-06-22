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
    public partial class AddingFormBook : Form
    {
        private string title = "";
        private string publishing_year = "";
        private string publisher = "";
        private string author = "";
        private string description = "";
        private string image = "";
        private string price="00.00";
        private int quantity=0;


        public AddingFormBook()
        {
            

            InitializeComponent();
        }

        private void AddingFormBook_Load(object sender, EventArgs e)
        {
            

            List<Publisher> list = PublisherDAO.Select();
            List<Author> list2 = AuthorDAO.Select();
            

            for (int i = 0; i < list.Count; i++)
                publisherComboBox.Items.Add(list[i].getName());

            for (int i = 0; i < list2.Count; i++)
                authorComboBox.Items.Add(list2[i].getFirstName()+" "+list2[i].getLastName());

            
            

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
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.publishingYearTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }

            }
            else if (publisherComboBox.SelectedIndex == -1)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.publisherComboBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.publisherComboBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }

            }
            else if (authorComboBox.SelectedIndex == -1)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.authorComboBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.authorComboBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else
            {
                title = titleTextBox.Text;
                publishing_year = publishingYearTextBox.Text;
                publisher = publisherComboBox.Text;
                author = authorComboBox.Text;
                string[] result = author.Split(' ');

               

                

                

                if (imageTextBox.Text == "")
                    image = "noimage";
                else
                    image = imageTextBox.Text;

                if (image.Contains("."))
                {

                    int index = image.IndexOf(".");
                    if (index > 0)
                        image = image.Substring(0, index);
                }
                Console.WriteLine(image);

                description = descriptionTextBox.Text;




                try
                {
                    BookDAO.Add_book(title, Int32.Parse(publishing_year), PublisherDAO.getByID(PublisherDAO.getID(publisher)), description, image, AuthorDAO.getByID(AuthorDAO.getID(result[0], result[1])));
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Knjiga je dodata!"); }
                    else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                        MessageBox.Show("Book is now added!");
                }
                catch (Exception)
                {
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Desila se greška!"); }
                    else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                        MessageBox.Show("Error happened!");
                    return;
                }

                Book b = new Book(title, Int32.Parse(publishing_year), PublisherDAO.getByID(PublisherDAO.getID(publisher)), description, image);
                Author author1 = new Author(result[0], result[1]);

                BookHasAuthorDAO.Insert(b, author1);

                

                

                titleTextBox.Text = "";
                publishingYearTextBox.Text = "";
                publisherComboBox.SelectedIndex = -1;
                authorComboBox.SelectedIndex = -1;

                imageTextBox.Text = "";
                descriptionTextBox.Text = "";

                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    DialogResult dialogResult = MessageBox.Show(" Do you want to add this book in Book StoreDa li želite dodati knjigu u određenu knjižaru?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        BookStoreSave4 f = new BookStoreSave4();
                        f.ShowDialog();
                    }
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    DialogResult dialogResult = MessageBox.Show(" Do you want to add this book in Book Store?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        BookStoreSave4 f = new BookStoreSave4();
                        f.ShowDialog();
                    }
                }

                this.Close();
                ActiveControl = this.titleTextBox;

            }
        }

        private void publishingYearTextBox_Enter(object sender, EventArgs e)
        {
            if (publishingYearTextBox.Text == "1999")
            {
                publishingYearTextBox.Text = "";
                publishingYearTextBox.ForeColor = Color.Black;
            }
        }

        private void publishingYearTextBox_Leave(object sender, EventArgs e)
        {
            if (publishingYearTextBox.Text == "")
            {
                publishingYearTextBox.Text = "1999";

                publishingYearTextBox.ForeColor = Color.Silver;
            }
        }

        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
            {
                if (descriptionTextBox.Text == "Možete dodati opis.(Nije neophodno!)")
                {
                    descriptionTextBox.Text = "";
                    descriptionTextBox.ForeColor = Color.Black;
                }
            }
            else if (Thread.CurrentThread.CurrentCulture.Name == "en")
            {

                if (descriptionTextBox.Text == "You can write description here.(It's not required!)")
                {
                    descriptionTextBox.Text = "";
                    descriptionTextBox.ForeColor = Color.Black;
                }
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    descriptionTextBox.Text = "Možete dodati opis.(Nije neophodno!)";

                    descriptionTextBox.ForeColor = Color.Silver;
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                { 

                descriptionTextBox.Text = "You can write description here.(It's not required!)";

                descriptionTextBox.ForeColor = Color.Silver;
                 }
            }
        }

        private void imageTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void imageTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
            {
                DialogResult dialogResult = MessageBox.Show(" Želite li sve obrisati?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    titleTextBox.Text = "";
                    publishingYearTextBox.Text = "";
                    publisherComboBox.SelectedIndex = -1;
                    authorComboBox.SelectedIndex = -1;

                    imageTextBox.Text = "";
                    descriptionTextBox.Text = "";
                }
            }
            else if (Thread.CurrentThread.CurrentCulture.Name == "en")
            {

                DialogResult dialogResult = MessageBox.Show(" Do you want to clear everything?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    titleTextBox.Text = "";
                    publishingYearTextBox.Text = "";
                    publisherComboBox.SelectedIndex = -1;
                    authorComboBox.SelectedIndex = -1;

                    imageTextBox.Text = "";
                    descriptionTextBox.Text = "";
                }
            }
            
           
        }
    }
}
