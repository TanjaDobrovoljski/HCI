using BookStore.Model;
using BookStore;
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
    public partial class Form3 : Form
    {

        private int tipKorisnika;
        private string userName;
        private static int i = 0;

        public Form3()
        {
            InitializeComponent();
            dataGridView.Visible = true;
            

        }

        public Form3(int tipKorisnika, string userName)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
            this.userName = userName;
            modifyButton.Enabled = false;
            deleteButton.Enabled = false;

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            if (i == 0)
                showUser();
            else if (i == 1)
                showAuthor();
            else if (i == 2)
                showBooks();
            else if (i == 3)
                showPublisher();
            else if (i == 4)
                showBookStore();

        }



        private void showUser()
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.AutoResizeColumns();


            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "No.";
            dataGridView.Columns[1].Name = "Username";
            dataGridView.Columns[2].Name = "Password";
            dataGridView.Columns[3].Name = "Employee in Book Store";


            string[] row = new string[3];
            string p;
            string k = "";
            //dataGridView.Rows.Add(row);

            List<User> list = UserDAO.Select();

            int i, j = 0;

            for (i = 0; i < list.Count; i++)
            {
                row = new string[] { (i + 1).ToString(), list[i].getUsername(), list[i].getPassword() }; // BookStoreDAO.getByID(BookStoreHasUserDAO.getBookStoreID(list[i])).getName())
                dataGridView.Rows.Add(row);
                for (j = 1; j < BookStoreDAO.BookStoreCount() + 1; j++)
                {
                    List<User> list2 = BookStoreHasUserDAO.userList(j);
                    for (int m = 0; m < list2.Count; m++)
                    {
                        if (list2[m].getUsername() == list[i].getUsername())
                        {
                            p = BookStoreDAO.getByID(j).getName();
                            
                                k = k + "" + p + ";";

                            

                        }
                        
                    }
                    
                    dataGridView.Rows[i].Cells[3].Value = k;
                    
                }
                k = "";
            }

        }

        private void showAuthor()
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.AutoResizeColumns();


            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "No.";
            dataGridView.Columns[1].Name = "First name";
            dataGridView.Columns[2].Name = "Last name";
            dataGridView.Columns[3].Name = "Date of birth";
            dataGridView.Columns[4].Name = "Birth place";
            dataGridView.Columns[5].Name = "Books";



            string[] row = new string[5];
            string p;
            string k = "";
            //dataGridView.Rows.Add(row);

            List<Author> list = AuthorDAO.Select();

            int i, j = 0;

            for (i = 0; i < list.Count; i++)
            {
                row = new string[] { (i + 1).ToString(), list[i].getFirstName(), list[i].getLastName(), list[i].getDateOfBirth(), list[i].getBirthPlace() }; // BookStoreDAO.getByID(BookStoreHasUserDAO.getBookStoreID(list[i])).getName())
                dataGridView.Rows.Add(row);

                List<BookHasAuthor> list2 = BookHasAuthorDAO.Select();
                if (i <= list2.Count)
                {

                    for (j = 0; j < list2.Count; j++)
                    {


                        {
                            if (AuthorDAO.getID(list[i].getFirstName(), list[i].getLastName()) == AuthorDAO.getID(list2[j].getAuthor().getFirstName(), list2[j].getAuthor().getLastName()))
                            {
                                p = BookDAO.getByID(BookHasAuthorDAO.getBookID(list2[j].getAuthor())).getTitle();
                                k = k + "" + p + ";";
                            }
                        }



                    }
                }
                else
                {
                    p = "";
                    k = k + "" + p + ";";
                }
                dataGridView.Rows[i].Cells[5].Value = k;
                k = "";
            }

        }

        private void showBooks()

        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.AutoResizeColumns();


            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "No.";
            dataGridView.Columns[1].Name = "Title";
            dataGridView.Columns[2].Name = "Publishing year";
            dataGridView.Columns[3].Name = "Publisher";
            dataGridView.Columns[4].Name = "Author";




            string[] row = new string[4];
            string p;
            string k = "";
            //dataGridView.Rows.Add(row);

            List<Book> list = BookDAO.Select();

            int i, j = 0;

            for (i = 0; i < list.Count; i++)
            {
                row = new string[] { (i + 1).ToString(), list[i].getTitle(), list[i].getPublishingYear().ToString(), list[i].getPublisher().getName() }; // BookStoreDAO.getByID(BookStoreHasUserDAO.getBookStoreID(list[i])).getName())
                dataGridView.Rows.Add(row);

                List<BookHasAuthor> list2 = BookHasAuthorDAO.Select();

                for (j = 0; j < list.Count; j++)
                {
                    if (BookDAO.getID(list[i].getTitle()) == BookDAO.getID(list2[j].getBook().getTitle()))
                    {
                        p = AuthorDAO.getByID(BookHasAuthorDAO.getAuthorID(list2[j].getBook())).getFirstName() + " " + AuthorDAO.getByID(BookHasAuthorDAO.getAuthorID(list2[j].getBook())).getLastName();
                        k = k + "" + p + ";";
                    }

                }
                dataGridView.Rows[i].Cells[4].Value = k;
                k = "";
            }

        }

        private void showPublisher()
        {

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.AutoResizeColumns();


            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "No.";
            dataGridView.Columns[1].Name = "Name";
            dataGridView.Columns[2].Name = "Address";
            dataGridView.Columns[3].Name = "Email";
            dataGridView.Columns[4].Name = "Phone number";
            dataGridView.Columns[5].Name = "Books";




            string[] row = new string[5];
            string p;
            string k = "";
            //dataGridView.Rows.Add(row);

            List<Publisher> list = PublisherDAO.Select();

            int i, j = 0;

            for (i = 0; i < list.Count; i++)
            {
                row = new string[] { (i + 1).ToString(), list[i].getName(), list[i].getAddress(), list[i].getEmail(), list[i].getPhoneNumber() }; // BookStoreDAO.getByID(BookStoreHasUserDAO.getBookStoreID(list[i])).getName())
                dataGridView.Rows.Add(row);

                List<Book> list2 = BookDAO.Select();

                for (j = 0; j < list2.Count; j++)
                {
                    if (PublisherDAO.getID(list[i].getName()) == PublisherDAO.getID(list2[j].getPublisher().getName()))
                    {
                        p = list2[j].getTitle();
                        k = k + "" + p + ";";
                    }

                }
                dataGridView.Rows[i].Cells[5].Value = k;
                k = "";
            }

        }

        private void showBookStore()
        {

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.AutoResizeColumns();


            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "No.";
            dataGridView.Columns[1].Name = "Name";
            dataGridView.Columns[2].Name = "Address";
            dataGridView.Columns[3].Name = "Work time";
            dataGridView.Columns[4].Name = "Openning date";
            dataGridView.Columns[5].Name = "Employees";
            dataGridView.Columns[6].Name = "Books";


            List<BookStore1> list = BookStoreDAO.Select();

            string[] row = new string[5];
            string p;
            string k = "";
            //dataGridView.Rows.Add(row);
            List<BookStoreHasBook> list3 = BookStoreHasBookDAO.Select();
            List<BookStoreHasUser> list2 = BookStoreHasUserDAO.Select();


            int i, j = 0;

            for (i = 0; i < list.Count; i++)
            {
                row = new string[] { (i + 1).ToString(), list[i].getName(), list[i].getAddress(), list[i].getWorkTime(), list[i].getOPeningDate() }; // BookStoreDAO.getByID(BookStoreHasUserDAO.getBookStoreID(list[i])).getName())
                dataGridView.Rows.Add(row);



                for (j = 0; j < list2.Count; j++)
                {


                    if (BookStoreDAO.getID(list[i].getName()) == BookStoreDAO.getID(list2[j].getBookStore().getName()))
                    {
                        p = list2[j].getUser().getUsername();
                        k = k + "" + p + ";";
                    }

                }
                dataGridView.Rows[i].Cells[5].Value = k;
                k = "";
            }
            k = "";
            for (i = 0; i < list.Count; i++)
            {

                for (j = 0; j < list3.Count; j++)
                {


                    if (BookStoreDAO.getID(list[i].getName()) == BookStoreDAO.getID(list3[j].getBookStore().getName()))
                    {
                        p = list3[j].getBook().getTitle();
                        k = k + " " + p + ";";
                    }

                }
                dataGridView.Rows[i].Cells[6].Value = k;
                k = "";
            }

        }



        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchBox.SelectedIndex == 0)

                showUser();

            else if (searchBox.SelectedIndex == 1)

                showAuthor();
            else if (searchBox.SelectedIndex == 2)
                showBooks();
            else if (searchBox.SelectedIndex == 3)
                showPublisher();
            else if (searchBox.SelectedIndex == 4)
                showBookStore();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddingFormUser f = new AddingFormUser();
            f.ShowDialog();
            Form3_Load(sender, e);
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            AddingFormAuthor f = new AddingFormAuthor();
            f.ShowDialog();
            Form3_Load(sender, e);
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            AddingFormPublisher f = new AddingFormPublisher();
            f.ShowDialog();
            Form3_Load(sender, e);
        }

        private void addBookStoreButton_Click(object sender, EventArgs e)
        {
            AddingFormBookStore f = new AddingFormBookStore();
            f.ShowDialog();
            Form3_Load(sender, e);
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddingFormBook f = new AddingFormBook();
            f.ShowDialog();
            Form3_Load(sender, e);
        }



        private string username = "";
        private string password = "";
        private string emlpoyee_in = "";

        private string firstName = "";
        private string lastName = "";
        private string birthPlace = "";
        private string date_of_birth = "";
        private string books = "";

        private string title = "";
        private string publishing_year = "";
        private string publisher = "";
        private string author = "";

        private string name = "";
        private string address = "";
        private string email = "";
        private string phone_number = "";
        private string books_p = "";

        private string name_bs = "";
        private string address_bs = "";
        private string work_time = "";
        public string opening_date = "";
        private string employees = "";
        private string books_bs = "";

        string description = "";
        string image = "";


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modifyButton.Enabled = true;
            deleteButton.Enabled = true;


            int i = 0;


            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            i = dataGridView.CurrentRow.Index;

            if (searchBox.SelectedIndex <= 0)
            {

                for (int column = 1; column < dataGridView.Columns.Count - 1; column++)
                {

                    username = dataGridView.Rows[i].Cells["Username"].Value.ToString();
                    password = dataGridView.Rows[i].Cells["Password"].Value.ToString();
                    emlpoyee_in = dataGridView.Rows[i].Cells["Employee in Book Store"].Value.ToString();

                }
                i = 0;



            }
            else if (searchBox.SelectedIndex == 1)
            {
                for (int column = 1; column < dataGridView.Columns.Count - 1; column++)
                {

                    firstName = dataGridView.Rows[i].Cells["First name"].Value.ToString();
                    lastName = dataGridView.Rows[i].Cells["Last name"].Value.ToString();
                    date_of_birth = dataGridView.Rows[i].Cells["Date of birth"].Value.ToString();
                    birthPlace = dataGridView.Rows[i].Cells["Birth place"].Value.ToString();
                    books = dataGridView.Rows[i].Cells["Books"].Value.ToString();

                }
                i = 0;

            }
            else if (searchBox.SelectedIndex == 2)
            {
                for (int column = 1; column < dataGridView.Columns.Count - 1; column++)
                {

                    title = dataGridView.Rows[i].Cells["Title"].Value.ToString();
                    publishing_year = dataGridView.Rows[i].Cells["Publishing year"].Value.ToString();
                    publisher = dataGridView.Rows[i].Cells["Publisher"].Value.ToString();
                    author = dataGridView.Rows[i].Cells["Author"].Value.ToString();

                    description = BookDAO.getByID(BookDAO.getID(title)).getDescription();
                    image = BookDAO.getByID(BookDAO.getID(title)).getImage();



                }
                i = 0;

            }
            else if (searchBox.SelectedIndex == 3)
            {
                for (int column = 1; column < dataGridView.Columns.Count - 1; column++)
                {

                    name = dataGridView.Rows[i].Cells["Name"].Value.ToString();
                    address = dataGridView.Rows[i].Cells["Address"].Value.ToString();
                    email = dataGridView.Rows[i].Cells["Email"].Value.ToString();
                    phone_number = dataGridView.Rows[i].Cells["Phone number"].Value.ToString();
                    books_p = dataGridView.Rows[i].Cells["Books"].Value.ToString();


                }
                i = 0;

            }
            else if (searchBox.SelectedIndex == 4)
            {
                for (int column = 1; column < dataGridView.Columns.Count - 1; column++)
                {

                    name_bs = dataGridView.Rows[i].Cells["Name"].Value.ToString();
                    address_bs = dataGridView.Rows[i].Cells["Address"].Value.ToString();
                    work_time = dataGridView.Rows[i].Cells["Work time"].Value.ToString();
                    opening_date = dataGridView.Rows[i].Cells["Openning date"].Value.ToString();
                    employees = dataGridView.Rows[i].Cells["Employees"].Value.ToString();
                    books_bs = dataGridView.Rows[i].Cells["Books"].Value.ToString();


                }
                i = 0;

            }


        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (searchBox.SelectedIndex <= 0)
            {
                ModifyUserForm f = new ModifyUserForm(username, password, emlpoyee_in);
                f.ShowDialog();
                i = 0;
                Form3_Load(sender, e);
            }
            else if (searchBox.SelectedIndex ==1)
            {
                ModifyAuthorForm f = new ModifyAuthorForm(firstName, lastName, date_of_birth, birthPlace, books);
                f.ShowDialog();
                i = 1;
                Form3_Load(sender, e);
            }
            if (searchBox.SelectedIndex ==2)
            {
                ModifyBookForm f = new ModifyBookForm(title,publishing_year,publisher,author,description,image);
                f.ShowDialog();
                i = 2;
                Form3_Load(sender, e);
            }
            if (searchBox.SelectedIndex ==3)
            {
                ModifyPublisherForm f = new ModifyPublisherForm(name,address,email,phone_number,books_p);
                f.ShowDialog();
                i = 3;
                Form3_Load(sender, e);
            }
            if (searchBox.SelectedIndex ==4)
            {
                ModifyBookStoreForm f = new ModifyBookStoreForm(name_bs,address_bs,work_time,opening_date,employees,books_bs);
                f.ShowDialog();
                i = 4;
                Form3_Load(sender, e);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (searchBox.SelectedIndex <= 0)
            {
                if (MessageBox.Show("Do you want to delete this user?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UserDAO.Delete(UserDAO.getByID(UserDAO.getID(username)));
                    MessageBox.Show("User is now deleted!");
                    i = 0;
                    Form3_Load(sender, e);
                }
                i = 0;
            }
            else if (searchBox.SelectedIndex==1)
            {
                if (MessageBox.Show("Do you want to delete this author?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AuthorDAO.Delete(AuthorDAO.getByID(AuthorDAO.getID(firstName, lastName)));
                    MessageBox.Show("Author is now deleted!");
                    i = 1;
                    Form3_Load(sender, e);
                }
                i = 0;
            }
            else if (searchBox.SelectedIndex == 2)
            {
                if (MessageBox.Show("Do you want to delete this book?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BookDAO.Delete(BookDAO.getByID(BookDAO.getID(title)));
                    
                    MessageBox.Show("Book is now deleted!");
                    i = 2;
                    Form3_Load(sender, e);
                }
                i = 0;
            }
            else if (searchBox.SelectedIndex == 3)
            {
                if (MessageBox.Show("Do you want to delete this publisher?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PublisherDAO.Delete(PublisherDAO.getByID(PublisherDAO.getID(name)));
                   
                    MessageBox.Show("Publisher is now deleted!");
                    i = 3;
                    Form3_Load(sender, e);
                }
                i = 0;
            }
            else if (searchBox.SelectedIndex == 4)
            {
                if (MessageBox.Show("Do you want to delete this book store?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BookStoreDAO.Delete(BookStoreDAO.getByID(BookStoreDAO.getID(name_bs)));
                     MessageBox.Show("Book store is now deleted!");
                    i = 4;
                    Form3_Load(sender, e);
                }
                i = 0;
            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
