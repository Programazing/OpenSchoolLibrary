using System;
using System.Collections.Generic;
using System.Text;
using OpenSchoolLibrary.Entities.Interfaces;
using OpenSchoolLibrary.Entities.Models;

namespace OpenSchoolLibrary.Data
{
    public class BookRepository : IBookRepository
    {


        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }
    }
}
