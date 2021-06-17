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
    public partial class AddingFormBookStore : Form
    {
        private string name;
        private string address;
        private string work_time;
        private string openning_date;
        

        public AddingFormBookStore()
        {
            InitializeComponent();
            ActiveControl = this.openningDateTextBox;
            ActiveControl = this.workTimeTextBox;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                ActiveControl = this.nameTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");
            }
            else if (addressTextBox.Text == "")
            {
                ActiveControl = this.addressTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }
            else if (workTimeTextBox.Text == "")
            {
                ActiveControl = this.workTimeTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            else if (openningDateTextBox.Text == "")
            {
                ActiveControl = this.openningDateTextBox;
                MessageBox.Show("Please make sure all required fields are filled out correctly.");

            }

            else
            {
                name = nameTextBox.Text;
                address = addressTextBox.Text;
                work_time = workTimeTextBox.Text;
                openning_date = openningDateTextBox.Text;

                BookStore1 b = new BookStore1(name, address, work_time, openning_date);
                if (BookStoreDAO.Check_bookStore(b) == false)
                {
                    try { 
                    BookStoreDAO.Add_bookStore(name, address, work_time, openning_date);
                    MessageBox.Show("Book Store is now added!"); 
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Error happened!");
                        return;
                    }
                    this.Close();
                    nameTextBox.Text = "";
                    addressTextBox.Text = "";
                    workTimeTextBox.Text = "";
                    openningDateTextBox.Text = "";
                    ActiveControl = this.openningDateTextBox;
                    ActiveControl = this.workTimeTextBox;

                }
                else
                {
                    MessageBox.Show("This Book Store already exist");
                    nameTextBox.Text = "";
                    addressTextBox.Text = "";
                    workTimeTextBox.Text = "";
                    openningDateTextBox.Text = "";
                    ActiveControl = this.openningDateTextBox;
                    ActiveControl = this.workTimeTextBox;
                }

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear all data?", "Clearing", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nameTextBox.Text = "";
                addressTextBox.Text = "";
                workTimeTextBox.Text = "";
                openningDateTextBox.Text = "";
                ActiveControl = this.openningDateTextBox;
                ActiveControl = this.workTimeTextBox;
            }
        }

        private void openningDateTextBox_Enter(object sender, EventArgs e)
        {
            if (openningDateTextBox.Text == "1999-01-31")
            {
                openningDateTextBox.Text = "";
                openningDateTextBox.ForeColor = Color.Black;
            }
        }

        private void openningDateTextBox_Leave(object sender, EventArgs e)
        {
            if (openningDateTextBox.Text == "")
            {
                openningDateTextBox.Text = "1999-01-31";

                openningDateTextBox.ForeColor = Color.Silver;
            }
        }

        private void workTimeTextBox_Enter(object sender, EventArgs e)
        {
            if (workTimeTextBox.Text == "00-00h")
            {
                workTimeTextBox.Text = "";
                workTimeTextBox.ForeColor = Color.Black;
            }
        }

        private void workTimeTextBox_Leave(object sender, EventArgs e)
        {
            if (workTimeTextBox.Text == "")
            {
                workTimeTextBox.Text = "00-00h";

                workTimeTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
