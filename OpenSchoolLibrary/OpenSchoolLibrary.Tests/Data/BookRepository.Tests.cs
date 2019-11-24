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
        [Test]
        public void GetBooks_ReturnsBooks()
        {
            var sut = FakeData.GetBookRepository().GetBooks();

            sut.Count().Should().Be(3);
            sut.FirstOrDefault().Author.Should().Be("James Dewey");
        }
    }
}
