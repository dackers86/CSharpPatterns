using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TicketCalculator.Domain;

namespace TicketCalculator.Tests
{
    [TestClass]
    public class TicketCalculatorTests
    {
        [TestMethod]
        public void WhenAddingASingleTicket_ItShouldReturnTheCorrectAmount()
        {
            var strategy = new SingleTicket();
            var ticketCalculator = new TicketCalculator.Domain.TicketCalculator(strategy);
            var result = ticketCalculator.Calculate();
            Assert.AreEqual(result, 10.00);
        }

        [TestMethod]
        public void WhenAddingAReturnTicket_ItShouldReturnTheCorrectAmount()
        {
            var strategy = new ReturnTicket();
            var ticketCalculator = new TicketCalculator.Domain.TicketCalculator(strategy);
            var result = ticketCalculator.Calculate();
            Assert.AreEqual(result, 16.00);
        }

        [TestMethod]
        public void WhenAddingASeasonTicket_ItShouldReturnTheCorrectAmount()
        {
            var strategy = new SeasonTicket();
            var ticketCalculator = new TicketCalculator.Domain.TicketCalculator(strategy);
            var result = ticketCalculator.Calculate();
            Assert.AreEqual(result, 180.00);
        }
    }
}
