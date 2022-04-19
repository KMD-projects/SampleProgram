using System;
namespace SampleProgram.assignments.chapter4
{
    public class Assignment4
    {
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
