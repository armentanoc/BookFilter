
namespace BookFilter.Backend
{
    public class LivroFilterPreco : IFilter<Livro>
    {
        public decimal maxPrice;

        public LivroFilterPreco(decimal maxPrice)
        {
            this.maxPrice = maxPrice;
        }

        public bool Filter(Livro livro)
        {
            return livro.Preco <= maxPrice;
        }
    }
}
