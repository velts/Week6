using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string dPanic = "Don't Panic";

            dPanic = dPanic.Replace('o', '0');
            dPanic = dPanic.Replace('a', '4');

            Console.WriteLine(dPanic);
        }
    }
}
