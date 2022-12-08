

//PRIME NUMBER IS A NUMBER THAT IS ONLY DIVISIBLE BY 1 OR ITSELF.

//Prime number is not a negetive number.
//Prime number is not a floating point number.
//Prime number is natural number.
using System;

namespace CheckPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 7; //
            int count = 0;  //

            for (int i = 1; i <=number; i++)
            {
                if (number % i == 0) 
                {
                    count++; 
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }

            Console.ReadLine();
        }
    }
}
