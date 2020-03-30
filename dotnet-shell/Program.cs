using System;

namespace dotnet_shell
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = FeetToInches(10);
            System.Console.WriteLine(x);

            string message = "Hello world!";
            string upperMessage = x.ToString() + " " + message.ToUpper();
            Console.WriteLine(upperMessage);

            bool lessThan120 = x < 120;
            Console.WriteLine(lessThan120);
        }

        static int FeetToInches(int feet)
        {
            int @inches = feet * 12;
            return inches;
        }
    }
}
