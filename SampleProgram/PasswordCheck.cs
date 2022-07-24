using System;
namespace SampleProgram
{
    public class PasswordCheck
    {

        const string ACC_USERNAME = "Rio";
        const string ACC_PASSWORD = "abacd";

        const int MAX_ATTEMPTS = 3;

        public static void Main()
        {
            int Attempts = 0;
            bool Authenticated;

            do
            {
                Console.Write("Enter Your Name: ");
                string Username = Console.ReadLine();
                Console.Write("Enter Your Password: ");
                string Password = Console.ReadLine();
                if (Username == ACC_USERNAME && Password == ACC_PASSWORD)
                {
                    Authenticated = true;
                }
                else
                {
                    Console.WriteLine("Login failed!");
                    Authenticated = false;
                    Attempts++;
                }
            } while (!Authenticated && Attempts < MAX_ATTEMPTS);

            if (Authenticated)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("You are trying too many times. Pleaes try again later");
            }

            Console.Read();
        }
    }

    internal class PasswordCheckOld
    {
        static void Main2(string[] args)
        {
            string username = "Rio";
            string Check_User = "";
            string password = "abacd";
            string Check_Password = "";
            int Type_Count = 0;
            int Check_Type = 3;
            bool OverLimit = false;  //To control the Check_Type

            // we can type 3 times (password and username)
            while (password != Check_Password || username != Check_User && !OverLimit)
            {
                if (Type_Count < Check_Type)
                {
                    Console.Write("Enter Your Name: ");
                    Check_User = Console.ReadLine();
                    Console.Write("Enter Your Password: ");
                    Check_Password = Console.ReadLine();
                    Type_Count++;  // increasement the type_count's count
                }
                else
                {
                    OverLimit = true;
                }
            }
            // If we wrong 3 times the result will be shown below
            if (OverLimit)
            {
                Console.WriteLine("Try again later");
            }
            else
            {
                Console.WriteLine("Accept");
            }
        }
    }
}
