using System.Collections.Generic;

namespace OpenSchoolLibrary.Entities.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}