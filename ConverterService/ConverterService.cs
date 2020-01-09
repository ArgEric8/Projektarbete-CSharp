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
            float area = pi*d^2/4;
        }

        public float CalculateRadiusFromArea(float area)
        {
            float area = pi*r^2;
        }
        public float CalculateTravelTime(float speed, float distance)
        {
            float time = distance / speed;
            return time;
        }
        public float CalculateTraveledDistance(float speed, float time) {
            throw new NotFiniteNumberException();
        }
        public float CalculateSpeed(float time, float distance) {
            throw new NotFiniteNumberException();
        }

        public float CalculateVoltage(float res, float amp)
        {
            float voltage = amp * res;
            return voltage;
        }
        
        public float ConvertCelciusToFahrenheit(float celcius)
        {
            
            float fahrenheit = (celsius * 9) / 5 + 32;
        }
        

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {
            float celsius = (fahrenheit - 32) * 5 / 9;

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
            float minutes = 60 / hours;
        
         }

        public float ConvertFromMinutesToHours(float minutes)
        {
            float hours = 60 * minutes;
            
        }
    }
}