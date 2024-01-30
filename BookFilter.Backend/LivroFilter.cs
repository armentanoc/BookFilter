
namespace BookFilter.Backend
{
    public class LivroFilter
    {
        public static bool AnoPublicacaoMaiorOuIgual(Livro livro, int determinadoAno)
        {
            return livro.AnoPublicacao >= determinadoAno;
        }

        public static bool PrecoMenorOuIgual(Livro livro, decimal preco)
        {
            return livro.Preco <= preco;
        }

        public static bool PalavraNoTitulo(Livro livro, string palavra)
        {
            return livro.Titulo.Contains(palavra, StringComparison.OrdinalIgnoreCase);
        }
    }
}
