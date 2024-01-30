using BookFilter.Backend;
using System.Globalization;

namespace BookFilter.UI
{
    internal class Display
    {
        internal static void LivrosByMessage(string message, IEnumerable<Livro> livros)
        {
            Console.WriteLine($"\n{message}");
            foreach (var livro in livros)
            {
                Console.WriteLine(
                    $"Título => {livro.Titulo}, " +
                    $"Autor => {livro.Autor}, " +
                    $"Ano de Publicação => {livro.AnoPublicacao}, " +
                    $"Preço => {livro.Preco.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}" 
                    );
            }
        }
    }
}
