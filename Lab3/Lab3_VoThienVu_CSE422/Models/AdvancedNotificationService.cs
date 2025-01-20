using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_VoThienVu_CSE422.Models
{
    public class AdvancedNotificationService : NotificationService
    {
        // Override the method to include a timestamp
        public override void SendNotification(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"[{timestamp}] Notification: {message}");
        }
    }
}
