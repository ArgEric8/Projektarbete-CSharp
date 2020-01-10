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
            float diameter = (float)Math.Sqrt((area * 4f) / 3.14f);
            return diameter;
        }

        public float CalculateRadiusFromArea(float area)
        {
            float radius = area / 3.14f;
            return radius;
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
        
        public float ConvertCelciusToFahrenheit(float celsius)
        {
            float fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }
           
        

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {

         float celsius = (fahrenheit - 32) * 5 / 9;
         return celsius;
        }

        public float ConvertFromGallonToLiter(float gallon)
        {
            float liter = 3.78f * gallon;
            return liter;
        }

        public float ConvertFromLiterToGallon(float liter)
        {
            
            float gallon = 0.26f * liter;
            return gallon;
        }

        public float ConvertFromHoursToMinutes(float hours)
        {
            float minutes = 60 / hours;
            return minutes;
        
         }

        public float ConvertFromMinutesToHours(float minutes)
        {
            float hours = 60 * minutes;
            return hours;
            
        }
    }
}