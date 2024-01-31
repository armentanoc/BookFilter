

namespace BookFilter.Backend
{
    public delegate bool Filter<T>(T element);
    public class BookRepository
    {

        private List<Book> _books;

        public BookRepository(List<Book> books)
        {
            this._books = books;
        }

        public List<Book> Filter(IFilter<Book> iFilter) //interface filter
        {
            return _books.Where(x => iFilter.Filter(x)).ToList();
        }

        public IEnumerable<object> GetAll()
        {
            return _books;
        }
    }
}

//Old code, for comparison only

//public Func<Book, bool> booleanBookFilter;

//public List<Book> FuncFilter(Func<Book, bool> filter)
//{
//    return _books.Where(x => filter(x)).ToList();
//}

//public List<Book> DirectFilter(Func<Book, string, bool> filter, string givenWord)
//{
//    return _books.Where(livro => filter(livro, givenWord)).ToList();
//}

//public List<Livro> booleanBooks(Func<Livro, bool> booleanBookFilter)
//{
//    return livros.Where(booleanBookFilter).ToList();
//}
//public List<Livro> Filtrar(Filter<Livro> filtro)
//{
//    return livros.Where(x => filtro(x)).ToList();
//}