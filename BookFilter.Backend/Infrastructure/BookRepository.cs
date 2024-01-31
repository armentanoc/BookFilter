using BookFilter.Backend.Domain.Model;

namespace BookFilter.Backend.Infrastructure
{
    public delegate bool Filter<T>(T element);
    public class BookRepository
    {

        private List<Book> _books;

        public BookRepository(List<Book> books)
        {
            _books = books;
        }

        public List<Book> Filter(IFilter<Book> iFilter) 
        {
            return _books.Where(x => iFilter.Filter(x)).ToList();
        }

        public IEnumerable<object> GetAll()
        {
            return _books;
        }
    }
}
