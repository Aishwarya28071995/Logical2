using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Int32.Parse(Console.ReadLine());
            for(int i=2;i<number;i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Number is not a prime number");
                }
                else
                {
                    Console.WriteLine("number is a prime number");
                }
            }
        }
    }
}
