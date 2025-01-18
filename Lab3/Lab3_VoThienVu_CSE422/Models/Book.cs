// Models/Book.cs
using Lab3_VoThienVu_CSE422.Interfaces;
using System;

namespace Lab3_VoThienVu_CSE422.Models
{
    internal class Book : IPrintable
    {
        private string _isbn;
        private string _title;
        private string _author;
        private int _year;
        private int _copiesAvailable;

        public string ISBN
        {
            get => _isbn;
            set => _isbn = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Year cannot be less than 0.");
                _year = value;
            }
        }

        public int CopiesAvailable
        {
            get => _copiesAvailable;
            set
            {
                if (value < 0)
                    throw new ArgumentException("CopiesAvailable cannot be less than 0.");
                _copiesAvailable = value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {Author}, Year: {Year}, Copies Available: {CopiesAvailable}");
        }

        public void PrintDetails()
        {
            DisplayInfo();
        }
    }
}