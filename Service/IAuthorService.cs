using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Service
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAuthorsAsync();
        Task<Author> SaveAuthorAsync(Author author);
        



    }
}