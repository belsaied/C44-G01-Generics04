using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_Generics04
{
    public class BookFunctions
    {
        // Method to get title
        public static string GetTitle(Book book)
        {
            return book?.Title ?? "Unknown";
        }

        // Method to get author
        public static string GetAuthor(Book book)
        {
            return book?.Author ?? "Unknown Author";
        }

        public static decimal GetPrice(Book book)
        {
            return book?.Price?? 0;
        }
    }
}
