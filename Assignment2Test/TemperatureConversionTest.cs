using NUnit.Framework;
using Assignment2;
using System;

namespace Assignment2Test
{
    public class Tests
    {

        [Test]
        public void ConvertCelciusToFahrenheit_PositiveInteger_ReturnFahrenheit()
        {
            int value = 2;
            TemperatureConversion temperatureConversion = new TemperatureConversion(value);
            double result = temperatureConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(35.6, result);
        }


        [Test]
        public void ConvertCelciusToFahrenheit_String_ReturnFahrenheit()
        {
            String userTempInput = "abc";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertCelciusToFahrenheit(); result = temperatureConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(33.8, result);
        }

        [Test]
        public void ConvertCelciusToFahrenheit_NegativeInteger_ReturnFahrenheit()
        {
            String userTempInput = "-1";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertCelciusToFahrenheit(); result = temperatureConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(33.8, result);
        }



        [Test]
        public void ConvertCelciusToKelvin_PositiveInteger_ReturnKelvin()
        {
            int value = 2;
            TemperatureConversion temperatureConversion = new TemperatureConversion(value);
            double result = temperatureConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(275.15, result);
        }


        [Test]
        public void ConvertCelciusToKelvin_String_ReturnKelvin()
        {
            String userTempInput = "abc";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(274.15, result);
        }

        [Test]
        public void ConvertCelciusToKelvin_NegativeInteger_ReturnKelvin()
        {
            String userTempInput = "-1";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(274.15, result);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_PositiveInteger_ReturnFahrenheit()
        {
            int value = 2;
            TemperatureConversion temperatureConversion = new TemperatureConversion(value);
            double result = temperatureConversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(-456.07, result);
        }


        [Test]
        public void ConvertKelvinToFahrenheit_String_ReturnFahrenheit()
        {
            String userTempInput = "abc";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(-457.87, result);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_NegativeInteger_ReturnFahrenheit()
        {
            String userTempInput = "-1";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(-457.87, result);
        }

        [Test]
        public void ConvertKelvinToCelsius_PositiveInteger_ReturnCelsius()
        {
            int value = 2;
            TemperatureConversion temperatureConversion = new TemperatureConversion(value);
            double result = temperatureConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(-271.15, result);
        }


        [Test]
        public void ConvertKelvinToCelsius_String_ReturnCelsius()
        {
            String userTempInput = "abc";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(-272.15, result);
        }

        [Test]
        public void ConvertKelvinToCelsius_NegativeInteger_ReturnCelsius()
        {
            String userTempInput = "-1";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(-272.15, result);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_PositiveInteger_ReturnKelvin()
        {
            int value = 2;
            TemperatureConversion temperatureConversion = new TemperatureConversion(value);
            double result = temperatureConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(256.483, result);
        }


        [Test]
        public void ConvertFahrenheitToKelvin_String_ReturnKelvin()
        {
            String userTempInput = "abc";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(255.928, result);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_NegativeInteger_ReturnKelvin()
        {
            String userTempInput = "-1";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(255.928, result);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_PositiveInteger_ReturnCelsius()
        {
            int value = 2;
            TemperatureConversion temperatureConversion = new TemperatureConversion(value);
            double result = temperatureConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(-16.667, result);
        }


        [Test]
        public void ConvertFahrenheitToCelsius_String_ReturnCelsius()
        {
            String userTempInput = "abc";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(-17.222, result);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_NegativeInteger_ReturnCelsius()
        {
            string userTempInput = "-1";
            int value;
            double result;
            TemperatureConversion temperatureConversion;
            if (Program.IsTemperatureInputValid(userTempInput, out value))
            {
                temperatureConversion = new TemperatureConversion(value);
            }
            else
            {
                temperatureConversion = new TemperatureConversion();
            }
            result = temperatureConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(-17.222, result);
        }
    }
}