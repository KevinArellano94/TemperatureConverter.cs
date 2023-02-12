using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter.source.Interfaces
{
    interface ITemperature
    {
        double Convert(double temperature, TemperatureUnit toUnit);
    }

    abstract class Temperature : ITemperature
    {
        public abstract double Convert(double temperature, TemperatureUnit toUnit);
    }
}
