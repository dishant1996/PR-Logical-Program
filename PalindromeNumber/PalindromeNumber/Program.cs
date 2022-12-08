
using System;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 121; //creating variable (number) and assigning (121) value.
            int rem; // creating reminder to know the last digit of assignied value. (for reversing)
            int result = 0; // creating result variale to store reverse value.

            while (number != 0)
            {
                rem = number % 10;
                result = result * 10 + rem; // storing result value.
                number = number / 10; //printing quoitation value.
            }

               Console.WriteLine(result);
               Console.ReadLine();
        }
    }
}
