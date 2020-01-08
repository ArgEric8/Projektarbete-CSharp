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
            throw new NotImplementedException();
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
        }

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {
            throw new NotImplementedException();
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