using RESTSerene.Common;
using Serenity.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace RESTSerene.Web.RESTServices
{
    public interface IRESTTableClient
    {
        List<object> List(string tableName);
        object Get(string tableName, int id);
        void Delete(string tableName, int id);
        void Insert(string tableName, object item);
        void Update(string tableName, object item);
    }

    public class TableClient : IRESTTableClient
    {
        public TableClient() { }

        public void Delete(string tableName, int id)
        {
            throw new System.NotImplementedException();
        }

        public object Get(string tableName, int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(string tableName, object item)
        {
            throw new System.NotImplementedException();
        }

        public List<object> List(string tableName)
        {
            var records = new List<object>()
                {
                    new BookPageModel() { Id = 1, Title = "Остров сокровищ", Info = "Приключения про поиск пиратских сокровищ." },
                    new BookPageModel() { Id = 2, Title = "Мастер и Маргарита", Info = "Про любовь." },
                    new BookPageModel() { Id = 3, Title = "Война и Мир", Info = "Про войну." },
                    new BookPageModel() { Id = 4, Title = "Война миров", Info = "Про войну с инопланетянами." }
                };
            return records;                 
        }

        public void Update(string tableName, object item)
        {
            throw new System.NotImplementedException();
        }
    }
}
