// Models/Member.cs
using Lab3_VoThienVu_CSE422.Interfaces;
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    public class Member : IPrintable, IMemberActions
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Member(string memberID, string name, string email)
        {
            MemberID = memberID;
            Name = name;
            Email = email;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}, Name: {Name}, Email: {Email}");
        }

        public void PrintDetails()
        {
            DisplayInfo();
        }

        public void BorrowBook(Book book)
        {
            Console.WriteLine($"{Name} borrowed {book.Title}");
        }

        public void ReturnBook(Book book)
        {
            Console.WriteLine($"{Name} returned {book.Title}");
        }
    }
}