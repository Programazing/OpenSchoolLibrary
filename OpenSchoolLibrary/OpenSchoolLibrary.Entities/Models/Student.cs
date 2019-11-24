using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSchoolLibrary.Entities.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public decimal? Fines { get; set; }
        public int? IssuedID { get; set; }
        public string Email { get; set; }

        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}
