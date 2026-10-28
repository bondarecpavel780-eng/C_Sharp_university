using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    internal class Library
    {
        public Book[] Books { get; private set; } = new Book[100];
        public int BookCount { get; private set; } = 0;
        public User[] Users { get; private set; } = new User[50];
        public int UserCount { get; private set; } = 0;
        public void AddBook(Book book)
        {
            if (BookCount < Books.Length)
            {
                Books[BookCount] = book;
                BookCount++;
            }
            else
            {
                Console.WriteLine("Limit free place");
            }
        }
        public void AddUser(User user)
        {
            if (UserCount < Users.Length)
            {
                Users[UserCount] = user;
                UserCount++;
            }
            else
            {
                Console.WriteLine("Limit free place");
            }
        }
        public void RentBookToUser(int userId, int bookId)
        {
            Book foundBook = null;
            foreach (Book b in Books)
            {
                if (b != null && b.Id == bookId)
                {
                    foundBook = b;
                    Console.WriteLine($"Success! Book with ID {b.Id} found");
                    break;
                }
            }
            if (foundBook == null)
            {
                Console.WriteLine("Book with this ID doesnt found");
                return;
            }

            User foundUser = null;
            foreach (User u in Users)
            {
                if (u != null && u.Id == userId)
                {
                    foundUser = u;
                    Console.WriteLine($"Success! User with ID {u.Id} found");
                    break;
                }
            }
            if (foundUser == null)
            {
                Console.WriteLine("User with this ID doesnt found");
                return;
            }

            if (foundBook != null && foundUser != null)
            {
                if (foundBook.IsAvailable == true)
                {
                    if (foundUser.RentedCount < foundUser.RentedBooks.Length)
                    {
                        foundBook.SetAvailability(false);
                        foundUser.BorrowBook(foundBook);
                        Console.WriteLine($"{foundUser.Name} takes the book: {foundBook.Title}");
                    }
                    else
                    {
                        Console.WriteLine($"{foundUser.Name} cannot take more books");
                    }
                }
                else
                {
                    Console.WriteLine($"{foundBook.Title} is absent (already rented)");
                }
            }
            Console.WriteLine("====================");
        }
    }
}
