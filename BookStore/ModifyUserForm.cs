using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookStore
{
    public partial class ModifyUserForm : Form
    {
        private string username;
        private string password;
        private string bookStore;
        private string bookStore_modify;

        public ModifyUserForm(string username, string password, string bookStore_modify)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            
            usernameModifyTextBox.Text = username;
            passwordModifyTextBox.Text = password;
            employeeTextBox.Text = bookStore_modify;
            bookStore = bookStore_modify;
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            if (usernameModifyTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.usernameModifyTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.usernameModifyTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (passwordModifyTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.passwordModifyTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.passwordModifyTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (employeeTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.employeeTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.employeeTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }

            else
            {

                User u = new User(username, password, 2);
                User u2 = new User(usernameModifyTextBox.Text, passwordModifyTextBox.Text, 2);
                UserDAO.Update(u, u2);
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                { MessageBox.Show("Korisnik je uspiješno modifikovan!"); }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                    MessageBox.Show("User successfuly updated!");

                this.Close();
                

                /*if (String.Equals(bookStore, bookStore_modify) == false)
                {
                    int index = bookStore.IndexOf(';'); 
                     IEnumerable<string> diff;
                    IEnumerable<string> first = employeeTextBox.Text.Split(';').Distinct();
                    
                    
                        IEnumerable<string> second = bookStore.Remove(index, 1).Split(';').Distinct();

                    if (second.Count() > first.Count())
                        {
                        diff = second.Except(first).ToList();
                        }

                    else
                        {
                        diff = first.Except(second).ToList();
                        }
                   // User u = new User(usernameModifyTextBox.Text, passwordModifyTextBox.Text, 2);
                   // UserDAO.Update(u);

                    foreach (var row in diff.ToList())
                        {



                       // BookStoreHasUserDAO.Update_user(u, row);

                        }*/


            }
            }

       
    }
    }


