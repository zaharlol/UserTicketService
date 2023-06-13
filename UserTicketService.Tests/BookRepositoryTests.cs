using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public void BookRepository1() 
        {
            var nameBook = new List<Book>()
            {
                new Book()
                { Title = "Война и мир"},
                new Book()
                { Title = "Человек-невидимка"},
                new Book()
                { Title = "Анна Каренина"}
            };

            var mockBook = new Mock<IBookRepository>();

            mockBook.Setup(e => e.FindAll()).Returns(nameBook);

            Assert.Contains(mockBook.Object.FindAll(), user => user.Title == "Война и мир");
            Assert.Contains(mockBook.Object.FindAll(), user => user.Title == "Человек-невидимка");
            Assert.Contains(mockBook.Object.FindAll(), user => user.Title == "Анна Каренина");
        }
    }
}
