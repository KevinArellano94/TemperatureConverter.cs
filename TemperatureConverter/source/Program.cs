using System;
using TemperatureConverter.source.Factories;
using TemperatureConverter.source.Interfaces;

namespace TemperatureConverter.source
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature: ");
            double temperature = double.Parse(s: Console.ReadLine());

            Console.WriteLine("Enter the temperature unit (Celsius, Fahrenheit, Kelvin): ");
            TemperatureUnit unit = (TemperatureUnit)Enum.Parse(typeof(TemperatureUnit), Console.ReadLine());

            Console.WriteLine("Enter the target temperature unit (Celsius, Fahrenheit, Kelvin): ");
            TemperatureUnit targetUnit = (TemperatureUnit)Enum.Parse(typeof(TemperatureUnit), Console.ReadLine());

            TemperatureFactory factory = new TemperatureFactory();
            ITemperature temperatureInstance = factory.GetTemperatureInstance(unit);

            double convertedTemperature = temperatureInstance.Convert(temperature, targetUnit);

            Console.WriteLine($"{temperature} {unit} is {convertedTemperature} {targetUnit}");

            Thread.Sleep(5000);
        }
    }
}