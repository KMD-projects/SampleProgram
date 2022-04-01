using System;
namespace SampleProgram
{
    public class Student
    {
        public static void Main()
        {
            // assignment 1
            string name;
            float mark1, mark2;
            name = "Myo Lwin Oo";
            mark1 = 34;
            mark2 = 27;

            // assignment 2
            int avg = (int)((mark1 + mark2) / 2);
            Console.WriteLine("avg = " + avg);

            // assignment 3
            int x = 5, y = 6, z, k;
            z = ++y - x--;
            k = x-- + --y;
            Console.WriteLine("z = " +z);
            Console.WriteLine("k = " +k);

            // assignment 4a
            int a, b, c;
            a = 1;
            b = 2;
            c = 3;
            a = b * c;
            // assignment 4b
            int q = b / c;
            // assignment 4c
            int i = 5;
            i++;
            Console.WriteLine("i = " + i);
        }
    }
}
