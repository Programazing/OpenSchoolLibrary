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
        private IBookRepository Repository { get; set; }

        public BookRepository()
        {
            Repository = FakeData.GetBookRepository();
        }

        [Test]
        public void GetBooks_ReturnsBooks()
        {
            var sut = Repository.GetBooks();

            sut.Count().Should().Be(3);
            sut.FirstOrDefault().Author.Should().Be("James Dewey");
        }

        [Test]
        public void KnowsIf_BookIsCheckedOut()
        {
            //var book = FakeData.GetBookList().Where(x => x.BookId == 1).FirstOrDefault();

            //var sut = Repository.BookIsCheckedOut(book.BookId);

            //sut.Should().BeTrue();
            
        }
    }
}
