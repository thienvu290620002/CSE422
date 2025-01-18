// Models/PremiumMember.cs
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal class PremiumMember : Member
    {
        public DateTime MembershipExpiry { get; set; }
        public int MaxBooksAllowed { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Membership Expiry: {MembershipExpiry}, Max Books Allowed: {MaxBooksAllowed}");
        }
    }
}