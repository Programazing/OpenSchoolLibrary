using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using OpenSchoolLibrary.Entities.Interfaces;
using OpenSchoolLibrary.Entities.Models;

namespace OpenSchoolLibrary.Data
{
    public class BookDataGateway : IBookDataGateway
    {
        public LibraryContext Context { get; private set; }

        public BookDataGateway(LibraryContext libraryContext)
        {
            Context = libraryContext;
        }

        public IQueryable<Book> GetBooks()
        {
            return Context.Books;
        }

        public bool BookIsCheckedOut(int bookId)
        {
            return Context.BookLoans
                .OrderByDescending(x => x.CheckedOutOn)
                .Where(x => x.BookID == bookId)
                .All(x => x.ReturnedOn != null);
        }

        public bool CheckOutBook(int bookId, int studentId)
        {
            var bookLoan = new BookLoan()
            {
                BookID = bookId, CheckedOutOn = DateTime.Now,
                DueOn = DateTime.Now.AddDays(30), StudentID = studentId
            };
            Context.BookLoans.Add(bookLoan);

            Context.SaveChangesAsync();

            return bookLoan.BookLoanID != 0;
        }
    }
}
