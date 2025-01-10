using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp_converter.Models
{
    internal class Converter
    {
        public float ConvertToFar(float tempInCelsius)
        {
            return (tempInCelsius * 1.8f) + 32;
        }

        public float ConvertToCel(float tempInFahrenheit)
        {
            return (tempInFahrenheit - 32) / 1.8f;
        }
    }
}
