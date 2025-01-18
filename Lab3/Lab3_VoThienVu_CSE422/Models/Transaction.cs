// Models/Transaction.cs
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal abstract class Transaction
    {
        public string TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public Member Member { get; set; }

        public abstract void Execute();
    }
}