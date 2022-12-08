
//PROGRAM FOR SWAPPING TWO NUMBERS WITHOUT USING THIRD VARIABLE.

//LOGIC :
//Suppose a=10 , b=20
//a=a+b /a=10+20 /a=30
//b=a-b /b=30-20 /b=10
//a=a-b /a=30-10 /a=20
// so , a=20 , b=10

using System;

namespace WithoutUsingThirdVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;  //Creating variable (a) and assigning (10) value to it.
            int b = 20; //Creating variable (b) and assigning (20) value to it.
            
            Console.WriteLine("Before swapping value of a={0},b={1}", a, b);//printing before swapping values

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping value of a={0},b={1}", a, b);//printing after swapping values
            Console.ReadLine();
        }

    }
}