
namespace BookFilter.UI
{
    class Program
    {
        private const int MIN_PUBLICATION_YEAR = 2019;
        private const decimal MAX_PRICE = 45.0m;
        private const string WORD_IN_TITLE = "C#";
        public static void Main(string[] args)
        {
            var bookRepository = Test.GenerateBookSample();

            Test.DisplayAllBooks(bookRepository);
            Test.BookRepositoryByMaxPrice(bookRepository, MAX_PRICE);
            Test.BookRepositoryByMinPublicationYear(bookRepository, MIN_PUBLICATION_YEAR);
            Test.BookRepositoryByWordInTitle(bookRepository, WORD_IN_TITLE);
        }
    }
}

//old code, for comparison only

//exemplo

//public List<int> FilterNumber(Func<int, bool> filter)
//{
//    return _numbers.Where(filter).ToList();
//}

// EXEMPLO: FilterNumber(number => number % 2 == 0)
// RETORNO: todos os pares da lista



//Func<Livro, bool> funcAnoPublicacao = livro => LivroFilter.AnoPublicacaoMaiorOuIgual(livro, ANO_PUBLICACAO_MAXIMO);
//List<Livro> resultadoAnoPublicacaoFunc = livroRepository.FiltrarComFunc(funcAnoPublicacao);
////preferível

//Filter<Livro> filtroPrecoMaximo = livro => LivroFilter.PrecoMenorOuIgual(livro, PRECO_MAXIMO);
//List<Livro> resultadoPrecoMaximo = livroRepository.Filtrar(filtroPrecoMaximo);
////é bom porque mantém genérico 

//Func<Livro, string, bool> filtroPalavraNoTitulo = (livro, palavra) => livro.Titulo.Contains(palavra, StringComparison.OrdinalIgnoreCase);
//List<Livro> resultadoPalavraNoTitulo = livroRepository.FiltrarDiretamente(filtroPalavraNoTitulo, "C#");
////ruim porque mistura muito as coisas e não é tão genérico quanto gostaríamos
