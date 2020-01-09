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

        // CalcAmps, CalcResist, CalcVolt
        // CalcDiameter, CalcRadius
        // CalcTravelTime, CalcTravelDistance, CalcSpeed
        // CalcFahrenheit, CalcCelsius
        // CalcHours, CalcMinutes
        // CalcLiter, CalcGallon

        public float CalculateAmps(float voltage, float res)
        {
            float amp = voltage / res;
            return amp;
        }

        public float CalculateResistance(float voltage, float amp)
        {
            float res = voltage / amp;
            return res;
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
            float time = distance / speed;
            return time;
        }
        public float CalculateTraveledDistance(float speed, float time)
        {
            float distance = speed * time;
            return distance;
        }
        public float CalculateSpeed(float time, float distance)
        {
            float speed = distance / time;
            return speed;
        }

        public float CalculateVoltage(float res, float amp)
        {
            float voltage = amp * res;
            return voltage;
        }
        
        public float ConvertCelciusToFahrenheit(float celcius)
        {
            float fahrenheit;
            float celsius = 36;
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
            return fahrenheit;
        }

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {
            float celsius;

         fahrenheit = 97;
         Console.WriteLine("Fahrenheit: " + fahrenheit);

         celsius = (fahrenheit - 32) * 5 / 9;

         Console.WriteLine("Celsius: " + celsius);
         Console.ReadLine();
         return celsius;
        }

        public float ConvertFromGallonToLiter(float gallon)
        {
            float liter = 0.26f * gallon;
            return liter;
        }

        public float ConvertFromLiterToGallon(float liter)
        {
            
            float gallon = 3.78f * liter;
            return gallon;
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