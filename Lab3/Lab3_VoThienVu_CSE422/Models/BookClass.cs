using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_VoThienVu_CSE422.Models
{
    public class BookClass
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public BookClass(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }
        public override bool Equals(object obj)
        {
            if (obj is BookClass other)
            {
                return ISBN == other.ISBN &&
                       Title == other.Title &&
                       Author == other.Author;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ISBN, Title, Author);
        }
    }
}
