using System;
namespace SampleProgram.assignments.chapter3
{
    public class Assignment1
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter your mark: ");
                int mark = Convert.ToInt32(Console.ReadLine());

                if (mark < 0 || mark > 100)
                {
                    Console.WriteLine("Invalid data.");
                }
                else if (mark > 70)
                {
                    Console.WriteLine("Class A");
                }
                else
                {
                    Console.WriteLine("Class B");
                }
            } catch(Exception)
            {
                Console.WriteLine("Invalid data.");
            }
        }
    }
}
