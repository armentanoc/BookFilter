
namespace BookFilter.UI
{
    internal class Display
    {
        internal static void CollectionByMessage<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine($"\n{message}");
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
