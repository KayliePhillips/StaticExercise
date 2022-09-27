using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static void FahrenheitToCelsius (double tempF) 
        {
            
            double tempC = (tempF - 32) *5/9;
            tempC = Math.Round(tempC, 2);
            Console.WriteLine ($"{tempF} degrees fahrenheit converts to {tempC} degrees celsius");
        }

        public static void CelsiusToFahrenheit (double tempC)
        {
            double tempF = (tempC * 1.8) + 32;
            //return tempF;
            Console.WriteLine($"{tempC} degrees celsius converts to {tempF} degrees fahrenheit");
        }

    }
}
