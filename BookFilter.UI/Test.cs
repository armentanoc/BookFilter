using BookFilter.Backend.Domain.Model;
using BookFilter.Backend.Domain.Service;
using BookFilter.Backend.Infrastructure;

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
        internal static void DisplayAllBooks(BookRepository bookRepository)
        {
            Display.CollectionByMessage("Todos os livros:", bookRepository.GetAll());
        }

        internal static void BookRepositoryByMaxPrice(BookRepository bookRepository, decimal maxPrice)
        {
            List<Book> filteredBooks = BookFilterService.BookRepositoryByMaxPrice(bookRepository, maxPrice);
            Display.CollectionByMessage($"Livros com Preço <= {maxPrice}:", filteredBooks);
        }

        internal static void BookRepositoryByMinPublicationYear(BookRepository bookRepository, int minPublicationYear)
        {
            List<Book> filteredBooks = BookFilterService.BookRepositoryByMinPublicationYear(bookRepository, minPublicationYear);
            Display.CollectionByMessage($"Livros com Ano de Publicação >= {minPublicationYear}:", filteredBooks);
        }

        internal static void BookRepositoryByWordInTitle(BookRepository bookRepository, string wordInTitle)
        {
            List<Book> filteredBooks = BookFilterService.BookRepositoryByWordInTitle(bookRepository, wordInTitle);
            Display.CollectionByMessage($"Livros com '{wordInTitle}' no Título:", filteredBooks);
        }
    }
}