using System.Collections.Generic;

namespace RESTSerene.Common
{
    public class BooksPageModel
    {
        public List<BookPageModel> Books { get; set; }
    }


    public class BookPageModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
    }
}
