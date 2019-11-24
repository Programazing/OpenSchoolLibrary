namespace OpenSchoolLibrary.Common.Models
{
    public interface IBook
    {
        int BookId { get; set; }
        string Title { get; set; }
        string SubTitle { get; set; }
        string Author { get; set; }
        int GenreID { get; set; }
        int DeweyID { get; set; }
        int ISBN { get; set; }

        Genre Genre { get; set; }
        Dewey Dewey { get; set; }
    }
}