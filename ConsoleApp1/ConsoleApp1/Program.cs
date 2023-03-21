using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double product = 20;
            int year = 2000;
            while (product < 50)
            {
                year = year + 2;
                product = (product * 1.2);
            }
            Console.WriteLine("{0} is the first year our product is above 50 tons", year);
        }
    }
}
