using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Model;

namespace BookStore
{
    public partial class AddingFormAuthor : Form
    {
        private string firstName;
        private string lastName;
        private string dateofBirth;
        private string birthPlace;
        public AddingFormAuthor()
        {
            InitializeComponent();
            ActiveControl = this.dateOfBirthTextBox;
            
            
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
            else if (dateOfBirthTextBox.Text =="")
            {
                ActiveControl = this.dateOfBirthTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            else if (birthPlaceTextBox.Text == "")
            {
                ActiveControl = this.birthPlaceTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            else
            {
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                dateofBirth = dateOfBirthTextBox.Text;
                birthPlace = birthPlaceTextBox.Text;
                Author a = new Author(firstName, lastName, dateofBirth, birthPlace);

                if(AuthorDAO.Check_author(a)==false)
                {
                    try
                    {
                        AuthorDAO.Add_author(firstName, lastName, dateofBirth, birthPlace);
                        MessageBox.Show("Author is now added!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error happened!");
                        return;
                    }
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text="";
                    dateOfBirthTextBox.Text="";
                    birthPlaceTextBox.Text="";
                    ActiveControl = this.firstNameTextBox;

                }
                else
                {
                    MessageBox.Show("This author already exist");
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    dateOfBirthTextBox.Text = "";
                    birthPlaceTextBox.Text = "";
                    ActiveControl = this.firstNameTextBox;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear all data?", "Clearing", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                dateOfBirthTextBox.Text = "";
                birthPlaceTextBox.Text = "";
                ActiveControl = this.firstNameTextBox;
            }
        }

        private void dateOfBirthTextBox_Enter(object sender, EventArgs e)
        {
            if (dateOfBirthTextBox.Text == "1999-01-31" )
            {
                dateOfBirthTextBox.Text = "";
                dateOfBirthTextBox.ForeColor = Color.Black;
            }
        }

        private void dateOfBirthTextBox_Leave(object sender, EventArgs e)
        {
            if (dateOfBirthTextBox.Text == "")
            {
                dateOfBirthTextBox.Text = "1999-01-31";

                dateOfBirthTextBox.ForeColor = Color.Silver;
            }
        }

        private void AddingFormAuthor_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
