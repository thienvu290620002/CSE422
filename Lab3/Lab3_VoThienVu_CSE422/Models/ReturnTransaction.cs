// Models/ReturnTransaction.cs
using Lab3_VoThienVu_CSE422.Interfaces;
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    public class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }

        public ReturnTransaction(string transactionID, DateTime transactionDate, Member member, Book bookReturned)
           : base(transactionID, transactionDate, member) // Call the base class constructor
        {
            BookReturned = bookReturned;
        }
        public override void Execute()
        {
            // Logic for returning a book
            Console.WriteLine($"{Member.Name} returned {BookReturned.Title} on {TransactionDate}");
        }
    }
}