// Models/BorrowTransaction.cs
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }

        public override void Execute()
        {
            // Logic for borrowing a book
            Console.WriteLine($"{Member.Name} borrowed {BookBorrowed.Title} on {TransactionDate}");
        }
    }
}