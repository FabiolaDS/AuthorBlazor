using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Service
{
    public class HttpAuthorService:IAuthorService

    {
        private HttpClient _httpClient;
        private string url= "http://localhost:5000";

        public HttpAuthorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Author>> GetAuthorsAsync()
        {
            var response = await _httpClient.GetAsync(url + "/authors");
            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json);
            return JsonSerializer.Deserialize<List<Author>>(json);
            
        }

        public async Task<Author> SaveAuthorAsync(Author author)
        {
            var content= new StringContent(JsonSerializer.Serialize(author), Encoding.UTF8,"application/json");
            var response = await _httpClient.PostAsync(url + "/authors",content);
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Author>(json);
        }
    }
}