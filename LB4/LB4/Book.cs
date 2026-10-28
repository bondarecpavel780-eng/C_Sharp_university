using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    internal class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public string Author { get; private set; } = string.Empty;
        public bool IsAvailable { get; private set; } = true;
        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
        public void SetAvailability(bool status)
        {
            IsAvailable = status;
        }
    }
}
