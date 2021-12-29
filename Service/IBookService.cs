using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Service
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();
        Task<Book> SaveBookAsync(Book book, int authorId);
        Task DeleteBookAsync(int isbn);
    }
}