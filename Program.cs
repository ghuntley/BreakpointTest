using System;

namespace BreakpointTest
{
    class Program
    {
        private static string x;
        static void Main(string[] args)
        {

            x = string.Empty;

            x = "Gitpod";

            Console.WriteLine("Hello {0}!", x);
        }
    }
}
