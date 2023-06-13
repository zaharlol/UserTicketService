using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService.Tests
{
    public class CalculatorTests1
    {
        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator1();
            int result = calculator.Addition(50, 10, 34);
            Assert.Equal(94, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator1();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.Equal(120, result);
        }
    }
}
