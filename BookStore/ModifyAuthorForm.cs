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
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.firstNameTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.firstNameTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (lastNameTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.lastNameTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.lastNameTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (birthPlaceTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.birthPlaceTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.birthPlaceTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (dateBirthTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.dateBirthTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.dateBirthTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            

            else
            {
                Author a = new Author(firstName, lastName);
                Author a2 = new Author(firstNameTextBox.Text, lastNameTextBox.Text, dateBirthTextBox.Text, birthPlaceTextBox.Text);
                AuthorDAO.Update(a, a2);
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                { MessageBox.Show("Autor je uspiješno modifikovan!"); }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                    MessageBox.Show("Author successfuly updated!");

                this.Close();
            }
            }
    }
}
