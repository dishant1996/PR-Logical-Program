//Armstrong Number in c#

//Armstrong Number is a number that is equal to sum od cube of its digits.

//ex :

//371 = (3*3*3)+(7*7*7)+(1*1*1)      
//where:
//(3 * 3 * 3) = 27
//(7 * 7 * 7) = 343
//(1 * 1 * 1) = 1
//So:
//27 + 343 + 1 = 371


using System;
using System.Collections.Generic;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           // First of all, we define four integer variable numbers, sum, rem and temp
           // then assign zero(0) to the sum.
            int number, rem, temp, sum = 0;

            //printing title (Check Number Is Armstrong Or Not)
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("          Check Number Is Armstrong Or Not             ");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter Your Number To Check :: ");
            number = int.Parse(Console.ReadLine());

            //Now assign this user input number to our temp variable for future use.
             temp = number;

            //Then we create while loop until the number became zero(0).
            while (number > 0)
            {
                
                //First, we find the Remainder of the number by module its by 10.
                rem = number % 10; 

                //Then we get the power of this remainder by simply
                //multiply it three times and add in our sum variable.
                sum = sum + (rem * rem * rem);

                //Last, we divide the number by 10.
                number = number / 10;
            }


            //After a loop, check if the temp variable and sum variable are equal.
            //If both are equal, then it's an Armstrong number, otherwise not.
            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");

            //Then we use the Console.ReadKey() method to read any key from the console.
            Console.ReadKey(); 

        }
    }
}
