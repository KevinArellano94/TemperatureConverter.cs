using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter.source.Interfaces;

namespace TemperatureConverter.source.Factories
{
    class Fahrenheit : Temperature
    {
        public override double Convert(double temperature, TemperatureUnit toUnit)
        {
            switch (toUnit)
            {
                case TemperatureUnit.Celsius:
                case TemperatureUnit.C:
                    return (temperature - 32) * 5 / 9;
                case TemperatureUnit.Fahrenheit:
                case TemperatureUnit.F:
                    return temperature;
                case TemperatureUnit.Kelvin:
                case TemperatureUnit.K:
                    return (temperature + 459.67) * 5 / 9;
                default:
                    return temperature;
            }
        }
    }
}
