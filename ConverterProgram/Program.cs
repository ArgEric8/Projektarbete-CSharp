using System;
using Service;

namespace ConverterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterService converter = new ConverterService();
            //Start point for the program.
            Console.WriteLine("Start point for the program.");
            


            int choice = 0;
            while (choice != 2)
            {
                Console.WriteLine("\nVälj ett alternativ");
                Console.WriteLine("1. Hej");
                Console.WriteLine("2. Avsluta");
                //choice = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Första valet
                    if (choice == 1)
                    {
                        Console.WriteLine("Hej!");
                    }

                    // Andra valet
                    if (choice == 2)
                    {
                        Console.WriteLine("Avslutar...");
                        break;
                    }

                    // För höga siffror
                    else if (choice >= 3)
                    {
                        Console.WriteLine("Inte giltig siffra.");
                    }
                }
                    else
                    {
                        Console.WriteLine("Endast siffror godtas");
                    }
            }
        }
    }
}
