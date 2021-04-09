using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask2_Inheritance.Task2._2.entity
{
    class Book
    {
        private string title;
        private int numberOfPages;
        private string publisher;
        private DateTime publicationDate;
        private DateTime writingDate;
        private Author author;

        public Book(string title, int numberOfPages, string publisher, DateTime publicationDate, DateTime writingDate, Author author)
        {
            if (numberOfPages < 0) throw new ArgumentException("Количество страниц должно быть больше нуля!");
            if (publicationDate < writingDate) throw new ArgumentException("Дата убликации книги должна быть позже даты написания книги!");


            this.title = title;
            this.numberOfPages = numberOfPages;
            this.publisher = publisher;
            this.publicationDate = publicationDate;
            this.writingDate = writingDate;
            this.author = author;
        }

        public string Title
        {
            get => this.title;
        }
        public int NumberOfPages
        {
            get => this.numberOfPages;
        }
        public string Publisher
        {
            get => this.publisher;
        }
        public DateTime PublicationDate
        {
            get => this.publicationDate;
        }
        public DateTime WritingDate
        {
            get => this.writingDate;
        }

        public Author Author
        {
            get => this.author;
        }

        public override string ToString()
        {
            return "\nBook {title = \'" + this.title + "\'" +
                ", number of pages = " + this.numberOfPages +
                ", publisher = " + this.publisher +
                ", publication date = " + this.publicationDate.ToShortDateString() +
                ", writing date = " + this.writingDate.ToShortDateString() +
                "}" +
                this.author.ToString();
        }
    }
}
