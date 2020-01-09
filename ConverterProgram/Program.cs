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
                        showTimeDistanceSpeedMenu();
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

        public void showTimeDistanceSpeedMenu()
        {
            ConverterService converter = new ConverterService();

            float distance;
            float speed;
            Console.WriteLine("\nVälj");
            Console.WriteLine("1. Km / h");
            Console.WriteLine("2. Distans??");
            Console.WriteLine("3. Tid??");
            Console.WriteLine("4. Återvänd");
            Console.WriteLine("5. Avsluta");
            int choiceFormat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // km / h
            if (choiceFormat == 1)
            {
                Console.WriteLine("Hur många meter?");
                distance = float.Parse(Console.ReadLine());
                Console.WriteLine("Hur många meter per sekund?");
                speed = float.Parse(Console.ReadLine());

                Console.WriteLine("Sekunder: {0:0.##}", converter.CalculateTravelTime(speed, distance));
            }

            // distans == ????
            if (choiceFormat == 2)
            {
                
            }

            // tid ?????????
            if (choiceFormat == 3)
            {
                
            }

            // Återvänd
            if (choiceFormat == 4)
            {
                Console.WriteLine("Återvänd");
            }

            // Avsluta
            else if (choiceFormat == 5)
            {
                Console.WriteLine("Avsluta");
            }
        }
    }
}
