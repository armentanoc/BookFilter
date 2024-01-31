
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