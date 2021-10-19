using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi;");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Sisesta Perekonnanimi:");
            string lastName = Console.ReadLine().ToLower();

            string fullName = $"{firstName}{lastName}".ToLower();

            int aCounter = 0;

            for (int i = 0; i < firstName.Length; i++) 
            {
                if (firstName[i] == 'a')
                {
                    aCounter++;
                }
            }
            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' tahte.");
            }
            else
            {
                Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' taht.");
            }
        }
    }
}
