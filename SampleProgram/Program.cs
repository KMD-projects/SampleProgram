using System;

namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void CalculateTax()
        {
            int income;
            float tax;

            Console.Write("Enter your income: ");
            income = Convert.ToInt32(Console.ReadLine());

            if (income >= 100000)
            {
                tax = 0.8f;
            }
            else if (income >= 50000)
            {
                tax = 0.4f;
            }
            else
            {
                tax = 0.2f;
            }

            Console.WriteLine("Tax: " + tax);
        }
    }
}
