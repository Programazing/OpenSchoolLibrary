using OpenSchoolLibrary.Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OpenSchoolLibrary.Entities.Interfaces
{
    public interface IBookDataGateway
    {
        IQueryable<Book> GetBooks();

        bool BookIsCheckedOut(int bookId);
        bool CheckOutBook(int bookId, int studentId);
    }
}
