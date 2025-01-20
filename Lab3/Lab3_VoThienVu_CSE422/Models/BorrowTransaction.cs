// Models/BorrowTransaction.cs
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    public class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }

        public BorrowTransaction(string transactionID, DateTime transactionDate, Member member, Book bookBorrowed) : base(transactionID, transactionDate, member)
        {
            BookBorrowed = bookBorrowed;
        }
        public override void Execute()
        {
            // Logic for borrowing a book
            Console.WriteLine($"{Member.Name} borrowed {BookBorrowed.Title} on {TransactionDate}");
        }
    }
}