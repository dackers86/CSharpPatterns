using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketCalculator.Tests
{
    [TestClass]
    public class TicketCalculatorTests
    {
        [TestMethod]
        public void WhenAddingASingleTicket_ItShouldReturnTheCorrectAmount()
        {
            var ticketCalculator = new TicketCalculator.Domain.TicketCalculator();
            var result = ticketCalculator.Calculate(true);
            Assert.AreEqual(result, 10.00);
        }

        [TestMethod]
        public void WhenAddingAReturnTicket_ItShouldReturnTheCorrectAmount()
        {
            var ticketCalculator = new TicketCalculator.Domain.TicketCalculator();
            var result = ticketCalculator.Calculate(false);
            Assert.AreEqual(result, 16.00);
        }
    }
}
