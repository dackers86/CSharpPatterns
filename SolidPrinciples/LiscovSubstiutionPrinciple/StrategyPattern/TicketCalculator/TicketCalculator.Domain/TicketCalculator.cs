using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator.Domain
{
    public class TicketCalculator
    {
        private readonly ITicketStrategy _ticketStrategy;

        public TicketCalculator(ITicketStrategy ticketStrategy)
        {
            _ticketStrategy = ticketStrategy;
        }

        public double Calculate()
        {
            return _ticketStrategy.CalculateBasePrice();
        }
    }
}
