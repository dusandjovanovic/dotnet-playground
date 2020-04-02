using System;

namespace dotnet_shell
{
    public class Point
    {
        public int x, y;
    }

    public struct CPoint
    {
        public int x, y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            Console.WriteLine($"Hello there {x}");
        }
    }
}
