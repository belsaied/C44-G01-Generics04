using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_Generics04
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
