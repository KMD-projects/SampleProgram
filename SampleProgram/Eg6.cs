using System;
namespace SampleProgram
{
    public class Eg6
    {
        public static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
