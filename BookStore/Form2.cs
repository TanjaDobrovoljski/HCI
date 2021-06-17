using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookStore
{
    public partial class Form2 : Form
    {

        private int tipKorisnika;
        private string userName;
        private PictureBox pic;
        private Label text;
        
        
        private int bookStoreId;
        private string title;
        private Author author;
        private Publisher publisher;
       


        public Form2(int bookStoreId)
        {
            InitializeComponent();

            this.bookStoreId = bookStoreId;

            searchTitleBox.Items.Add("None()");
            searchPublisherBox.Items.Add("None()");
            searchAuthorBox.Items.Add("None()");


        }

        public Form2(int i,string u)
        {
            this.tipKorisnika = i;
            this.userName = u;
        }

        
        public void getSpecificData(int bookStoreId)
            
        {
            
            flowLayoutPanel1.Controls.Clear();

            
            List<BookStoreHasBook> list = BookStoreHasBookDAO.getBooks(bookStoreId);
            
            for (int i = 0; i < list.Count; i++)
            {
                
                pic = new PictureBox();
                pic.Height = 150;
                pic.Width = 100;

                pic.BackgroundImageLayout = ImageLayout.Stretch;
                //pic.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                text = new Label();
                text.Width = 10;
                text.Height = 28;
                text.Text = list[i].getBook().getTitle()+" ("+list[i].getQuantity()+") \r\n"+ list[i].getPrice()+" KM";
                text.BackColor = Color.LightYellow;
                text.TextAlign = ContentAlignment.MiddleCenter;
                text.Dock = DockStyle.Bottom;

                Bitmap bm = new Bitmap(list[i].getBook().getImagePath());
                pic.BackgroundImage = bm;

                pic.Controls.Add(text);
                flowLayoutPanel1.Controls.Add(pic);

                if(searchTitleBox.Items.Contains(list[i].getBook().getTitle())==false )
                    searchTitleBox.Items.Add(list[i].getBook().getTitle());
                


                if (searchAuthorBox.Items.Contains(AuthorDAO.getByID((BookHasAuthorDAO.getAuthorID(list[i].getBook()))).getFirstName() + " " + AuthorDAO.getByID((BookHasAuthorDAO.getAuthorID(list[i].getBook()))).getLastName())==false)
                     searchAuthorBox.Items.Add(AuthorDAO.getByID((BookHasAuthorDAO.getAuthorID(list[i].getBook()))).getFirstName()+" "+ AuthorDAO.getByID((BookHasAuthorDAO.getAuthorID(list[i].getBook()))).getLastName());
                


                if (searchPublisherBox.Items.Contains(list[i].getBook().getPublisher().getName())==false)
                     searchPublisherBox.Items.Add(list[i].getBook().getPublisher().getName());
               

                ToolTip toolTip = new ToolTip();
                toolTip.ShowAlways = true;
                toolTip.AutoPopDelay = 1000000000;
                toolTip.InitialDelay = 300;
                toolTip.SetToolTip(pic, list[i].getBook().getDescription());


                

            }

        }


        private void getBookData(string title)

        {

            flowLayoutPanel1.Controls.Clear();


            List<BookStoreHasBook> list = BookStoreHasBookDAO.getBooks(bookStoreId);
            Book book = BookDAO.getByID( BookDAO.getID(title));

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getBook().getTitle()==title)
                {
                    pic = new PictureBox();
                    pic.Height = 150;
                    pic.Width = 100;

                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    //pic.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                    text = new Label();
                    text.Width = 10;
                    text.Height = 28;
                    text.Text = list[i].getBook().getTitle() + " (" + list[i].getQuantity() + ") \r\n" + list[i].getPrice() + " KM";
                    text.BackColor = Color.LightYellow;
                    text.TextAlign = ContentAlignment.MiddleCenter;
                    text.Dock = DockStyle.Bottom;

                    Bitmap bm = new Bitmap(list[i].getBook().getImagePath());
                    pic.BackgroundImage = bm;

                    pic.Controls.Add(text);
                    flowLayoutPanel1.Controls.Add(pic);

                   


                    ToolTip toolTip = new ToolTip();
                    toolTip.ShowAlways = true;
                    toolTip.AutoPopDelay = 1000000000;
                    toolTip.InitialDelay = 300;
                    toolTip.SetToolTip(pic, list[i].getBook().getDescription());



                }
            }

        }

        private void getAuthorData(Author a)

        {

            flowLayoutPanel1.Controls.Clear();

            

            List<BookStoreHasBook> list = BookStoreHasBookDAO.getBooks(bookStoreId);
            

            for (int i = 0; i < list.Count; i++) 
            {
                
                    if (BookHasAuthorDAO.getBookID(a)==BookDAO.getID( list[i].getBook().getTitle()))
                    {
                    
                           pic = new PictureBox();
                        pic.Height = 150;
                        pic.Width = 100;

                        pic.BackgroundImageLayout = ImageLayout.Stretch;
                        //pic.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                        text = new Label();
                        text.Width = 10;
                        text.Height = 28;
                        text.Text = list[i].getBook().getTitle() + " (" + list[i].getQuantity() + ") \r\n" + list[i].getPrice() + " KM";
                        text.BackColor = Color.LightYellow;
                        text.TextAlign = ContentAlignment.MiddleCenter;
                        text.Dock = DockStyle.Bottom;

                        Bitmap bm = new Bitmap(list[i].getBook().getImagePath());
                        pic.BackgroundImage = bm;

                        pic.Controls.Add(text);
                        flowLayoutPanel1.Controls.Add(pic);



                        ToolTip toolTip = new ToolTip();
                        toolTip.ShowAlways = true;
                        toolTip.AutoPopDelay = 1000000000;
                        toolTip.InitialDelay = 300;
                        toolTip.SetToolTip(pic, list[i].getBook().getDescription());

                    }
                
                
            }

        }

        private void getPublisherData(Publisher p)

        {

            flowLayoutPanel1.Controls.Clear();



            List<BookStoreHasBook> list = BookStoreHasBookDAO.getBooks(bookStoreId);


            for (int i = 0; i < list.Count; i++)
            {

                if (PublisherDAO.getID( list[i].getBook().getPublisher().getName()) == PublisherDAO.getID(p.getName()))
                {

                    pic = new PictureBox();
                    pic.Height = 150;
                    pic.Width = 100;

                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    //pic.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                    text = new Label();
                    text.Width = 10;
                    text.Height = 28;
                    text.Text = list[i].getBook().getTitle() + " (" + list[i].getQuantity() + ") \r\n" + list[i].getPrice() + " KM";
                    text.BackColor = Color.LightYellow;
                    text.TextAlign = ContentAlignment.MiddleCenter;
                    text.Dock = DockStyle.Bottom;

                    Bitmap bm = new Bitmap(list[i].getBook().getImagePath());
                    pic.BackgroundImage = bm;

                    pic.Controls.Add(text);
                    flowLayoutPanel1.Controls.Add(pic);



                    ToolTip toolTip = new ToolTip();
                    toolTip.ShowAlways = true;
                    toolTip.AutoPopDelay = 1000000000;
                    toolTip.InitialDelay = 300;
                    toolTip.SetToolTip(pic, list[i].getBook().getDescription());

                }


            }

        }


        private void getAllData()
        {
            flowLayoutPanel1.Controls.Clear();

            List<Book> list = BookDAO.Select();



            for (int i = 0; i < BookDAO.BookCount(); i++)
            {
                pic = new PictureBox();
                pic.Height = 160;
                pic.Width = 120;

                pic.BackgroundImageLayout = ImageLayout.Stretch;
                //pic.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                text = new Label();
                text.Text = list[i].getTitle();
                text.BackColor = Color.LightYellow;
                text.TextAlign = ContentAlignment.MiddleCenter;
                text.Dock = DockStyle.Bottom;

                Bitmap bm = new Bitmap(list[i].getImagePath());
                pic.BackgroundImage = bm;

                pic.Controls.Add(text);
                flowLayoutPanel1.Controls.Add(pic);

                ToolTip toolTip = new ToolTip();
                toolTip.ShowAlways = true;
                toolTip.AutoPopDelay = 1000000000;
                toolTip.InitialDelay = 300;
                toolTip.SetToolTip(pic, list[i].getDescription());


                //this.tip = new CustomToolTip();
                //this.tip.SetToolTip(pic, list[i].getDescription());
                
            }
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
           

            if (this.bookStoreId == 1)
            {
                storeLetter.Text = "A";
                

            }
            else if (this.bookStoreId == 2)
            {
                storeLetter.Text = "B";
            }
            else
            {
                storeLetter.Text = "C";
            }

           
            bookStoreInfromation.Text = "Address: " + BookStoreDAO.getByID(bookStoreId).getAddress()+"  Work time: "+ BookStoreDAO.getByID(bookStoreId).getWorkTime() ;

            getSpecificData(bookStoreId);

            

            

            //getAllData(); za logo a i to ne znam kada?!

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (title != null)
                getBookData(title);
            else if (author != null)
                getAuthorData(author);
            else if (publisher != null)
                getPublisherData(publisher);

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
            searchAuthorBox.SelectedIndex = -1;
            searchTitleBox.SelectedIndex = -1;
            searchPublisherBox.SelectedIndex = -1;

            searchAuthorBox.Enabled = true;
            searchTitleBox.Enabled = true;
            searchPublisherBox.Enabled = true;
        }

        private void searchTitleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchTitleBox.SelectedIndex > 0)
            {
                searchAuthorBox.Enabled = false;
                searchPublisherBox.Enabled = false;
                
                title = searchTitleBox.Text;
            }
            else if (searchTitleBox.SelectedIndex == 0 || searchTitleBox.SelectedIndex < 0)
            {
                searchAuthorBox.Enabled = true;
                searchPublisherBox.Enabled = true;
                title = null;
            }
            
            
         }

        private void searchAuthorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             if (searchAuthorBox.SelectedIndex > 0)
            {
                searchTitleBox.Enabled = false;
                searchPublisherBox.Enabled = false;

                string author1 = searchAuthorBox.Text;
                string[] split = author1.Split(' ');
                
                author = new Author(split[0],split[1]);
                

            }
            else if (searchAuthorBox.SelectedIndex == 0 || searchAuthorBox.SelectedIndex < 0)
            {
                searchTitleBox.Enabled = true;
                searchPublisherBox.Enabled = true;
                author = null;
            }
           
         }

        private void searchPublisherBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (searchPublisherBox.SelectedIndex > 0)
            {
                searchTitleBox.Enabled = false;
                searchAuthorBox.Enabled = false;

                string publisher1 = searchPublisherBox.Text;
                publisher = new Publisher(publisher1);
            }
            else if (searchPublisherBox.SelectedIndex == 0 || searchPublisherBox.SelectedIndex < 0)
            {
                searchTitleBox.Enabled = true;
                searchAuthorBox.Enabled = true;
                publisher = null;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }




        /* private void panel1_Paint(object sender, PaintEventArgs e)
         {
             /*string path1 = @"alisa.jpg";
             string path2 = Path.GetFullPath(path1);
             path2 = path2.Replace(@"bin\Debug", @"Resources");
             Console.WriteLine(path2);

             panel1.BackgroundImage = Image.FromFile(path2); ///// nece panel ispod ili preko flow-a
         }*/


    }
}
