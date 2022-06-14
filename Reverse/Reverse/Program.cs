using System;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Int32.Parse(Console.ReadLine());
            int remainder;
            int reverse=0;
            while(number>0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }

            Console.WriteLine("The reverse of the number is " + reverse);
        }
    }
}
