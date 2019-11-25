using OpenSchoolLibrary.Data;
using OpenSchoolLibrary.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSchoolLibrary.Common
{
    public class Loan : ILoan
    {
        public IBookRepository Repository { private get; set; }

        public Loan(IBookRepository bookRepository)
        {
            Repository = bookRepository;
        }

        public bool CheckIn(int bookId)
        {
            throw new NotImplementedException();
        }

        public bool CheckOut(int bookId, int studentId)
        {
            if(Repository.BookIsCheckedOut(bookId)){ return false; }

            return Repository.CheckOutBook(bookId, studentId);
        }
    }
}
