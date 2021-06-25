using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class Book
    {
        private string title;
        private int publishing_year;
        private string description;
        private Author author;
        private Publisher publisher;
        private string image= @"C:\Users\Dobrovoljski\source\repos\BookStore\BookStore\Resources\knjige\noimage.jpg";

        public Book(string title,int publishing_year,Publisher publisher, string description, string image)
        {
            this.title = title;
            this.publishing_year = publishing_year;
            this.description = description;
            this.publisher = publisher;
            this.image = image;
            
        }

        public Book(string name)
        {
            this.title = name;
        }

        public string getTitle()
        {
            return title;
        }

        public int getPublishingYear()
        {
            return publishing_year;
        }

        public string getDescription()
        {
            return description;
        }

        public void setAuthor(Author a)
        {
            this.author = a;
        }

        public Author getAuthor()
        {
            return author;
        }

        public void setPublisher(Publisher p)
        {
            this.publisher=p;
        }

        public Publisher getPublisher()
        {
            return publisher;
        }

        public string getImage()
        {
            return image;
        }

        public string getImagePath()
        {
            string path1 = @"knjige";
            string path2 = Path.GetFullPath(path1);
            path2 = path2.Replace(@"bin\Debug", @"Resources");
            string image_path=string.Concat(path2,"\\"+this.image + ".jpg");
            return image_path;
        }
    }
}
