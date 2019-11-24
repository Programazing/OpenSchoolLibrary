using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSchoolLibrary.Common.Models
{
    public class Book : IBook
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public int GenreID { get; set; }
        public int DeweyID { get; set; }
        public int ISBN { get; set; }

        public Genre Genre { get; set; }
        public Dewey Dewey { get; set; }
    }
}
