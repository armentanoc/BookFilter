using BookFilter.Backend;

namespace BookFilter.UI
{
    class Program
    {
        private const int ANO_PUBLICACAO_MAXIMO = 2019;
        private const decimal PRECO_MAXIMO = 45.0m;
        private const string PALAVRA_TITULO = "C#";
        public static void Main(string[] args)
        {
            var livros = new List<Livro>
        {
            new Livro { Titulo = "Programação em C#", Autor = "John Doe", AnoPublicacao = 2020, Preco = 50.0m },
            new Livro { Titulo = "Estrutura de Dados", Autor = "Jane Smith", AnoPublicacao = 2018, Preco = 40.0m },
            new Livro { Titulo = "Algoritmos com Python", Autor = "John Smith", AnoPublicacao = 2019, Preco = 45.0m }
        };

            var livroRepository = new LivroRepository(livros);

            Func<Livro, bool> funcAnoPublicacao = livro => LivroFilter.AnoPublicacaoMaiorOuIgual(livro, ANO_PUBLICACAO_MAXIMO);
            List<Livro> resultadoAnoPublicacaoFunc = livroRepository.FiltrarComFunc(funcAnoPublicacao);
            //preferível

            Filter<Livro> filtroPrecoMaximo = livro => LivroFilter.PrecoMenorOuIgual(livro, PRECO_MAXIMO);
            List<Livro> resultadoPrecoMaximo = livroRepository.Filtrar(filtroPrecoMaximo);
            //é bom porque mantém genérico 

            Func<Livro, string, bool> filtroPalavraNoTitulo = (livro, palavra) => livro.Titulo.Contains(palavra, StringComparison.OrdinalIgnoreCase);
            List<Livro> resultadoPalavraNoTitulo = livroRepository.FiltrarDiretamente(filtroPalavraNoTitulo, "C#");
            //ruim porque mistura muito as coisas e não é tão genérico quanto gostaríamos

            Display.LivrosByMessage("Todos os livros:", livros);
            Display.LivrosByMessage($"Livros com Ano de Publicação >= {ANO_PUBLICACAO_MAXIMO}:", resultadoAnoPublicacaoFunc);
            Display.LivrosByMessage($"Livros com Preço <= {PRECO_MAXIMO}:", resultadoPrecoMaximo);
            Display.LivrosByMessage($"Livros com '{PALAVRA_TITULO}' no Título:", resultadoPalavraNoTitulo);
        }
    }
    //exemplo

    //public List<int> FilterNumber(Func<int, bool> filter)
    //{
    //    return _numbers.Where(filter).ToList();
    //}

    // EXEMPLO: FilterNumber(number => number % 2 == 0)
    // RETORNO: todos os pares da lista
}
