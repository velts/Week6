using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi:");
            
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;

            Console.WriteLine("sisesta perekonnanimi");
            
            string lastName = Console.ReadLine();
            
            int lastNameLength = lastName.Length;

            if(firstNameLength < lastNameLength)
            {
                Console.WriteLine("Sinu perekonna nimi on numbriliselt suurem");
            }
            else if(firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on numbriliselt suurem");
            }
            else
            {
                Console.WriteLine("Sinu nimed on võrdse pikkusega");
            }


        }
    }
}
