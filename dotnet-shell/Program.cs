using System;
using System.Text;

namespace dotnet_shell
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            string nullable = s ?? "something";

            StringBuilder builder = null;
            nullable = builder?.ToString();
            int? nullableInt = nullable?.Length;
        }
    }
}
