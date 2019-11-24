using NUnit.Framework;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using OpenSchoolLibrary.Data;
using OpenSchoolLibrary.Common.Models;
using System.Linq;

namespace OpenSchoolLibrary.Tests.Data
{
    [TestFixture]
    public class BookRepository
    {
        private IEnumerable<Book> BookList { get; set; }

        public BookRepository()
        {
            BookList = PopulateBookList();
        }

        [Test]
        public void GetBooks_ReturnsBooks()
        {
            var mock = new Mock<IBookRepository>();
            mock.Setup(b => b.GetBooks()).Returns(() => BookList);

            var sut = mock.Object.GetBooks();

            sut.Count().Should().Be(3);
            sut.FirstOrDefault().Author.Should().Be("James Dewey");

        }

        private IEnumerable<Book> PopulateBookList()
        {
            return new List<Book>()
            {
                { new Book{ Author="James Dewey", BookId=1, Dewey=new Dewey{ }, DeweyID=1, Genre=new Genre{ }, GenreID=1, ISBN=1, SubTitle="", Title="" } },
                { new Book{ Author="", BookId=2, Dewey=new Dewey{ }, DeweyID=2, Genre=new Genre{ }, GenreID=2, ISBN=2, SubTitle="", Title="" } },
                { new Book{ Author="", BookId=3, Dewey=new Dewey{ }, DeweyID=3, Genre=new Genre{ }, GenreID=3, ISBN=3, SubTitle="", Title="" } }
            };
        }
    }
}
