using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator.TicketStrategy
{
    public class SingleTicket : ITicketStrategy
    {
        public double CalculateBasePrice()
        {
            return 10.00;
        }
    }
}
