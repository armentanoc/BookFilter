
namespace BookFilter.Backend
{
    public delegate bool Filter<T>(T element);
    public class LivroRepository
    {

        public Func<Livro, bool> booleanBookFilter;

        private List<Livro> livros;

        public LivroRepository(List<Livro> livros)
        {
            this.livros = livros;
        }
        public List<Livro> booleanBooks(Func<Livro, bool> booleanBookFilter)
        {
            return livros.Where(booleanBookFilter).ToList();
        }
        public List<Livro> Filtrar(Filter<Livro> filtro)
        {
            return livros.Where(x => filtro(x)).ToList();
        }

        public List<Livro> FiltrarComFunc(Func<Livro, bool> filtro)
        {
            return livros.Where(x => filtro(x)).ToList();
        }

        public List<Livro> FiltrarDiretamente(Func<Livro, string, bool> filtro, string palavra)
        {
            return livros.Where(livro => filtro(livro, palavra)).ToList();
        }
    }
}
