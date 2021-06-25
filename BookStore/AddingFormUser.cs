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
    public partial class AddingFormUser : Form
    {
        private string username="";
        private string password="";
        private string bookStore="";
        public AddingFormUser()
        {
            InitializeComponent();
            ActiveControl = this.usernameTextBox;

        }
        
        private void AddingFormUser_Load(object sender, EventArgs e)
        {
            List<BookStore1> b = BookStoreDAO.Select();
            for (int i = 0; i < b.Count; i++)
                bookstoreBox.Items.Add(b[i].getName());
            ActiveControl = this.usernameTextBox;


        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.usernameTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                { 
                ActiveControl = this.usernameTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");
            }
            }
            else if (passwordTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.passwordTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.passwordTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (bookstoreBox.SelectedIndex==-1)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.bookstoreBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.bookstoreBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            
            else
            {
                username = usernameTextBox.Text;
                password = passwordTextBox.Text;
                bookStore = bookstoreBox.Text;

                if (UserDAO.Check_user(username, password) == false && UserDAO.Check_Username(username) == false)
                {
                    User u = new User(username, password, 2);
                    try
                    {
                        UserDAO.Insert(u);
                        BookStoreHasUserDAO.Insert(BookStoreDAO.getByID(BookStoreDAO.getID(bookstoreBox.Text)), u);
                        if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                        { MessageBox.Show("Korisnik je dodan!"); }
                        else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                            MessageBox.Show("User is now added!");
                        ActiveControl = this.usernameTextBox;
                        this.Close();
                        
                        
                    }
                    catch (Exception)
                    {
                        if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                        { MessageBox.Show("Desila se greška!"); }
                        else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                            MessageBox.Show("Error happened!");
                        return;
                    }
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    bookstoreBox.SelectedIndex = -1;
                    ActiveControl = this.usernameTextBox;
                }
                else
                {
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Korisnik već postoji"); }
                    else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                        MessageBox.Show("This user already exist");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    bookstoreBox.SelectedIndex = -1;
                    ActiveControl = this.usernameTextBox;
                }
                }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
            {
                if (MessageBox.Show("Želite li sve obrisati?", "Brisanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    bookstoreBox.SelectedIndex = -1;
                    ActiveControl = this.usernameTextBox;
                }
            }
            else if (Thread.CurrentThread.CurrentCulture.Name == "en")
            {
                if (MessageBox.Show("Do you want to clear all data?", "Clearing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    bookstoreBox.SelectedIndex = -1;
                    ActiveControl = this.usernameTextBox;
                }
            }
        }
    }
}
