using System;
namespace project1
{
    internal class Library
    {
        public Book[] books = new Book[0];

        public void AddBook(string title, string author, int year)
        {
            Book newBook = new Book(title, author, year);
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = newBook;
        }
    }
}

