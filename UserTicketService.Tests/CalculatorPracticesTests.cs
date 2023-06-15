using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class CalculatorPracticesTests
    {
        [Test]
        public void CalculatorPractice()
        {
            CalculatorPractices cs = new CalculatorPractices();

            Assert.That(cs.Additional(10, 2), Is.EqualTo(12));
            Assert.That(cs.Subtraction(10, 2), Is.EqualTo(8));
            Assert.That(cs.Miltiplication(10, 2), Is.EqualTo(20));
            Assert.That(cs.Division(10, 2), Is.EqualTo(5));
        }
    }
}
