// Models/ReturnTransaction.cs
using Lab3_VoThienVu_CSE422.Interfaces;
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }

        public override void Execute()
        {
            // Logic for returning a book
            Console.WriteLine($"{Member.Name} returned {BookReturned.Title} on {TransactionDate}");
        }
    }
}