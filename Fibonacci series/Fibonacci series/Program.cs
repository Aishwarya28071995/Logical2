using System;

namespace Fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            
            Console.WriteLine("Enter the number");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write(num1);
            Console.Write(num2);
            for (int i=3;i<=n;i++)
            {
                
                int nextTerm = num1 + num2;
                num1 = num2;
                num2 = nextTerm;
                Console.Write(nextTerm);
            }
        }
    }
}
