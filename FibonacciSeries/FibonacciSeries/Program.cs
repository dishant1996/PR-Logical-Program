
using System;

namespace FibonacciSeries

{
    class Program
    {
        //Declaring the 3 fibonacci terms 
        static int p1 = 0, p2 = 1, p3; 
        static void Main(string[] args)
        {
            //using console.writeline to get the value from cmd
            Console.WriteLine("Please provide input value");
            int count= Int32.Parse(Console.ReadLine());

            //printing the two terms of fibonacci series
            Console.Write(p1 + " " + p2);

            //printing the remaning term of fibonacci series
            for(int i = 2; i < count; i++)
            {
                //now we need to get the next term which is next term is sum of previous two term
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2; //assigning p2 value to p1 value
                p2 = p3; //assigning p3 value to p2 value
            }
            Console.WriteLine();  
        }
    }
}