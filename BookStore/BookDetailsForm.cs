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
    public partial class BookDetailsForm : Form
    {
        public BookDetailsForm( string title)
        {
            InitializeComponent();
            titleLabel.Text = title;
           

            author.Text = AuthorDAO.getByID(BookHasAuthorDAO.getAuthorID(BookDAO.getByID(BookDAO.getID(title)))).getFirstName() + " " + AuthorDAO.getByID(BookHasAuthorDAO.getAuthorID(BookDAO.getByID(BookDAO.getID(title)))).getLastName() + "\n(" + BookDAO.getByID(BookDAO.getID(title)).getPublishingYear() + ")";
            Bitmap bm = new Bitmap(BookDAO.getByID(BookDAO.getID(title)).getImagePath());
            pictureBox1.BackgroundImage = bm;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.MaximumSize = new Size(200, 0);
            label1.AutoSize = true;
            label1.Text = BookDAO.getByID(BookDAO.getID(title)).getDescription();

        }
    }
}
