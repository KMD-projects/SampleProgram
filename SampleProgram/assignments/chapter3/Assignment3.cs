using System;
namespace SampleProgram.assignments.chapter3
{
    public class Assignment3
    {
        public static void Main()
        {
            Console.Write("Enter character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            switch (ch)
            {
                case 'y':
                case 'Y':
                    Console.WriteLine("Yes");
                    break;

                case 'n':
                case 'N':
                    Console.WriteLine("No");
                    break;

                default:
                    Console.WriteLine("Unknown response");
                    break;
            }
        }
    }
}
