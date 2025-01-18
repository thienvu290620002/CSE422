// Program.cs
using System;
using System.Collections.Generic;
using Lab3_VoThienVu_CSE422.Models;

namespace Lab3_VoThienVu_CSE422
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create a library instance
            Library library = new Library("City Library");

            // Predefined list of books
            library.Books = new List<Book>
            {
                new Book { ISBN = "978-3-16-148410-0", Title = "C# Programming", Author = "John Doe", Year = 2020, CopiesAvailable = 5 },
                new Book { ISBN = "978-1-234-56789-7", Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", Year = 2009, CopiesAvailable = 3 },
                new Book { ISBN = "978-0-321-48681-7", Title = "Clean Code", Author = "Robert C. Martin", Year = 2008, CopiesAvailable = 2 },
                new Book { ISBN = "978-0-201-63361-0", Title = "Design Patterns", Author = "Erich Gamma", Year = 1994, CopiesAvailable = 4 },
                new Book { ISBN = "978-0-262-03384-8", Title = "Artificial Intelligence: A Modern Approach", Author = "Stuart Russell", Year = 2010, CopiesAvailable = 3 },
                new Book { ISBN = "978-0-321-56384-2", Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 2019, CopiesAvailable = 6 }
            };

            // Predefined list of members
            library.Members = new List<Member>
            {
                new Member { MemberID = "M001", Name = "Alice", Email = "alice@example.com" },
                new Member { MemberID = "M002", Name = "Bob", Email = "bob@example.com" },
                new PremiumMember { MemberID = "M003", Name = "Charlie", Email = "charlie@example.com", MembershipExpiry = DateTime.Now.AddYears(1), MaxBooksAllowed = 10 },
                new Member { MemberID = "M004", Name = "Dave", Email = "dave@example.com" },
                new PremiumMember { MemberID = "M005", Name = "Eve", Email = "eve@example.com", MembershipExpiry = DateTime.Now.AddYears(1), MaxBooksAllowed = 5 }
            };

            // Display all books
            Console.WriteLine("Available Books:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }

            // Display all members
            Console.WriteLine("\nMembers:");
            foreach (var member in library.Members)
            {
                member.PrintDetails();
            }

            // Simulate borrowing books
            Console.WriteLine("\n--- Borrowing Books ---");
            var borrowTransaction1 = new BorrowTransaction
            {
                TransactionID = "T001",
                TransactionDate = DateTime.Now,
                Member = library.Members[0], // Alice
                BookBorrowed = library.Books[0] // "C# Programming"
            };
            borrowTransaction1.Execute();
            library.Books[0].CopiesAvailable--; // Update the available copies
            Console.WriteLine("\nUpdated Library Status:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }

            Console.WriteLine();

            var borrowTransaction2 = new BorrowTransaction
            {
                TransactionID = "T002",
                TransactionDate = DateTime.Now,
                Member = library.Members[1], // Bob
                BookBorrowed = library.Books[1] // "Introduction to Algorithms"
            };
            borrowTransaction2.Execute();
            library.Books[1].CopiesAvailable--; // Update the available copies
            Console.WriteLine("\nUpdated Library Status:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }

            // Simulate returning books
            Console.WriteLine("\n--- Returning Books ---");
            var returnTransaction1 = new ReturnTransaction
            {
                TransactionID = "T003",
                TransactionDate = DateTime.Now,
                Member = library.Members[0], // Alice
                BookReturned = library.Books[0] // "C# Programming"
            };
            returnTransaction1.Execute();
            library.Books[0].CopiesAvailable++; // Update the available copies
            Console.WriteLine("\nUpdated Library Status After Return:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }

            // Display final library status
            Console.WriteLine("\nFinal Library Status:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }

            Console.ReadLine();
        }
    }
}