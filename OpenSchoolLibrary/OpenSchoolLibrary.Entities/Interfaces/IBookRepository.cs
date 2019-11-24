using OpenSchoolLibrary.Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OpenSchoolLibrary.Entities.Interfaces
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks();
    }
}
