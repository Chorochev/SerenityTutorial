using Serenity.Services;
using System.Collections.Generic;

namespace MovieTutorial.MovieDB.Endpoints
{
    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}

   
