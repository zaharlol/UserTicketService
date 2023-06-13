﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    internal class CalculatorTests
    {
        [TestFixture]
        public class CalculatorTest
        {
            [Test]
            public void AddAlwaysReturnsExpectedValue()
            {
                var calculatorTest = new Calculator();
                Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
            }
        }

        [TestFixture]
        public class TicketPriceTests
        {
            [Test]
            public void TicketPriceMustReturnNotNullableTicket()
            {
                var mockTicketService = new Mock<ITicketService>();
                mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
                mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
                mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

                var ticketPriceTest = new TicketPrice(mockTicketService.Object);
                Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
            }
        }
    }
}

