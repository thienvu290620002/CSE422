using System;

namespace Lab1_VoThienVu_CSE422.Source.Problem3
{
    public class WordSearch
    {
        public static bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || word == null || word.Length == 0)
                return false;

            int rows = board.Length;
            int cols = board[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Backtrack(board, word, i, j, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool Backtrack(char[][] board, string word, int row, int col, int index)
        {
            // Check if we have found the word
            if (index == word.Length)
                return true;

            // Check boundaries and if the current cell matches the current character in the word
            if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || board[row][col] != word[index])
                return false;

            // Mark the cell as visited by using a temporary character
            char temp = board[row][col];
            board[row][col] = '#'; // Use '#' as a marker for visited cells

            // Explore all possible directions: up, down, left, right
            bool found = Backtrack(board, word, row + 1, col, index + 1) || // down
                         Backtrack(board, word, row - 1, col, index + 1) || // up
                         Backtrack(board, word, row, col + 1, index + 1) || // right
                         Backtrack(board, word, row, col - 1, index + 1);   // left

            // Restore the cell's original value
            board[row][col] = temp;

            return found;
        }
    }
}