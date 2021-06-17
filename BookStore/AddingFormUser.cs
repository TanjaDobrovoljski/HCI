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
    public partial class AddingFormUser : Form
    {
        private string username="";
        private string password="";
        private string bookStore="";
        public AddingFormUser()
        {
            InitializeComponent();
            

        }
        
        private void AddingFormUser_Load(object sender, EventArgs e)
        {
            List<BookStore1> b = BookStoreDAO.Select();
            for (int i = 0; i < b.Count; i++)
                bookstoreBox.Items.Add(b[i].getName());


        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "")
            {
                ActiveControl = this.usernameTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");
            }
            else if (passwordTextBox.Text == "")
            {
                ActiveControl = this.passwordTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (bookstoreBox.SelectedIndex==-1)
            {
                ActiveControl = this.bookstoreBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

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
                        MessageBox.Show("User is now added!");
                        this.Close();
                        
                        
                    }
                    catch (Exception)
                    {
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
