using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;

namespace LB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book(1, "It", "Stivin King");
            Book book2 = new Book(2, "ASD", "Pavel Bondarets");
            Book book3 = new Book(3, "Sigma", "NoName");
            Book book4 = new Book(4, "67", "Children");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            User user1 = new User(1, "Pavel");
            User user2 = new User(2, "Dasha");
            User user3 = new User(3, "Vanya");
            User user4 = new User(4, "Dima");
            User user5 = new User(5, "Kati");

            library.AddUser(user1);
            library.AddUser(user2);
            library.AddUser(user3);
            library.AddUser(user4);

            library.RentBookToUser(1, 1);
            library.RentBookToUser(1, 2);
            library.RentBookToUser(1, 3);
            library.RentBookToUser(1, 4);
            library.RentBookToUser(2, 4);
            library.RentBookToUser(3, 4);
        }
    }
}
