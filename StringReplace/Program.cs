using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string hellow = "Hello World";

            hellow = hellow.Replace('o', '*');
            Console.WriteLine(hellow);
        }
    }
}
