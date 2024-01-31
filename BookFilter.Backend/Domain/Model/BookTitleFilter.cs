namespace BookFilter.Backend.Domain.Model
{
    public class BookTitleFilter : IFilter<Book>
    {
        public string WordInTitle { private set; get; }

        public BookTitleFilter(string wordInTitle)
        {
            WordInTitle = wordInTitle;
        }

        public bool Filter(Book book)
        {
            return book.Title.Contains(WordInTitle, StringComparison.OrdinalIgnoreCase);
        }
    }
}
