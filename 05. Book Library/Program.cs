using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.Book_Library
{
    public class Program
    {


        public static void Main(string[] args)
        {



            var number = int.Parse(Console.ReadLine());

            Library booksByAuthor = new Library();

            var books = new List<Book>();

            for (int i = 0; i < number; i++)
            {
                books.Add(ReadBook());
            }

            booksByAuthor.Books = books;

            var pricePerAuthor = AddValuesToDict(booksByAuthor);

            PrintResults(pricePerAuthor);
        }

        private static void PrintResults(Dictionary<string, double> pricePerAuthor)
        {
            foreach (var author in pricePerAuthor.OrderByDescending(a => a.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }

        public static Book ReadBook()

        {
            Book book = new Book();

            string[] bookData = Console.ReadLine()
                .Split()
                .ToArray();

            book.Title = bookData[0];
            book.Author = bookData[1];
            book.Publisher = bookData[2];
            book.ReleaseDate = DateTime.ParseExact(bookData[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            book.IsbnNumber = bookData[4];
            book.Price = double.Parse(bookData[5]);

            return book;
        }

        public static Dictionary<string, double> AddValuesToDict(Library booksByAuthor)
        {
            var pricePerAuthor = new Dictionary<string, double>();

            for (int i = 0; i < booksByAuthor.Books.Count; i++)
            {
                if (!pricePerAuthor.ContainsKey(booksByAuthor.Books[i].Author))
                {
                    pricePerAuthor.Add(booksByAuthor.Books[i].Author, 0);

                }

                pricePerAuthor[booksByAuthor.Books[i].Author] += booksByAuthor.Books[i].Price;
            }

            return pricePerAuthor;
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string IsbnNumber { get; set; }
            public double Price { get; set; }

        }
        public class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

    }
}
