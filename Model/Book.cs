using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AuthorBlazor.Model
{
    public class Book
    {
        
       [JsonPropertyName("isbn")] public int ISBN { get; set; }
     
        [JsonPropertyName("title")]
       [Required(ErrorMessage = "Title field is required ")]
        public string Title { get; set; }
        
        [JsonPropertyName("publicationYear")]public  int PublicationYear { get; set; }
       [JsonPropertyName("numOfPages")] public int NumOfPages { get; set; }
        
        [Required(ErrorMessage = "Genre field is required")]
        [JsonPropertyName("genre")]
        public string Genre { get; set; }
    }
}