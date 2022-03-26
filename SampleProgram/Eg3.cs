using System;
namespace SampleProgram
{
    public class Eg3
    {
        public static void Main2()
        {
            int num1, num2, result;

            try
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 + num2;

                Console.WriteLine("First number : " + num1);
                Console.WriteLine("Second number : " + num2);
                Console.WriteLine("Result : " + result);
                Console.WriteLine("Average : " + result / 2);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Data.");
            }
        }
    }
}
