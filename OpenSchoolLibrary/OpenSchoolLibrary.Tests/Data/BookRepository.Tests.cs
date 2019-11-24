using NUnit.Framework;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using OpenSchoolLibrary.Entities.Interfaces;
using OpenSchoolLibrary.Entities.Models;
using System.Linq;

namespace OpenSchoolLibrary.Tests.Data
{
    [TestFixture]
    public class BookRepository
    {
        private IEnumerable<Book> Books { get; set; }

        public BookRepository()
        {
            Books = FakeData.GetBookList();
        }

        [Test]
        public void GetBooks_ReturnsBooks()
        {
            var mock = new Mock<IBookRepository>();
            mock.Setup(b => b.GetBooks()).Returns(() => Books);

            var sut = mock.Object.GetBooks();

            sut.Count().Should().Be(3);
            sut.FirstOrDefault().Author.Should().Be("James Dewey");
        }

        
    }
}
