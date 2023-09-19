using Serenity.Data;
using Serenity.Services;
using System.Collections.Generic;
using System.Linq;
using MyRequest = Serenity.Services.SaveRequest<MovieTutorial.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieTutorial.MovieDB.MovieRow;

namespace MovieTutorial.MovieDB;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}

//public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
//{
//    private IMovieCastDeleteHandler MovieCastDeleteHandler { get; }
//    private IMovieCastSaveHandler MovieCastSaveHandler { get; }

//    public MovieSaveHandler(IRequestContext context,
//        IMovieCastDeleteHandler movieCastDeleteHandler,
//        IMovieCastSaveHandler movieCastSaveHandler)
//            : base(context)
//    {
//        MovieCastDeleteHandler = movieCastDeleteHandler;
//        MovieCastSaveHandler = movieCastSaveHandler;
//    }

//    protected override void AfterSave()
//    {
//        base.AfterSave();
//        SetMovieCastRelation();
//    }

//    private void SetMovieCastRelation()
//    {
//        if (Row.CastList != null)
//        {
//            var mc = MovieCastRow.Fields;
//            var oldList = IsCreate ? new List<MovieCastRow>() :
//                Connection.List<MovieCastRow>(
//                    mc.MovieId == this.Row.MovieId.Value);

//            var oldById = oldList.ToDictionary(x => x.MovieCastId.Value);
//            var newById = Row.CastList.ToLookup(x => x.MovieCastId);

//            // delete it if the old object is not in the new list 
//            foreach (var row in oldList.Where(x => !newById.Contains(x.MovieCastId)))
//            {
//                MovieCastDeleteHandler.Delete(UnitOfWork, new() { EntityId = row.MovieCastId });
//            }

//            foreach (var row in Row.CastList)
//            {
//                var entity = row.Clone(); // we clone the object so it doesn't change on functions dependent to request data
//                entity.MovieId = Row.MovieId.Value;

//                // create it if id is null or old list doesn't have the same id or update
//                if (row.MovieCastId == null || !oldById.ContainsKey(row.MovieCastId.Value))
//                {
//                    entity.MovieCastId = null;
//                    MovieCastSaveHandler.Create(UnitOfWork, new()
//                    {
//                        Entity = entity
//                    });
//                }
//                else
//                {
//                    MovieCastSaveHandler.Update(UnitOfWork, new()
//                    {
//                        Entity = entity
//                    });
//                }
//            }
//        }
//    }
//}