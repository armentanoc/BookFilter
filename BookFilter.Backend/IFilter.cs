
namespace BookFilter.Backend
{
    public interface IFilter<T>
    {
        public bool Filter(T item);
    }
}
