using System;
using System.Text;

namespace dotnet_shell
{
    class Program
    {
        static string x = "old";

        static ref string GetX() => ref x; 

        static void Main(string[] args)
        {
            int x, y, z = 11;
            x = y = z = 11;
        }
    }
}
