using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<number;i++)
            {
                if(number%i == 0)
                {
                    sum = sum + i;
                    
                }
            }
            
            if(sum == number)
            {
                Console.WriteLine("Number is a perfect number");
            }
            else
            {
                Console.WriteLine("Number is not a perfect number");
            }
        }
    }
}
