using BookFilter.Backend.Domain.Model;
using BookFilter.Backend.Infrastructure;

namespace BookFilter.Backend.Domain.Service
{
    public class BookFilterService
    {
        public static List<Book> BookRepositoryByMinPublicationYear(BookRepository bookRepository, int minPublicationYear)
        {
            IFilter<Book> minPublicationYearFilter = new BookPublicationYearFilter(minPublicationYear);
            return bookRepository.Filter(minPublicationYearFilter);
        }

        public static List<Book> BookRepositoryByMaxPrice(BookRepository bookRepository, decimal maxPrice)
        {
            IFilter<Book> maxPriceFilter = new BookPriceFilter(maxPrice);
            return bookRepository.Filter(maxPriceFilter);
        }

        public static List<Book> BookRepositoryByWordInTitle(BookRepository bookRepository, string wordInTitle)
        {
            IFilter<Book> wordInTitleFilter = new BookTitleFilter(wordInTitle);
            return bookRepository.Filter(wordInTitleFilter);
        }
    }
}
