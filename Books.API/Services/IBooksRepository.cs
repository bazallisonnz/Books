using Books.API.Entities;

namespace Books.API.Services;

public interface IBooksRepository
{
    Task<IEnumerable<Book>> GetBooksAsync();

    Task<Book?> GetBookAsync(Guid id);
}
