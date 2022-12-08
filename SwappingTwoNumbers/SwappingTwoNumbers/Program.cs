

using System; 
namespace SwappingTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;  //Creating variable (a) and assigning (10) value to it.
            int b = 20; //Creating variable (b) and assigning (20) value to it.
            int temp; // Creating (temp) variable to store temporary value.
            Console.WriteLine("Before swapping value of a={0},b={1}", a, b);//printing before swapping values

            temp = a; // Storing (a) value to temp. //temp=10
            a = b; // Storing (b) value to (a). //a=20
            b = temp; // storing temp value in (b) //b=10

            Console.WriteLine("After swapping value of a={0},b={1}", a, b);//printing after swapping values
            Console.ReadLine();
        }
 
   }
}