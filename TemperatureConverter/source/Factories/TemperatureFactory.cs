using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter.source.Interfaces;

namespace TemperatureConverter.source.Factories
{
    class TemperatureFactory
    {
        public ITemperature GetTemperatureInstance(TemperatureUnit unit)
        {
            switch (unit)
            {
                case TemperatureUnit.Celsius:
                case TemperatureUnit.C:
                    return new Celsius();
                case TemperatureUnit.Fahrenheit:
                case TemperatureUnit.F:
                    return new Fahrenheit();
                case TemperatureUnit.Kelvin:
                case TemperatureUnit.K:
                    return new Kelvin();
                default:
                    return new Celsius();
            }
        }
    }
}
