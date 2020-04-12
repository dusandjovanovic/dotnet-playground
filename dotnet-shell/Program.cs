using System;
using System.Text;

namespace dotnet_shell
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            Console.WriteLine(p.ToString());
        }
    }

    public class Point
    {
        public int X;

        public string y;

        public override string ToString()
        {
            return "is a overriden-method point!";
        }
    }
}
