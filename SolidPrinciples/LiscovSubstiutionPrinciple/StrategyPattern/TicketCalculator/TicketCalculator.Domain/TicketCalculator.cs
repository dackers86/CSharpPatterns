using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator.Domain
{
    public class TicketCalculator
    {
        public double Calculate(string type)
        {
            if(type == "Single")
            {
                return 10.00;
            }
            else if (type == "Return")
            {
                return 16.00;
            }
            else
            {
                return 180.00;
            }
        }
    }
}
