using System;
using System.Text;

namespace dotnet_shell
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var unnamedTuple = ("hello", "there");
            var namedTuple = (first: "hello", second: "there");

            (string first, string second)? nullableTuple = namedTuple;
        }
    }
}