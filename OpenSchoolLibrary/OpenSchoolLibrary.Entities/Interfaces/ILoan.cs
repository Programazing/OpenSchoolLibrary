using OpenSchoolLibrary.Entities.Models;

namespace OpenSchoolLibrary.Entities.Interfaces
{
    public interface ILoan
    {
        IBookRepository Repository { set; }

        bool CheckOut(int bookId, int studentId);
        bool CheckIn(int bookId);
    }
}
