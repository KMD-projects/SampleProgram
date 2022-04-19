using System;
namespace SampleProgram.assignments.chapter4
{
    public class Assignment5
    {
        public static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
