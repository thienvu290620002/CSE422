// Models/LibraryCard.cs
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal class LibraryCard
    {
        public string CardNumber { get; private set; }
        public Member Owner { get; set; }
        public DateTime IssueDate { get; private set; }

        // Constructor
        public LibraryCard(string cardNumber, Member owner)
        {
            CardNumber = cardNumber;
            Owner = owner;
            IssueDate = DateTime.Now;
        }

        // Method to display card information
        public void DisplayCardInfo()
        {
            Console.WriteLine($"Card Number: {CardNumber}, Card Holder: {Owner.Name}, Issue Date: {IssueDate}");
        }
    }
}