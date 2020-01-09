using System;
using Service;

namespace ConverterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterService converter = new ConverterService();
            int choice = 0;
            while (choice != 7)
            {
                Console.WriteLine("\nHuvudmeny/");
                Console.WriteLine("\n1. Tid-Distans-Hastighet");
                Console.WriteLine("2. Liter-Gallon");
                Console.WriteLine("3. Amps-Resist-Volt");
                Console.WriteLine("4. Diameter-Radius");
                Console.WriteLine("5. Fahrenheit-Celsius");
                Console.WriteLine("6. Hours-Minutes");
                Console.WriteLine("7. Avsluta");
                //choice = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Första valet
                    if (choice == 1)
                    {
                        showTimeDistanceSpeedMenu();
                    }

                    // Andra valet 
                    if (choice == 2)
                    {
                        showLiterGallonMenu();
                    }

                    // Tredje valet 
                    if (choice == 3)
                    {
                        
                    }

                    // Fjärde valet 
                    if (choice == 4)
                    {
                        
                    }

                    // Femte valet 
                    if (choice == 5)
                    {
                        
                    }

                    // Sjätte valet 
                    if (choice == 6)
                    {
                        
                    }

                    // Avsluta programmet
                    if (choice == 7)
                    {
                        Console.WriteLine("Avslutar...");
                        break;
                    }

                    // För höga siffror eller nolla
                    else if (choice >= 8 || choice == 0)
                    {
                        Console.WriteLine("Inte giltig siffra.");
                    }
                }
                    // Om TryParse misslyckas (t.ex. bokstav angavs)
                    else
                    {
                        Console.WriteLine("Endast siffror godtas");
                    }
            }
        }

        static void showTimeDistanceSpeedMenu()
        {
            ConverterService converter = new ConverterService();
            float distance;
            float speed;
            float time;
            int choiceFormat = 0;

            while (choiceFormat != 4)
            {
                Console.WriteLine("\nHuvudmeny/Tid-Distans-Hastighet/");
                Console.WriteLine("\n1. Tid");
                Console.WriteLine("2. Distans");
                Console.WriteLine("3. Hastighet");
                Console.WriteLine("4. Återvänd");
                Console.WriteLine("5. Avsluta");
                choiceFormat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // Travel Time
                if (choiceFormat == 1)
                {
                    Console.WriteLine("Ange kilometer");
                    distance = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ange hastighet");
                    speed = float.Parse(Console.ReadLine());
                    Console.WriteLine("Timmar: {0:0.##}", converter.CalculateTravelTime(speed, distance));
                }

                // Travel Distance
                if (choiceFormat == 2)
                {
                    Console.WriteLine("Ange timmar");
                    time = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ange hastighet");
                    speed = float.Parse(Console.ReadLine());
                    Console.WriteLine("Kilometer: {0:0.##}", converter.CalculateTraveledDistance(time, speed));
                }

                // Travel Speed
                if (choiceFormat == 3)
                {
                    Console.WriteLine("Distans");
                    distance = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ange timmar");
                    time = float.Parse(Console.ReadLine());
                    Console.WriteLine("km/h: {0:0.##}", converter.CalculateSpeed(time, distance));
                }

                // Återvänd
                if (choiceFormat == 4){}

                // Avsluta
                else if (choiceFormat == 5)
                {
                    Console.WriteLine("Avslutar...");
                    Environment.Exit(0);
                }
            }
        }

        static void showLiterGallonMenu()
        {
            // Liter Gallon Meny

        }
    }
}
