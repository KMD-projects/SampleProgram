using System;
namespace SampleProgram
{
    public class Eg2
    {
        static void Main(string[] args)
        {
            String StudentName, Section, Time;

            StudentName = "Sandi Chit";
            Section = "L4DC147";
            Time = "10:00-11:00";

            Console.WriteLine("Student Name= " + StudentName + "\n" + "Section = " + Section + " Time = " + Time);

            int myan, eng, math;
            int result;

            myan = 90;
            eng = 70;
            math = 80;
            result = (myan + eng) / math;

            Console.WriteLine("Myanmar= " + myan);
            Console.WriteLine("English= " + eng);
            Console.WriteLine("Mathematic= " + math);
            Console.WriteLine("Result = " + result);
            Console.Read();
        }

    }
}
