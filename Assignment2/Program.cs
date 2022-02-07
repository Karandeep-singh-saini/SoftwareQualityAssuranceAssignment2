using System;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature convertor");

            string temperatureInput;
            int value;
            do
            {
                Console.WriteLine("Please enter the temperature number");
                temperatureInput = Console.ReadLine();
            } while (!IsTemperatureInputValid(temperatureInput, out value));

            TemperatureConversion conversion = new TemperatureConversion(value);
            string userInput = "";
            int option = 0;
            do
            {
                do
                {
                    Console.WriteLine("Please enter the option");
                    Console.WriteLine("1.Convert Celsius to Fahrenheit");
                    Console.WriteLine("2.Convert Celsius to Kelvin");
                    Console.WriteLine("3.Convert Fahrenheit to Celsius");
                    Console.WriteLine("4.Convert Fahrenheit to Kelvin");
                    Console.WriteLine("5.Convert Kelvin to Celsius");
                    Console.WriteLine("6.Convert Kelvin to Fahrenheit");
                    Console.WriteLine("7.Exit");
                    userInput = Console.ReadLine();
                } while (!(int.TryParse(userInput, out option) && option < 8 && option > 0));

                switch (option)
                {
                    case 1:
                        Console.WriteLine(conversion.ConvertCelciusToFahrenheit() + " Fahrenheit");
                        break;
                    case 2:
                        Console.WriteLine(conversion.ConvertCelciusToKelvin() + " Kelvin");
                        break;
                    case 3:
                        Console.WriteLine(conversion.ConvertFahrenheitToCelsius() + " Celsius");
                        break;
                    case 4:
                        Console.WriteLine(conversion.ConvertFahrenheitToKelvin() + " Kelvin");
                        break;
                    case 5:
                        Console.WriteLine(conversion.ConvertKelvinToCelsius() + " Celsius");
                        break;
                    case 6:
                        Console.WriteLine(conversion.ConvertKelvinToFahrenheit() + " Fahrenheit");
                        break;

                    default: break;

                }


            } while (option != 7);

            Console.ReadKey();
        }
        public static bool IsTemperatureInputValid(String input, out int value)
        {
            if (int.TryParse(input, out value) && value > 0)
            {
                return true;
            }

            Console.WriteLine("Invalid Input");
            return false;

        }
    }
}
