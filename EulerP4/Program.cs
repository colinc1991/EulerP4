/* A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/

using System;

namespace EulerP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestPalindrome = 0;

            for (int i = 999; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    if (IsAPalindrome(i*j))
                    {
                        if (i * j > biggestPalindrome)
                        {
                            biggestPalindrome = i * j;
                        }
                    }
                }
            }

            Console.WriteLine($"The largest palindromic number of two 3-digit numbers far is {biggestPalindrome}");
        }

        /// <summary>
        /// This method takes in an integer and determines whether it is a palindrome or not.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns true if the number is a palindrome and false if not.</returns>
        static bool IsAPalindrome(int number)
        {
            if (number.ToString() == Reverse(number.ToString()))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Following method courtesy of: https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string
        /// <summary>
        /// Takes in a string and returns it in reversed order.
        /// Example: "hello" becomes "olleh"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
