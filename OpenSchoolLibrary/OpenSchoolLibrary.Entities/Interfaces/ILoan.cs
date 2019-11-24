namespace OpenSchoolLibrary.Entities.Interfaces
{
    public interface ILoan
    {
        bool CheckOut(IBookRepository repo);
        bool CheckIn();
    }
}
