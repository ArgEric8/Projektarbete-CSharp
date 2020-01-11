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
                Console.WriteLine("\n1. Tid, distans, hastighet");
                Console.WriteLine("2. Liter, gallon");
                Console.WriteLine("3. Ampere, resistans, volt");
                Console.WriteLine("4. Diameter, radius");
                Console.WriteLine("5. Fahrenheit, celsius");
                Console.WriteLine("6. Hours, minutes");
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
                    if (choice >= 8 || choice == 0)
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

            while (choiceFormat != 5)
            {
                Console.WriteLine("\nHuvudmeny/Tid-Distans-Hastighet/");
                Console.WriteLine("\n1. Tid");
                Console.WriteLine("2. Distans");
                Console.WriteLine("3. Hastighet");
                Console.WriteLine("4. Återvänd");
                Console.WriteLine("5. Avsluta");
                Console.WriteLine();
                
                if (int.TryParse(Console.ReadLine(), out choiceFormat))
                {
                    // Travel Time
                    if (choiceFormat == 1)
                    {
                        Console.WriteLine("Ange kilometer");
                        distance = ifLetterInput();
                        
                        Console.WriteLine("Ange km/h");
                        speed = ifLetterInput();
                        
                        Console.WriteLine("Timmar: {0:0.##}", converter.CalculateTravelTime(speed, distance));
                    }

                    // Travel Distance
                    if (choiceFormat == 2)
                    {
                        Console.WriteLine("Ange timmar");
                        time = ifLetterInput();
                        Console.WriteLine("Ange km/h");
                        speed = ifLetterInput();
                        Console.WriteLine("Kilometer: {0:0.##}", converter.CalculateTraveledDistance(time, speed));
                    }

                    // Travel Speed
                    if (choiceFormat == 3)
                    {
                        Console.WriteLine("Distans");
                        distance = ifLetterInput();
                        Console.WriteLine("Ange timmar");
                        time = ifLetterInput();
                        Console.WriteLine("km/h: {0:0.##}", converter.CalculateSpeed(time, distance));
                    }

                    // Återvänd
                    if (choiceFormat == 4){break;}

                    // Avsluta
                    if (choiceFormat == 5)
                    {
                        Console.WriteLine("Avslutar...");
                        Environment.Exit(0);
                    }
                }
                else {Console.WriteLine("Endast siffror godtas");}
            }
        }

        static void showLiterGallonMenu()
        {
            ConverterService converter = new ConverterService();
            float Gallon;
            float Liter;
            int choiceFormat = 0;
            while (choiceFormat !=5)
            {
                    Console.WriteLine("\nHuvudmeny/2:Gallons-Liter/");
                    Console.WriteLine("1: Gallon till liter");
                    Console.WriteLine("2: Liter till Gallon");
                    Console.WriteLine("3: Gå tillbaka");
                    Console.WriteLine("4: Avsluta");

                if (int.TryParse(Console.ReadLine(), out choiceFormat))
                {
                    if (choiceFormat == 1)
                    {
                        Console.WriteLine("Skriv in dina Gallons");
                        Gallon = ifLetterInput();
                        Console.WriteLine("så här många liter blir det {0}",converter.ConvertFromGallonToLiter(Gallon));
                        

                    }
                    if (choiceFormat == 2)
                    {
                        Console.WriteLine("skriv in dina liter");
                        Liter = ifLetterInput();
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
                else {Console.WriteLine("Endast siffror godtas, försök igen");}
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
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choiceFormat))
                {
                    // Calculate Amps
                    if (choiceFormat == 1)
                    {
                        Console.WriteLine("Ange voltage");
                        voltage = ifLetterInput();
                        Console.WriteLine("Ange resistans");
                        res = ifLetterInput();
                        Console.WriteLine("Amps: {0:0.##}", converter.CalculateAmps(voltage, res));
                    }

                    // Calculate Resistance
                    if (choiceFormat == 2)
                    {
                        Console.WriteLine("Ange voltage");
                        voltage = ifLetterInput();
                        Console.WriteLine("Ange amp");
                        amp = ifLetterInput();
                        Console.WriteLine("Resistans: {0:0.##}", converter.CalculateTraveledDistance(voltage, amp));
                    }

                    // Calculate Voltage
                    if (choiceFormat == 3)
                    {
                        Console.WriteLine("Ange amp");
                        amp = ifLetterInput();
                        Console.WriteLine("Ange resistans");
                        res = ifLetterInput();
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
                else {Console.WriteLine("Endast siffror godtas, försök igen");}
            }
        }

        static void showDiameterRadiusMenu()
        {
            ConverterService converter = new ConverterService();
            int choice = 0;
            float Area;

            while(choice !=4)
            {
             Console.WriteLine("\nHuvudmeny/Diameter och Radien av Arean/");
                Console.WriteLine("\n1. Diametern av Arean");
                Console.WriteLine("2. Radien av Arean");
                Console.WriteLine("3. Återvänd");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if(choice == 1)
                    {
                        Console.WriteLine("Ange Arean");
                        Area = ifLetterInput();
                        Console.WriteLine("Diametern av Arean är: {0:0.##}", converter.CalculateDiameterFromArea(Area));
                    }
                    if(choice == 2)
                    {
                        Console.WriteLine("Ange Arean");
                        Area = ifLetterInput();
                        Console.WriteLine("Radien av Arean är: {0:0.##}", converter.CalculateRadiusFromArea(Area));
                    }
                    if(choice == 3)
                    {
                        break;
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Avslutar...");
                        Environment.Exit(0);
                    }
                }
                else {Console.WriteLine("Endast siffror godtas, försök igen");}
            }

        }

        static void showFahrenheitCelsiusMenu()
        {
            ConverterService converter = new ConverterService();
            int choice = 0;
            float fahrenheit;
            float celsius;


            while(choice !=4)
            {
                Console.WriteLine("\nHuvudmeny/Fahrenheit och Celsius/");
                Console.WriteLine("\n1. Konventera Fahrenheit till Celsius");
                Console.WriteLine("2. Konventera Celsius till Fahrenheit");
                Console.WriteLine("3. Återvänd");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if(choice == 1)
                    {
                        Console.WriteLine("Ange Fahrenheit");
                        fahrenheit = ifLetterInput();
                        Console.WriteLine("Celsius: {0:0.##}", converter.ConvertFahrenheitToCelcius(fahrenheit));
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("Ange Celsius");
                        celsius = ifLetterInput();
                        Console.WriteLine("Fahrenheit: {0:0.##}", converter.ConvertCelciusToFahrenheit(celsius));
                    }
                    if (choice == 3)
                    {
                        break;
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Avslutar...");
                        Environment.Exit(0);
                    }
                }
                else {Console.WriteLine("Endast siffror godtas, försök igen");}
            }

        }

        static void showHoursMinutesMenu()
        {
            ConverterService converter = new ConverterService();
            int choice = 0;
            float hours;
            float minutes;


            while(choice !=4)
            {
                Console.WriteLine("\nHuvudmeny/Timmar och Minuter/");
                Console.WriteLine("\n1. Timmar till minuter");
                Console.WriteLine("2. Minuter till timmar");
                Console.WriteLine("3. Återvänd");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if(choice == 1)
                    {
                        Console.WriteLine("Ange Timmar");
                        hours = ifLetterInput();
                        Console.WriteLine("I minuter: {0:##}", converter.ConvertFromHoursToMinutes(hours));

                    }
                    if(choice == 2)
                    {
                        Console.WriteLine("Ange Minuter");
                        minutes = ifLetterInput();
                        Console.WriteLine("I timmar: {0.##}", converter.ConvertFromMinutesToHours(minutes));
                    }
                    // Återvänd
                    if (choice ==3)
                    {
                        break;
                    }
                    // Avsluta
                    if (choice ==4)
                    {
                        Console.WriteLine("Avslutar...");
                        Environment.Exit(0);
                    }
                }
                else {Console.WriteLine("Endast siffror godtas, försök igen");}
            }
        }

        static float ifLetterInput()
        {
            float number = 0;
            bool letter = true;
            
            while (letter == true)
            {
                letter = float.TryParse(Console.ReadLine(), out number);

                // if user input letter
                if (letter == false)
                {
                    Console.WriteLine("Endast siffror godtas, försök igen");
                    letter = true;
                    break;
                }
                else {letter = false;}
            }
            return number;
        }
    }
}
