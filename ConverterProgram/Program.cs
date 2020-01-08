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
                Console.WriteLine("1. Time = distance / speed");
                Console.WriteLine("2. Avsluta");
                //choice = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Första valet - Time = distance / speed
                    if (choice == 1)
                    {
                        Console.WriteLine("Mata in distans");
                        float distance = float.Parse(Console.ReadLine());

                        Console.WriteLine("Mata in hastighet");
                        float speed = float.Parse(Console.ReadLine());

                        ConverterService testrun = new ConverterService();
                        testrun.CalculateTravelTime(speed, distance);
                    }
                    if (choice == 2)
                    {
                       Console.WriteLine("alternativ 1 Gallons");
                       Console.WriteLine("Alternativ 2 Liters");
                       Console.WriteLine("Alternativ 3 Gallons och liter");
                       Console.WriteLine("Alternativ 4 Tillbaka ");
                       



                    }

                    // Andra valet
                    if (choice == 3)
                    {
                        Console.WriteLine("Avslutar...");
                        break;
                    }

                    // För höga siffror
                    else if (choice >= 4)
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
