
namespace BookFilter.Backend
{
    public class BookTitleFilter : IFilter<Book>
    {
        public string WordInTitle { private set; get; }

        public BookTitleFilter(string wordInTitle)
        {
            this.WordInTitle = wordInTitle;
        }

        public bool Filter(Book book)
        {
            return book.Title.Contains(WordInTitle, StringComparison.OrdinalIgnoreCase);
        }
    }
}
