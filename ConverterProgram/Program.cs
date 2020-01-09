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
            while (choice != 3)
            {
                Console.WriteLine("\nVälj ett alternativ");
                Console.WriteLine("1. Time = distance / speed");
                Console.WriteLine("2. Gallons");
                Console.WriteLine("3. Avsluta");
                //choice = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Första valet - Time = distance / speed
                    if (choice == 1)
                    {
                        ConverterService testrun = new ConverterService();
                        float distance;
                        float speed;
                        Console.WriteLine("\nVälj");
                        Console.WriteLine("1. Meter / sekund");
                        Console.WriteLine("2. Kilometer / timme");
                        int choiceFormat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        // Meter / Sekund
                        if (choiceFormat == 1)
                        {
                            Console.WriteLine("Hur många meter?");
                            distance = float.Parse(Console.ReadLine());
                            Console.WriteLine("Hur många meter per sekund?");
                            speed = float.Parse(Console.ReadLine());

                            Console.WriteLine("Sekunder: {0:0.##} sekunder",testrun.CalculateTravelTime(speed, distance));
                            Console.WriteLine("Minuter: {0:0.##}", testrun.CalculateTravelTime(speed, distance)/60);
                            Console.WriteLine("Timmar: {0:0.##}", testrun.CalculateTravelTime(speed, distance)/60/60);
                        }

                        // Kilometer / Timme
                        else if (choiceFormat == 2)
                        {
                            Console.WriteLine("Hur många kilometer?");
                            distance = float.Parse(Console.ReadLine());
                            Console.WriteLine("Hur många kilometer per timme?");
                            speed = float.Parse(Console.ReadLine());

                            Console.WriteLine("Svar: {0:0.0#} timmar", testrun.CalculateTravelTime(speed, distance));
                        }
                    }

                    // Andra valet
                    if (choice == 2)
                    {
                       Console.WriteLine("alternativ 1 Gallons");
                       Console.WriteLine("Alternativ 2 Liters");
                       Console.WriteLine("Alternativ 3 Gallons och liter");
                       Console.WriteLine("Alternativ 4 Tillbaka ");
                    }

                    // Tredje valet
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
