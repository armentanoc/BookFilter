using BookFilter.Backend;

namespace BookFilter.UI
{
    internal class Test
    {
        internal static BookRepository GenerateBookSample()
        {
            var books = new List<Book>
        {
            new Book ( title: "Programação em C#", author: "John Doe", publicationYear: 2020, price: 50.0m ),
            new Book (title : "Estrutura de Dados", author : "Jane Smith", publicationYear : 2018, price : 40.0m),
            new Book (title : "Algoritmos com Python", author : "John Smith", publicationYear : 2019, price : 45.0m)
        };
            return new BookRepository(books);
        }
        internal static void BookRepositoryByMinPublicationYear(BookRepository bookRepository, int minPublicationYear)
        {
            IFilter<Book> minPublicationYearFilter = new BookPublicationYearFilter(minPublicationYear);
            List<Book> resultMinPublicationYear = bookRepository.Filter(minPublicationYearFilter);
            Display.CollectionByMessage($"Livros com Ano de Publicação >= {minPublicationYear}:", resultMinPublicationYear);
        }

        internal static void BookRepositoryByMaxPrice(BookRepository bookRepository, decimal maxPrice)
        {
            IFilter<Book> maxPriceFilter = new BookPriceFilter(maxPrice);
            List<Book> resultMaxPrice = bookRepository.Filter(maxPriceFilter);
            Display.CollectionByMessage($"Livros com Preço <= {maxPrice}:", resultMaxPrice);
        }

        internal static void BookRepositoryByWordInTitle(BookRepository bookRepository, string wordInTitle)
        {
            IFilter<Book> wordInTitleFilter = new BookTitleFilter(wordInTitle);
            List<Book> resultWordInTitleFilter = bookRepository.Filter(wordInTitleFilter);
            Display.CollectionByMessage($"Livros com '{wordInTitle}' no Título:", resultWordInTitleFilter);
        }
        internal static void DisplayAllBooks(BookRepository bookRepository)
        {
            Display.CollectionByMessage("Todos os livros:", bookRepository.GetAll());
        }
    }
}