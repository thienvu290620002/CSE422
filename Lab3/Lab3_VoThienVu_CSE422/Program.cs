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
            Console.WriteLine("----------------------");

            // Create an instance of AdvancedNotificationService
            AdvancedNotificationService advancedNotificationService = new AdvancedNotificationService();
            advancedNotificationService.SendNotification("Welcome to the advanced library service!");
            Console.WriteLine("----------------------");

            // Create a library instance
            Library library = new Library("Downtown Library");
            // Predefined list of books
            library.Books = new List<Book>
            {
                new Book("11-11-11", "Mastering C#", "John Doe", 2020, 5),
                new Book("22-22-22", "Java Concurrency in Practice", "Brian Goetz", 2019, 3),
                new Book("33-33-33", "JavaScript: The Good Parts", "Douglas Crockford", 2017, 4),
                new Book("44-44-44", "Refactoring: Improving the Design of Existing Code", "Martin Fowler", 2020, 2),
                new Book("55-55-55", "Artificial Intelligence: A Modern Approach", "Stuart Russell", 2018, 6),
                new Book("66-66-66", "Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 2019, 7)
            };

            // Predefined list of members
            library.Members = new List<Member>
            {
                new Member("M001", "Alice Smith", "alice.smith@example.com"),
                new Member("M002", "Bob Johnson", "bob.johnson@example.com"),
                new Member("M004", "Charlie Brown", "charlie.brown@example.com"),
                new PremiumMember("M005", "Diana Prince", "diana.prince@example.com", DateTime.Now.AddYears(1), 5),
                new PremiumMember("M003", "Ethan Hunt", "ethan.hunt@example.com", DateTime.Now.AddYears(1), 10),
            };

            // Display all books
            Console.WriteLine("Available Books:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }
            Console.WriteLine("----------------------");
            // Display all members
            Console.WriteLine("\nMembers:");
            foreach (var member in library.Members)
            {
                member.PrintDetails();
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("----------------------");
            // Creating objects of BookClass and BookRecord
            BookClass bookClass1 = new BookClass("54321", "1984", "George Orwell");
            BookClass bookClass2 = new BookClass("54321", "1984", "George Orwell");

            BookRecord bookRecord1 = new BookRecord("54321", "1984", "George Orwell");
            BookRecord bookRecord2 = new BookRecord("54321", "1984", "George Orwell");

            Console.WriteLine($"BookClass objects are equal: {bookClass1 == bookClass2}");
            // BookClass so sánh theo tham chiếu(reference)

            Console.WriteLine($"BookRecord objects are equal: {bookRecord1 == bookRecord2}");
            // BookRecord so sánh theo giá trị(value).

            // Update Value = with 
            BookRecord bookRecord3 = bookRecord1 with { Title = "1984 - Special Edition" };

            Console.WriteLine($"Original Title: {bookRecord1.Title}");
            Console.WriteLine($"Updated Title: {bookRecord3.Title}");

            Console.WriteLine("---------------");
            // Create some books and members
            Book book20 = new Book("77-77-77", "The Pragmatic Programmer", "Andrew Hunt", 2021, 4);
            Book book21 = new Book("88-88-88", "Design Patterns: Elements of Reusable Object-Oriented Software", "Erich Gamma", 2020, 2);
            Member member1 = new Member("M008", "Fiona Green", "fiona.green@email.com");
            Member member2 = new Member("M009", "George Black", "george.black@email.com");

            // Add books and members to the library
            library.Books.Add(book20);
            library.Books.Add(book21);
            library.Members.Add(member1);
            library.Members.Add(member2);
            Console.WriteLine("----Add More Book----");
            Console.WriteLine("\nUpdated Library Status:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }
            Console.WriteLine("----Add More Member----");
            Console.WriteLine("\nUpdated Library Status:");
            foreach (var mem in library.Members)
            {
                mem.PrintDetails();
            }
            library.OnBookBorrowed += (book, member) =>
            {
                Console.WriteLine($"{member.Name} borrowed the book '{book.Title}'.");
            };
            // Borrow a book and execute the transaction

            library.OnBookBorrowed += (bookClass1, member1) =>
            {
                bookClass1.CopiesAvailable--;
            };
            Console.WriteLine("-------------");
            library.BorrowBook(book21, member1);
            Console.WriteLine("-------------");
            library.BorrowBook(book20, member2);
            Console.WriteLine("-------------");

            // Display final library status
            Console.WriteLine("\nFinal Library Status:");
            foreach (var book in library.Books)
            {
                book.PrintDetails();
            }
            Console.WriteLine("\nFinal Library Members:");
            foreach (var member in library.Members)
            {
                member.PrintDetails();
            }
            Console.Read();
        }
    }
}