﻿using System;
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

                            Console.WriteLine("Sekunder: {0:0.##}", converter.CalculateTravelTime(speed, distance));
                        }

                        // Kilometer / Timme
                        else if (choiceFormat == 2)
                        {
                            Console.WriteLine("");
                        }
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

        public showTimeDistanceSpeedMenu();
        {

        }
    }
}
