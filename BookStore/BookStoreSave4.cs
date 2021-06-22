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
    public partial class BookStoreSave4 : Form
    {
        public BookStoreSave4()
        {
            InitializeComponent();
        }

        private void BookStoreSave4_Load(object sender, EventArgs e)
        {
            List<BookStore1> list3 = BookStoreDAO.Select();

            if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
            {
                bookStoreComboBox.Items.Clear();
                if (!bookStoreComboBox.Items.Contains("Nijedna"))
                    bookStoreComboBox.Items.Add("Nijedna");


                for (int i = 0; i < list3.Count; i++)
                    bookStoreComboBox.Items.Add(list3[i].getName());
                for (int i = 0; i < 31; i++)
                    quantitycomboBox1.Items.Add(i);
            }
            else if (Thread.CurrentThread.CurrentCulture.Name == "en")
            {
                bookStoreComboBox.Items.Clear();
                if (!bookStoreComboBox.Items.Contains("None()"))
                    bookStoreComboBox.Items.Add("None()");


                for (int i = 0; i < list3.Count; i++)
                    bookStoreComboBox.Items.Add(list3[i].getName());
                for (int i = 0; i < 31; i++)
                    quantitycomboBox1.Items.Add(i);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bookStoreComboBox.SelectedIndex<1)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.bookStoreComboBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.bookStoreComboBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if(quantitycomboBox1.SelectedIndex<1)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.quantitycomboBox1;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.quantitycomboBox1;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }
            else if(priceTextBox.Text=="" || priceTextBox.Text=="0,00" || priceTextBox.Text == "00,00")
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    ActiveControl = this.priceTextBox;
                    MessageBox.Show("Molimo vas da popunite sva polja.");
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    ActiveControl = this.priceTextBox;
                    MessageBox.Show("Please make sure all required fields are filled out correctly.");
                }
            }

            else
            {
                string name = bookStoreComboBox.SelectedItem.ToString();
                List<Book> list = BookDAO.Select();

                try
                {
                    BookStoreHasBookDAO.Insert(BookStoreDAO.getByID(BookStoreDAO.getID(name)),BookDAO.getByID(BookDAO.getID( list[list.Count-1].getTitle())),Int32.Parse( quantitycomboBox1.SelectedItem.ToString()),Convert.ToDouble( priceTextBox.Text));
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Uspiješno dodana knjiga u odabranu knjižaru!"); }
                    else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                        MessageBox.Show("Action success!");
                    this.Close();
                    bookStoreComboBox.SelectedIndex = -1;
                    quantitycomboBox1.SelectedIndex = -1;
                    priceTextBox.Text = "";
                    
                }
                catch (Exception)
                {
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Desila se greška!"); }
                    else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                        MessageBox.Show("Error happened!");
                    return;
                }

                this.Close();
            }


        }
    }
}
