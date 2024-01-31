namespace BookFilter.Backend.Domain.Model
{
    public class BookPublicationYearFilter : IFilter<Book>
    {
        public int MinYear { private set; get; }

        public BookPublicationYearFilter(int minYear)
        {
            MinYear = minYear;
        }

        public bool Filter(Book book)
        {
            return book.PublicationYear >= MinYear;
        }
    }
}
