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
        public IBookDataGateway DataGateway { private get; set; }

        public Loan(IBookDataGateway dataGateway)
        {
            DataGateway = dataGateway;
        }

        public bool CheckIn(int bookId)
        {
            throw new NotImplementedException();
        }

        public bool CheckOut(int bookId, int studentId)
        {
            if(DataGateway.BookIsCheckedOut(bookId)){ return false; }

            return DataGateway.CheckOutBook(bookId, studentId);
        }
    }
}
