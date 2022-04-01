using System;
namespace SampleProgram.assignments.chapter3
{
    public class Assignment2
    {
        public static void Main()
        {
            const int SPEED_LIMIT = 55;
            try
            {
                int ticket = 0;
                int speed = 0;

                Console.Write("Enter your speed: ");
                speed = Convert.ToInt32(Console.ReadLine());

                if (speed < 0)
                {
                    Console.WriteLine("Invalid data.");
                }
                else
                {
                    ticket = (speed > SPEED_LIMIT) ? 1 : 0;
                    Console.WriteLine("Ticket: " + ticket);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data.");
            }
        }
    }
}
