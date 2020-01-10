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
            bool letter = true;
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
                    while (letter == true)
                    {
                        Console.WriteLine("Ange kilometer");
                        letter = float.TryParse(Console.ReadLine(), out distance);
                        if (letter == false)
                        {
                            Console.WriteLine("Bokstäver tillåts inte");
                        }
                        Console.WriteLine("Ange km/h");
                        letter = float.TryParse(Console.ReadLine(), out speed);
                        if (letter == false)
                        {
                            Console.WriteLine("Bokstäver tillåts inte");
                        }
                        else {break;}
                        Console.WriteLine("Timmar: {0:0.##}", converter.CalculateTravelTime(speed, distance));
                        letter = false;
                    }
                }

                // Travel Distance
                if (choiceFormat == 2)
                {
                    Console.WriteLine("Ange timmar");
                    float.TryParse(Console.ReadLine(), out time);
                    Console.WriteLine("Ange km/h");
                    float.TryParse(Console.ReadLine(), out speed);
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
                  
                   Console.WriteLine("\nHuvudmeny/2:Gallons-Liter/");
                    Console.WriteLine("1: Gallon till liter");
                    Console.WriteLine("2: Liter till Gallon");
                    Console.WriteLine("3: Gå tillbaka");
                    Console.WriteLine("4: Avsluta");
                    choiceFormat = Convert.ToInt32(Console.ReadLine());

                
                if (choiceFormat == 1)
                {
                    Console.WriteLine("Skriv in dina Gallons");
                     Gallon = float.Parse(Console.ReadLine());
                     Console.WriteLine("så här många liter blir det {0}",converter.ConvertFromGallonToLiter(Gallon));
                    

                }
                if (choiceFormat == 2)
                {
                    Console.WriteLine("skriv in dina liter");
                    Liter = float.Parse(Console.ReadLine());
                    Console.WriteLine("så här många gallons blir det {0}",converter.ConvertFromLiterToGallon(Liter));

                }

                if (choiceFormat == 3) 
                {   
                    break;
                }

                // Avsluta
                if (choiceFormat == 4)
                {
                    Console.WriteLine("Avsluta");
                    Environment.Exit(0);
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
                    Console.WriteLine("Resistans: {0:0.##}", converter.CalculateTraveledDistance(voltage, amp));
                }

                // Calculate Voltage
                if (choiceFormat == 3)
                {
                    Console.WriteLine("Ange amp");
                    amp = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ange resistans");
                    res = float.Parse(Console.ReadLine());
                    Console.WriteLine("Voltage: {0:0.##}", converter.CalculateSpeed(res, amp));
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
            int choice = 0;
            float Area;


            while(choice !=3)
            {
             Console.WriteLine("\nHuvudmeny/Diameter och Radien av Arean/");
                Console.WriteLine("\n1. Diametern av Arean");
                Console.WriteLine("2. Radien av Arean");
                Console.WriteLine("3. Återvänd");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if(choice == 1)
                {
                    Console.WriteLine("Ange Arean");
                    Area = float.Parse(Console.ReadLine());
                    Console.WriteLine("Diametern av Arean är: {0:0.##}", converter.CalculateDiameterFromArea(Area));
                }
                if(choice == 2)
                {
                    Console.WriteLine("Ange Arean");
                    Area = float.Parse(Console.ReadLine());
                    Console.WriteLine("Radien av Arean är: {0:0.##}", converter.CalculateRadiusFromArea(Area));
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Avslutar...");
                    Environment.Exit(0);
                }
            }

        }

        static void showFahrenheitCelsiusMenu()
        {
            ConverterService converter = new ConverterService();
            int choice = 0;
            float fahrenheit;
            float celsius;


            while(choice !=3)
            {
             Console.WriteLine("\nHuvudmeny/Fahrenheit och Celsius /");
                Console.WriteLine("\n1. Konventera Fahrenheit till Celsius");
                Console.WriteLine("2. Konventera Celsius till Fahrenheit");
                Console.WriteLine("3. Återvänd");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if(choice == 1)
                {
                    Console.WriteLine("Ange Fahrenheit");
                    fahrenheit = float.Parse(Console.ReadLine());
                    Console.WriteLine("Celsius: {0:0.##}", converter.ConvertFahrenheitToCelcius(fahrenheit));
                }
                if (choice == 2)
                {
                    Console.WriteLine("Ange Celsius");
                    celsius = float.Parse(Console.ReadLine());
                    Console.WriteLine("Fahrenheit: {0:0.##}", converter.ConvertCelciusToFahrenheit(celsius));
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Avslutar...");
                    Environment.Exit(0);
                }
            }

        }

        static void showHoursMinutesMenu()
        {
            ConverterService converter = new ConverterService();
            int choice = 0;
            float hours;
            float minutes;


            while(choice !=3)
             Console.WriteLine("\nHuvudmeny/Timmar och Minuter/");
                Console.WriteLine("\n1. Timmar till minuter");
                Console.WriteLine("2. Minuter till timmar");
                Console.WriteLine("3. Återvänd");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                if(choice == 1)
                {
                    Console.WriteLine("Ange Timmar");
                    hours = float.Parse(Console.ReadLine());
                    Console.WriteLine("I minuter: {0:##}", converter.ConvertFromHoursToMinutes(hours));

                }
                if(choice == 2)
                {
                    Console.WriteLine("Ange Minuter");
                    minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("I timmar: {0.##}", converter.ConvertFromMinutesToHours(minutes));
                }


        }
    }
}
