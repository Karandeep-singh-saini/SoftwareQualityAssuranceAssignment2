using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class TemperatureConversion
    {
        private int value;

        public TemperatureConversion()
        {
            this.value = 1;
        } 

        public TemperatureConversion(int value)
        {
            this.value = value;
        }

        public double ConvertCelciusToFahrenheit() {  
            return Math.Round(((((double)value*9)/5) +32),2); 
        }
        public double ConvertCelciusToKelvin() {
            return Math.Round(value + 273.15,2); 
        }
        public double ConvertKelvinToFahrenheit() { 
            return Math.Round((((double)(value - 273.15)* 9) / 5) + 32 , 2);
        }
        public double ConvertKelvinToCelsius() {
            return Math.Round((value-273.15),2); 
        }
        public double ConvertFahrenheitToKelvin() { 
            return Math.Round(((double)((value - 32) * 5) / 9) + 273.15,3); 
        }
        public double ConvertFahrenheitToCelsius() {
            return Math.Round((((double)(value - 32) * 5) / 9),3);
        }
    }
}
