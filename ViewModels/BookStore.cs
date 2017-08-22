using System.Collections.Generic;

namespace WebStarter.Models
{
    public class BookStoreViewModel
    {
        public string StoreName { get; set; }
        public IList<Book> Books {get;set;} = new List<Book>();


        public BookStoreViewModel()
        {
            this.Books.Add(new Book{Title = "Cat in the hat",Author = "Dr. S",Price = 3.50});

            this.Books.Add(new Book{Title = "Horthan Hears a Who",Author = "Dr. S",Price = 3.50});

            this.Books.Add(new Book{Title = "How the Grinch Stole Christmas",Author = "Dr. S",Price = 3.50});
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }

}