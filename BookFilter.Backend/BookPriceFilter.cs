
namespace BookFilter.Backend
{
    public class BookPriceFilter : IFilter<Book>
    {
        public decimal MaxPrice { private set; get; }

        public BookPriceFilter(decimal maxPrice)
        {
            this.MaxPrice = maxPrice;
        }

        public bool Filter(Book book)
        {
            return book.Price <= MaxPrice;
        }
    }
}
