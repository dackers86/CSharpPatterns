using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator.Domain
{
    public class SeasonTicket : ITicketStrategy
    {
        public double CalculateBasePrice()
        {
            return 180.00;
        }
    }
}
