using ClassLibrary1;
using System;

namespace ConsoleAppNet4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commonClass = new CommonClass(100);
            Console.WriteLine(commonClass.UsedByNet4());
        }

        public static void UnusedNet4()
        {

        }
    }
}