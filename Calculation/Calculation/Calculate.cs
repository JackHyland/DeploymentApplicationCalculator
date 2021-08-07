using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Calculate
    {
        public double Add(string value1, string value2)
        {
            return Convert.ToDouble(value1) + Convert.ToDouble(value2);
        }

        public double Subtract(string value1, string value2)
        {
            return Convert.ToDouble(value1) - Convert.ToDouble(value2);
        }

        public double Multiply(string value1, string value2)
        {
            return Convert.ToDouble(value1) * Convert.ToDouble(value2);
        }

        public double Divide(string value1, string value2)
        {
            return Convert.ToDouble(value1) / Convert.ToDouble(value2);
        }
    }
}
