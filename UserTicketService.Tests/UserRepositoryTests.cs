using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    [TestFixture]
    internal class UserRepositoryTests
    {
        [Test]
        public void UserRepositoryTests1() 
        {
            var name = new List<User>()
            {
                new User()
                {Name = "Антон"},
                new User()
                {Name = "Иван"},
                new User()
                {Name = "Алексей"},
            };

            var mockUR = new Mock<IUserRepository>();

            mockUR.Setup(e => e.FindAll()).Returns(name);

            Assert.That(mockUR.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mockUR.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mockUR.Object.FindAll().Any(user => user.Name == "Алексей"));

        }
    }
}
