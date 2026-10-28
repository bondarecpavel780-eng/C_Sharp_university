using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    internal class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Book[] RentedBooks { get; private set; }
        public int RentedCount { get; private set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
            RentedBooks = new Book[3];
            RentedCount = 0;
        }

        public void BorrowBook(Book book)
        {
            if (RentedCount < RentedBooks.Length)
            {
                RentedBooks[RentedCount] = book;
                RentedCount++;
            }
            else
            {
                Console.WriteLine("User already takes to much books!");
            }
        }
    }
}
