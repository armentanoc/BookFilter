
namespace BookFilter.Backend
{
    public class BookFilter
    {
        public static bool PublicationYearGreaterOrEqual(Book book, int givenYear)
        {
            return book.PublicationYear >= givenYear;
        }

        public static bool PriceLowerOrEqual(Book book, decimal givenPrice)
        {
            return book.Price <= givenPrice;
        }

        public static bool WordInTitle(Book book, string givenWord)
        {
            return book.Title.Contains(givenWord, StringComparison.OrdinalIgnoreCase);
        }
    }
}
