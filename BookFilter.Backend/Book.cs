using System.Globalization;

namespace BookFilter.Backend;
public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int PublicationYear { get; private set; }
    public decimal Price { get; private set; }
    public Book(string title, string author, int publicationYear, decimal price)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        Price = price;
    }
    public override string ToString()
    {
        return $"{Title} by {Author}, published in {PublicationYear}, costs {Price.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}";
    }
}
