using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter.source.Interfaces;

namespace TemperatureConverter.source.Factories
{
    class Kelvin : Temperature
    {
        public override double Convert(double temperature, TemperatureUnit toUnit)
        {
            switch (toUnit)
            {
                case TemperatureUnit.Celsius:
                case TemperatureUnit.C:
                    return temperature - 273.15;
                case TemperatureUnit.Fahrenheit:
                case TemperatureUnit.F:
                    return temperature * 9 / 5 - 459.67;
                case TemperatureUnit.Kelvin:
                case TemperatureUnit.K:
                    return temperature;
                default:
                    return temperature;
            }
        }
    }
}
