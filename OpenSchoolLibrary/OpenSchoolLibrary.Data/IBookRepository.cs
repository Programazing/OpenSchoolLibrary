using OpenSchoolLibrary.Common.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OpenSchoolLibrary.Data
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks();
    }
}
