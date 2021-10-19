using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siesta lause Hello World");
            string lause = Console.ReadLine().ToLower();
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < lause.Length; i++)
            {
                if (lause[i] == 'h')
                {
                    hCounter++;
                }
                else if (lause[i] == 'o')
                {
                    oCounter++;
                }
                else if (lause[i] == 'l')
                {
                    lCounter++;
                }

                

            }
            Console.WriteLine($"Lauses on {hCounter} h tahte, {oCounter} o tahte ja {lCounter}");
        }
    }
}
