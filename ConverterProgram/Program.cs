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
                Console.WriteLine("3. Amp-Resist-Volt");
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
                        showAmpResistVoltMenu();
                    }

                    // Fjärde valet 
                    if (choice == 4)
                    {
                        showDiameterRadiusMenu();
                    }

                    // Femte valet 
                    if (choice == 5)
                    {
                        showFahrenheitCelsiusMenu();
                    }

                    // Sjätte valet 
                    if (choice == 6)
                    {
                        showHoursMinutesMenu();
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

            // Återvänd
            ConverterService converter = new ConverterService();
            float Gallon;
            float Liter;
            int choiceFormat = 0;
            while (choiceFormat !=5){
                  
                    Console.WriteLine("1: Gallon till liter");
                    Console.WriteLine("2: Liter till Gallon");
                    choiceFormat = Convert.ToInt32(Console.ReadLine());

                
                if (choiceFormat == 1)
                {
                    Console.WriteLine("Skriv in dina Gallons");
                     Gallon = float.Parse(Console.ReadLine());
                     Console.WriteLine("så här många liter blir det {0}",converter.ConvertFromGallonToLiter(Gallon));
                    

                }
                if (choiceFormat == 2)
                {
                    
                }

                // Avsluta
                else if (choiceFormat == 5)
                {
                    Console.WriteLine("Avsluta");
                }
            }
        }

        static void showAmpResistVoltMenu()
        {
            ConverterService converter = new ConverterService();
            float amp;
            float res;
            float voltage;
            int choiceFormat = 0;

            while (choiceFormat != 4)
            {
                Console.WriteLine("\nHuvudmeny/Amp-Resist-Volt/");
                Console.WriteLine("\n1. Amp");
                Console.WriteLine("2. Resistans");
                Console.WriteLine("3. Voltage");
                Console.WriteLine("4. Återvänd");
                Console.WriteLine("5. Avsluta");
                choiceFormat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // Calculate Amps
                if (choiceFormat == 1)
                {
                    Console.WriteLine("Ange voltage");
                    voltage = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ange resistans");
                    res = float.Parse(Console.ReadLine());
                    Console.WriteLine("Amps: {0:0.##}", converter.CalculateAmps(voltage, res));
                }

                // Calculate Resistance
                if (choiceFormat == 2)
                {
                    Console.WriteLine("Ange voltage");
                    voltage = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ange amp");
                    amp = float.Parse(Console.ReadLine());
                    Console.WriteLine("Kilometer: {0:0.##}", converter.CalculateTraveledDistance(time, speed));
                }

                // Calculate Voltage
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

        static void showDiameterRadiusMenu()
        {
            ConverterService converter = new ConverterService();
            choice = 0;
            float Diameter;
            float Radius;
            float Area;


            while(choice !=3)
             Console.WriteLine("\nHuvudmeny/Diameter och Radien av Arean/");
                Console.WriteLine("\n1. Diametern av Arean");
                Console.WriteLine("2. Radien av Arean");
                Console.WriteLine("3. Återvänd");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if(choice == 1)
                {
                    Console.WriteLine("Ange Diamtern");
                    Diameter = float.Parse(Console.ReadLine());
                    Console.WriteLine("Diametern av Arean är: {0:0.##}", converter.CalculateDiameterFromArea(Area));
                }
                if(choice )

        }

        static void showFahrenheitCelsiusMenu()
        {

        }

        static void showHoursMinutesMenu()
        {

        }
    }
}
