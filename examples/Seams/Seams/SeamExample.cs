using System;
using System.Collections.Generic;
using System.Text;

namespace Seams
{
    /// <summary>
    /// Let's say you would have this class under test. Would it be easy to change the behavior of the IsAllowedOutside
    /// function, without changing any other code than your test?
    /// </summary>
    class SeamExample
    {
        private readonly TemperatureSensor temperatureSensor;

        public SeamExample()
        {
            temperatureSensor = new TemperatureSensor();
        }

        public bool IsAllowedOutside()
        {
            if (temperatureSensor.ReadTemperature() > 38.0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
