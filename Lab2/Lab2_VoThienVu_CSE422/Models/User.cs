﻿using System.ComponentModel.DataAnnotations;

namespace Lab2_VoThienVu_CSE422.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
