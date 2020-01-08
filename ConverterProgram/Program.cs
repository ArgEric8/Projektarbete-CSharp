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
                        float distance;
                        float speed;
                        Console.WriteLine("Välj enhet");
                        Console.WriteLine("1. Meter / Sekund");
                        Console.WriteLine("2. Kilometer / Timme");
                        int choiceFormat = Convert.ToInt32(Console.ReadLine());

                        // Meter / Sekund
                        if (choiceFormat == 1)
                        {
                            Console.WriteLine("Hur många meter?");
                            distance = float.Parse(Console.ReadLine());
                            Console.WriteLine("Hur många meter per sekund?");
                            speed = float.Parse(Console.ReadLine());
                            ConverterService testrun = new ConverterService();
                            testrun.CalculateTravelTime(speed, distance);
                            Console.WriteLine("Svar: {0} sekunder", 50);
                        }

                        // Kilometer / Timme
                        else if (choiceFormat == 2)
                        {
                            Console.WriteLine("Hur många kilometer?");
                            Console.WriteLine("Hur många timmar?");
                        }

                        Console.WriteLine("Mata in hastighet");
                        
                        int choiceSpeed = 0;
                        Console.WriteLine("Välj enhet");
                        Console.WriteLine("1. ");
                        Console.WriteLine("2. ");
                        Console.WriteLine("3. ");

                        // 
                        if (choiceSpeed == 1)
                        {
                            
                        }

                        // 
                        if (choiceSpeed == 2)
                        {
                            
                        }

                        // 
                        if (choiceSpeed == 3)
                        {
                            
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
    }
}
