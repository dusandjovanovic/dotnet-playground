using System;

namespace dotnet_shell
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueA = "FirstValue";
            string valueB = valueA;
            valueA = "AnotherValue";

            Console.WriteLine(valueA);
            Console.WriteLine(valueB);
        }
    }
}
