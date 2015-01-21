using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator.TicketStrategy
{
    public interface ITicketStrategy
    {
        double CalculateBasePrice();
    }
}
