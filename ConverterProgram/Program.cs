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
<<<<<<< HEAD
                Console.WriteLine("1. Time / distance / speed");
                Console.WriteLine("2. Gallons");
                Console.WriteLine("3. Avsluta");
=======
                Console.WriteLine("1. Hej");
                Console.WriteLine("2. Avsluta");
>>>>>>> e5c2f13b8c597ec702e4b61fb217da3df75a1812
                //choice = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Första valet 
                    if (choice == 1)
                    {
<<<<<<< HEAD
                        // ConverterService testrun = new ConverterService();
=======
>>>>>>> e5c2f13b8c597ec702e4b61fb217da3df75a1812
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

<<<<<<< HEAD
                            Console.WriteLine("Sekunder: {0:0.##}",converter.CalculateTravelTime(speed, distance));
                            Console.WriteLine("Minuter: {0:0.##}", converter.CalculateTravelTime(speed, distance)/60);
                            Console.WriteLine("Timmar: {0:0.##}", converter.CalculateTravelTime(speed, distance)/60/60);
=======
                            Console.WriteLine("Sekunder: {0:0.##}", converter.CalculateTravelTime(speed, distance));
>>>>>>> e5c2f13b8c597ec702e4b61fb217da3df75a1812
                        }

                        // Kilometer / Timme
                        else if (choiceFormat == 2)
                        {
<<<<<<< HEAD
                            Console.WriteLine("Hur många kilometer?");
                            distance = float.Parse(Console.ReadLine());
                            Console.WriteLine("Hur många kilometer per timme?");
                            speed = float.Parse(Console.ReadLine());

                            Console.WriteLine("Svar: {0:0.0#} timmar", converter.CalculateTravelTime(speed, distance));
=======
                            Console.WriteLine("");
>>>>>>> e5c2f13b8c597ec702e4b61fb217da3df75a1812
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
