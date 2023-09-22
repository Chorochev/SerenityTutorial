using System.ComponentModel.DataAnnotations;

namespace RESTService.Models
{
    public class Book
    {        
        public int Id { get; set; }       
        public string Title { get; set; }
        public string Info { get; set; }                
    }
}
