using System;

namespace Lab1_VoThienVu_CSE422.Source.Problem2
{
    public class Divider
    {
        public static int Divide(int dividend, int divisor)
        {
            // Handle edge case for overflow
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue; // Overflow case
            }

            // Determine the sign of the result
            bool isNegative = (dividend < 0) ^ (divisor < 0);

            // Work with positive values for easier calculation
            long absDividend = Math.Abs((long)dividend);
            long absDivisor = Math.Abs((long)divisor);
            int quotient = 0;

            // Use bit manipulation to perform the division
            while (absDividend >= absDivisor)
            {
                long tempDivisor = absDivisor, multiple = 1;

                // Double the divisor until it is larger than the dividend
                while (absDividend >= (tempDivisor << 1))
                {
                    tempDivisor <<= 1;
                    multiple <<= 1;
                }

                // Subtract the largest found divisor from the dividend
                absDividend -= tempDivisor;
                quotient += (int)multiple;
            }

            // Apply the sign to the result
            return isNegative ? -quotient : quotient;
        }
    }
}