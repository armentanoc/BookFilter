namespace BookFilter.Backend.Domain.Model
{
    public interface IFilter<T>
    {
        public bool Filter(T item);
    }
}
