// Models/NotificationService.cs
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal class NotificationService
    {
        public void NotifyMember(Member member, string message)
        {
            Console.WriteLine($"Notification to {member.Name}: {message}");
        }
    }
}