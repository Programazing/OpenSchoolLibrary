using NUnit.Framework;
using Moq;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using OpenSchoolLibrary.Entities.Interfaces;
using OpenSchoolLibrary.Entities.Models;
using System.Linq;
using OpenSchoolLibrary.Entities;
using OpenSchoolLibrary.Common;

namespace OpenSchoolLibrary.Tests.Data
{
    [TestFixture]
    public class Loans
    {
        public ILoan Loan { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public Loans()
        {
            Loan = FakeData.GetLoan();
            Students = FakeData.GetStudents();
            Books = FakeData.GetBookList();
        }

        [Test]
        public void Book_WasSuccessfully_CheckedOut()
        {
            var book = Books.Where(x => x.BookId == 2).FirstOrDefault();
            var student = Students.Where(x => x.StudentID == 0758).FirstOrDefault();

            var sut = Loan.CheckOut(book.BookId, student.StudentID);

            sut.Should().BeTrue();
        }

        [Test]
        public void Book_WasNotSuccessfully_CheckedOut()
        {
            var book = Books.Where(x => x.BookId == 1).FirstOrDefault();
            var student = Students.Where(x => x.StudentID == 0758).FirstOrDefault();

            var sut = Loan.CheckOut(book.BookId, student.StudentID);

            sut.Should().BeFalse();
        }
    }
}
