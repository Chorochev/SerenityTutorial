using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RESTService.Models
{
    public class Book
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Info")]
        public string Info { get; set; }  
        
        public Book()
        {
            Id = 0;
            Title = "";
            Info = "";
        }
    }
}
