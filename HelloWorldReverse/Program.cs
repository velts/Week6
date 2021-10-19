using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            string hWorld = "Hello World!";

            for (int i = hWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(hWorld[i]);
            }
        }
    }
}
