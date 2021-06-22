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
    public partial class ModifyBookStoreForm : Form
    {
        private string name_bs ;
        

        public ModifyBookStoreForm(string name,string address,string work,string open,string employ,string books)
        {
            InitializeComponent();
            this.name_bs = name;
            nameTextBox.Text = name;
            addressTextBox.Text = address;
            workTimeTextBox.Text = work;
            openingTextBox.Text = open;
            employeesTextBox.Text = employ;
            booksTextBox.Text = books;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn") 
                {
                    ActiveControl = this.nameTextBox;
                    MessageBox.Show("Molimo vas da ispunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.nameTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (addressTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.addressTextBox;
                    MessageBox.Show("Molimo vas da ispunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.addressTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if (workTimeTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.workTimeTextBox;
                    MessageBox.Show("Molimo vas da ispunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.workTimeTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }

            else if (openingTextBox.Text == "")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.openingTextBox;
                    MessageBox.Show("Molimo vas da ispunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.openingTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }

            else
            {

                BookStore1 b = new BookStore1(name_bs);
                BookStore1 b2 = new BookStore1(nameTextBox.Text, addressTextBox.Text, workTimeTextBox.Text, openingTextBox.Text);

                BookStoreDAO.Update(b, b2);
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                { MessageBox.Show("Knjižara je uspiješno midifikovana!"); }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                    MessageBox.Show("Book store successfuly updated!");

                this.Close();
            }

            }
    }
}
