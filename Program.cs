using System;

namespace BreakpointTest
{
    class Program
    {
        private static string x;
        static void Main(string[] args)
        {

            x = "hello";

            x = "world";

            Console.WriteLine("Hello World!");
        }
    }
}
