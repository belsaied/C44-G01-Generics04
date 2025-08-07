namespace C44_G01_Generics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("The White Nights", "Fyodor Distovisky", "1111333333", new DateTime(1834, 8, 1), 54.99m, 464),
                new Book("The Stranger", "Albert Camus", "1111444444", new DateTime(1899, 10, 20), 45.99m, 352),
                new Book("The Divine Comedy", "Dante Aleghrie","11111155555555",new DateTime(1321,11, 1),43.45m,400)
            };

            
            #region a. User Defined Delegate (To Get the title of the book).
            BookDelegate titleDelegate = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, new Func<Book, string>(titleDelegate));
            Console.WriteLine(new string('-', 50));
            #endregion


            #region b. BCL Delegate (Func) to get the author name.
            Func<Book, string> authorDelegate = BookFunctions.GetAuthor;
            LibraryEngine.ProcessBooks(books, authorDelegate);
            Console.WriteLine(new string('-', 50));
            #endregion


            #region c. Anonymous Method (GetISBN) 
            Func<Book, string> isbnDelegate = delegate (Book book)
            {
              return $"ISBN: {book.ISBN}";
            };
            LibraryEngine.ProcessBooks(books, isbnDelegate);
            Console.WriteLine(new string('-', 50));
            #endregion


            #region d. Lambda Expression (GetPublicationDate)
            Func<Book, string> pubDateDelegate = b => $"Published: {b.PublicationDate:yyyy-MM-dd}";
            LibraryEngine.ProcessBooks(books, pubDateDelegate);
            Console.WriteLine(new string('-', 50));
            #endregion


            #region E. Lambda Expression (getPrice)
            Func<Book, string> getPrice = b => $"Price: ${b.Price}";
            LibraryEngine.ProcessBooks(books, getPrice); 
            #endregion



        }
    }
}
