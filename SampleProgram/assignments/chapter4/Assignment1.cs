using System;
namespace SampleProgram.assignments.chapter4
{
    public class Assignment1
    {
        public static void Main()
        {
            Console.WriteLine("1(i)");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("3*" + i + "=" + 3 * i);
            }
            Console.WriteLine("\n1(ii)");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(5 + (5 * i));
            }
            Console.WriteLine("\n1(iii)");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(20 - (2 * i));
            }
        }
    }
}
