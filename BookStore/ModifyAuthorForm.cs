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
    public partial class ModifyAuthorForm : Form
    {
        private string firstName ;
        private string lastName ;
       

        public ModifyAuthorForm(string fn,string ln,string db,string bp,string b)
        {
            InitializeComponent();
            this.firstName = fn;
            this.lastName = ln;
            firstNameTextBox.Text = fn;
            lastNameTextBox.Text = ln;
            dateBirthTextBox.Text = db;
            birthPlaceTextBox.Text = bp;
            booksTextBox.Text = b;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                ActiveControl = this.firstNameTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");
            }
            else if (lastNameTextBox.Text == "")
            {
                ActiveControl = this.lastNameTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (birthPlaceTextBox.Text == "")
            {
                ActiveControl = this.birthPlaceTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (dateBirthTextBox.Text == "")
            {
                ActiveControl = this.dateBirthTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (booksTextBox.Text == "")
            {
                ActiveControl = this.booksTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            else
            {
                Author a = new Author(firstName, lastName);
                Author a2 = new Author(firstNameTextBox.Text, lastNameTextBox.Text, dateBirthTextBox.Text, birthPlaceTextBox.Text);
                AuthorDAO.Update(a, a2);
                MessageBox.Show("Author successfuly updated!");

                this.Close();
            }
            }
    }
}
