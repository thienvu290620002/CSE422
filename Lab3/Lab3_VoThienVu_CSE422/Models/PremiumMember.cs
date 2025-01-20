// Models/PremiumMember.cs
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    public class PremiumMember : Member
    {
        public DateTime MembershipExpiry { get; set; }
        public int MaxBooksAllowed { get; set; }

        // Constructor for PremiumMember
        public PremiumMember(string memberID, string name, string email, DateTime membershipExpiry, int maxBooksAllowed)
            : base(memberID, name, email) // Call the base class constructor
        {
            MemberID = memberID;
            Name = name;
            Email = email;
            MembershipExpiry = membershipExpiry;
            MaxBooksAllowed = maxBooksAllowed;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}, Name:{Name} ,Email:{Email} ,Membership Expiry: {MembershipExpiry},Max Books Allowed: {MaxBooksAllowed}");
        }
    }
}