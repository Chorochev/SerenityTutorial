using Microsoft.Extensions.Configuration;
using RESTSerene.Common;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace RESTSerene.Web.RESTServices
{
    public interface IRESTTableClient
    {
        List<T> List<T>(string tableName);
        T Get<T>(string tableName, int id);
        void Delete(string tableName, int id);
        void Insert<T>(string tableName, T item);
        void Update<T>(string tableName, T item);
    }

    public class TableClient : IRESTTableClient
    {
        private string baseUrl;
        public TableClient(IConfiguration configuration) {
            baseUrl = configuration.GetSection("RESTServiceSettings").GetValue<string>("Url");
        }

        public void Delete(string tableName, int id)
        {
            throw new System.NotImplementedException();
        }

        public T Get<T>(string tableName, int id)
        {
            using (var http = new HttpClient())
            {
                var path = new Uri(new Uri(baseUrl), $"{tableName}/{id}");
                var result = http.GetAsync(path).GetAwaiter().GetResult();
                var recordJson = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var record = JsonSerializer.Deserialize<T>(recordJson);
                return record;
            }
        }

        public void Insert<T>(string tableName, T item)
        {
            throw new System.NotImplementedException();
        }

        public List<T> List<T>(string tableName)
        {            
            using (var http = new HttpClient())
            {                
                var path = new Uri(new Uri(baseUrl), tableName);
                var result = http.GetAsync(path).GetAwaiter().GetResult();
                var recordsJson = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var records = JsonSerializer.Deserialize<List<T>>(recordsJson);
                return records;
            }                     
        }

        public void Update<T>(string tableName, T item)
        {
            throw new System.NotImplementedException();
        }
    }
}
