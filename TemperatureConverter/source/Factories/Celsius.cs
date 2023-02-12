using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter.source.Interfaces;

namespace TemperatureConverter.source.Factories
{
    class Celsius : Temperature
    {
        public override double Convert(double temperature, TemperatureUnit toUnit)
        {
            switch (toUnit)
            {
                case TemperatureUnit.Celsius:
                case TemperatureUnit.C:
                    return temperature;
                case TemperatureUnit.Fahrenheit:
                case TemperatureUnit.F:
                    return temperature * 9 / 5 + 32;
                case TemperatureUnit.Kelvin:
                case TemperatureUnit.K:
                    return temperature + 273.15;
                default:
                    return temperature;
            }
        }
    }
}
