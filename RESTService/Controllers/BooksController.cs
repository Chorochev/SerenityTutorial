using Microsoft.AspNetCore.Mvc;
using RESTService.Models;
using System.Reflection;

namespace RESTService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private List<Book> books = new List<Book>() {
                new Book() { Id = 1, Title = "Остров сокровищ", Info = "Приключения про поиск пиратских сокровищ." },
                new Book() { Id = 2, Title = "Мастер и Маргарита", Info = "Про любовь." },
                new Book() { Id = 3, Title = "Война и Мир", Info = "Про войну." } };

        [HttpGet]
        [Route("")]
        public IEnumerable<Book> GetBooks()
        {
            return books;
        }

        [HttpGet]
        [Route("{Id:int}")]
        public Book? GetBook(int Id)
        {
            return books.FirstOrDefault(x => x.Id == Id);
        }
    }
}
