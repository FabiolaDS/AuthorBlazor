using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Service
{
    public class HttpBookService:IBookService

    {
        private HttpClient _httpClient;
        private string url= "http://localhost:5000";

        public HttpBookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Book>> GetBooksAsync()
        {
            var response = await _httpClient.GetAsync(url + "/Books");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Book>>(json);
        }

        public async Task<Book> SaveBookAsync(Book book, int authorId)
        {
            var content= new StringContent(JsonSerializer.Serialize(book), Encoding.UTF8,"application/json");
            var response = await _httpClient.PostAsync(url + "/Book/"+authorId,content);
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Book>(json);
        }

        public async Task DeleteBookAsync(int isbn)
        {
            await _httpClient.DeleteAsync(url + "/Book/"+isbn);
        }
    }
}