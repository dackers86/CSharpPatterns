using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator.Domain
{
    public class TicketCalculator
    {
        public double Calculate(bool IsSingle)
        {
            return IsSingle ? 10.00 : 16.00;
        }
    }
}
