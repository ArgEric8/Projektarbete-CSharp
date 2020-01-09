using System;

namespace Service
{
    public class ConverterService : IConverterService
    {
        public ConverterService()
        {
        }

        // 1 gallon = 3.78541178 liters     
        // 1 liter = 0.264172052 gallons   
        //Fahrenheit = Celsius * 9/5 + 32
        //Time = distance / speed
        //Ohm law says: amp = voltage / resistance
        //Radius = square root (area / pi)
        //Diameter = radius * 2

        public float CalculateAmps(float voltage, float resistance)
        {
            throw new NotImplementedException();
        }

        public float CalculateResistance(float voltage, float amps)
        {
            throw new NotImplementedException();
        }

        public float CalculateDiameterFromArea(float area)
        {
            throw new NotImplementedException();
        }

        public float CalculateRadiusFromArea(float area)
        {
            throw new NotImplementedException();
        }
        public float CalculateTravelTime(float speed, float distance)
        {
<<<<<<< HEAD
            float time = distance / speed;
            return time;
=======
            throw new NotImplementedException();
>>>>>>> e5c2f13b8c597ec702e4b61fb217da3df75a1812
        }
        public float CalculateTraveledDistance(float speed, float time) {
            throw new NotFiniteNumberException();
        }
        public float CalculateSpeed(float time, float distance) {
            throw new NotFiniteNumberException();
        }

        public float CalculateVoltage(float res, float amp)
        {
            throw new NotImplementedException();
        }
        
        public float ConvertCelciusToFahrenheit(float celcius)
        {
            throw new NotImplementedException();

            double fahrenheit;

         double celsius = 36;
         Console.WriteLine("Celsius: " + celsius);

         fahrenheit = (celsius * 9) / 5 + 32;
         Console.WriteLine("Fahrenheit: " + fahrenheit);

         Console.ReadLine();
        }

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {
            throw new NotImplementedException();

            double celsius;

         double fahrenheit = 97;
         Console.WriteLine("Fahrenheit: " + fahrenheit);

         celsius = (fahrenheit - 32) * 5 / 9;

         Console.WriteLine("Celsius: " + celsius);
         Console.ReadLine();
        }

        public float ConvertFromGallonToLiter(float gallon)
        {
            throw new NotImplementedException();
        }

        public float ConvertFromLiterToGallon(float liter)
        {
            throw new NotImplementedException();
        }

        public float ConvertFromHoursToMinutes(float hours)
        {
            throw new NotImplementedException();
        }

        public float ConvertFromMinutesToHours(float minutes)
        {
            throw new NotImplementedException();
        }
    }
}