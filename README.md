# BookFilterService 🌐

O `BookFilterService` é um módulo do projeto `BookFilter` que oferece métodos para filtrar uma coleção de livros com base em diferentes critérios. Essa funcionalidade é implementada através do uso de delegates e uma interface:
```lua
Domain
|-- Model
|   |-- Book.cs
|   |-- BookPriceFilter.cs
|   |-- BookPublicationYearFilter.cs
|   |-- BookTitleFilter.cs
|   |-- IFilter.cs
|-- Service
|   |-- BookFilterService.cs
|-- Infrastructure
|   |-- BookRepository.cs
```

## Interface 

A interface IFilter<T> define um contrato que as classes devem seguir se desejarem atuar como filtros. O método Filter nesta interface é responsável por avaliar se um item do tipo T atende aos critérios de filtragem:

```csharp
namespace BookFilter.Backend.Domain.Model
{
    public interface IFilter<T>
    {
        bool Filter(T item);
    }
}
```

A interface, então, é implementada por: `BookPublicationYearFilter`, `BookPriceFilter` e `BookTitleFilter`.

## Filtros

O serviço usa filtros personalizados (`BookPublicationYearFilter`, `BookPriceFilter` e `BookTitleFilter`) para realizar a filtragem com base em critérios específicos:

- `BookPublicationYearFilter`: Filtra livros com base no ano mínimo de publicação.
- `BookPriceFilter`: Filtra livros com base no preço máximo.
- `BookTitleFilter`: Filtra livros com base em uma palavra presente no título.

As classes implementam a interface `IFilter<T>` com base no contexto do delegate `Filter<T>(T element)`: 
```csharp
using BookFilter.Backend.Domain.Model;

namespace BookFilter.Backend.Infrastructure
{
    public delegate bool Filter<T>(T element);
//...
}
```

## Métodos

### `BookRepositoryByMinPublicationYear` 📅

Filtra os livros no repositório com base no ano mínimo de publicação.

#### Parâmetros

- `bookRepository`: Uma instância da classe `BookRepository`.
- `minPublicationYear`: O ano mínimo de publicação para filtrar os livros.

#### Retorno

Uma lista de livros que atendem ao critério do ano mínimo de publicação.

### `BookRepositoryByMaxPrice` 💰

Filtra os livros no repositório com base no preço máximo.

#### Parâmetros

- `bookRepository`: Uma instância da classe BookRepository.
- `maxPrice`: O preço máximo para filtrar os livros.

#### Retorno

Uma lista de livros que atendem ao critério do preço máximo.

### `BookRepositoryByWordInTitle` 📚

Filtra os livros no repositório com base em uma palavra presente no título.

#### Parâmetros

- `bookRepository`: Uma instância da classe BookRepository.
- `wordInTitle`: A palavra a ser procurada nos títulos dos livros.

#### Retorno

Uma lista de livros que têm a palavra especificada em seus títulos.

## Exemplo de Uso

```csharp
BookRepository bookRepository = new BookRepository(); // Inicialize seu repositório de livros

int minPublicationYear = 2000;
decimal maxPrice = 30.00M;
string wordInTitle = "aventura";

List<Book> resultadoPorMinAnoPublicacao = BookFilterService.BookRepositoryByMinPublicationYear(bookRepository, minPublicationYear);
List<Book> resultadoPorMaxPreco = BookFilterService.BookRepositoryByMaxPrice(bookRepository, maxPrice);
List<Book> resultadoPorPalavraNoTitulo = BookFilterService.BookRepositoryByWordInTitle(bookRepository, wordInTitle);
