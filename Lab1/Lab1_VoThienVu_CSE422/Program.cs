using System;
using Lab1_VoThienVu_CSE422.Source.Problem1;
using Lab1_VoThienVu_CSE422.Source.Problem2;
using Lab1_VoThienVu_CSE422.Source.Problem3;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Median of Two Sorted Arrays
            Console.WriteLine("Problem 1");
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            Console.WriteLine("Median: " + MedianFinder.FindMedianSortedArrays(nums1, nums2)); // Output: 2.00000

            nums1 = new int[] { 1, 2 };
            nums2 = new int[] { 3, 4 };
            Console.WriteLine("Median: " + MedianFinder.FindMedianSortedArrays(nums1, nums2)); // Output: 2.50000

            // Problem 2: Divide Two Integers
            Console.WriteLine("Problem 2");
            Console.WriteLine("Divide 10 by 3: " + Divider.Divide(10, 3)); // Output: 3
            Console.WriteLine("Divide 7 by -3: " + Divider.Divide(7, -3)); // Output: -2
            Console.WriteLine("Divide -8 by 2: " + Divider.Divide(-8, 2)); // Output: -4
            Console.WriteLine("Divide -8 by -2: " + Divider.Divide(-8, -2)); // Output: 4
            Console.WriteLine("Divide int.MinValue by -1: " + Divider.Divide(int.MinValue, -1)); // Output: 2147483647 (overflow case)

            // Problem 3: Word Search
            Console.WriteLine("Problem 3");
            char[][] board1 = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            string word1 = "ABCCED";
            Console.WriteLine("Word exists: " + WordSearch.Exist(board1, word1)); // Output: true

            char[][] board2 = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            string word2 = "SEE";
            Console.WriteLine("Word exists: " + WordSearch.Exist(board2, word2)); // Output: true

            char[][] board3 = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            string word3 = "ABCB";
            Console.WriteLine("Word exists: " + WordSearch.Exist(board3, word3)); // Output: false
        }
    }
}