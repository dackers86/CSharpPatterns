using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample.Domain
{
    public class ScientificCalculator : Calculator
    {
        public double SquareRoot(int number)
        {
            return Math.Sqrt(number);
        }
    }
}
