using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TemperatureAdapter : ITemperatureService
    {
        private readonly FahrenheitSensor _sensor;

        public TemperatureAdapter(FahrenheitSensor sensor)
        {
            _sensor = sensor;
        }

        public double GetTemperatureCelsius()
        {
            double fahrenheit = _sensor.GetTemperatureFahrenheit();
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
