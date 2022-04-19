using System;
namespace SampleProgram.assignments.chapter4
{
    public class Assignment2
    {
        public static void Main()
        {
            int sum = 0;

            // loop every third integer starting from 2
            for (int i = 2; i < 100; i += 3)
            {
                // skip the initial 2
                if (i == 2)
                {
                    continue;
                }

                // print third integers
                Console.WriteLine("Third integer: " + i);

                // check the integer if it's divisible by 5
                if (i % 5 == 0)
                {
                    // sum the integer which is divisible by 5
                    sum += i;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
