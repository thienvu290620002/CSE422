// Models/Library.cs
using System;
using System.Collections.Generic;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        // Constructor
        public Library(string libraryName)
        {
            LibraryName = libraryName;
            Books = new List<Book>();
            Members = new List<Member>();
        }

        // Method to add a book
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Added book: {book.Title}");
        }

        // Method to add a member
        public void AddMember(Member member)
        {
            Members.Add(member);
            Console.WriteLine($"Added member: {member.Name}");
        }

        // Method to display library information
        public void DisplayLibraryInfo()
        {
            Console.WriteLine($"Library Name: {LibraryName}");
            Console.WriteLine($"Total Books: {Books.Count}");
            Console.WriteLine($"Total Members: {Members.Count}");
        }

        // Method to borrow a book
        public void BorrowBook(Member member, Book book)
        {
            if (book.CopiesAvailable > 0)
            {
                member.BorrowBook(book);
                book.CopiesAvailable--;
            }
            else
            {
                Console.WriteLine($"Sorry, {book.Title} is not available.");
            }
        }

        // Method to return a book
        public void ReturnBook(Member member, Book book)
        {
            member.ReturnBook(book);
            book.CopiesAvailable++;
        }
    }
}