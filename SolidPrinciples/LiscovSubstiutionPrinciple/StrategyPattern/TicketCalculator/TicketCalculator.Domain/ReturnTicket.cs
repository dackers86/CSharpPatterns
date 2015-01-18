using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator.Domain
{
    public class ReturnTicket : ITicketStrategy
    {
        public double CalculateBasePrice()
        {
            return 16.00;
        }
    }
}
