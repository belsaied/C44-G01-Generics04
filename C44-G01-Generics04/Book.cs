using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_Generics04
{
    public delegate string BookDelegate(Book book);
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }

        

        public Book(string title, string author, string isbn, DateTime publicationDate, decimal price, int pages)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
            Price = price;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publication Date: {PublicationDate:yyyy-MM-dd}, Price: ${Price}, Pages: {Pages}";
        }


    }
}
