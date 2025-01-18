// Interfaces/IMemberActions.cs
using Lab3_VoThienVu_CSE422.Models;

namespace Lab3_VoThienVu_CSE422.Interfaces
{
    internal interface IMemberActions
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}