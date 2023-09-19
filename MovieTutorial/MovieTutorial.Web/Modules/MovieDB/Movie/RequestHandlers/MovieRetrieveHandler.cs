using Serenity.Data;
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieTutorial.MovieDB.MovieRow>;
using MyRow = MovieTutorial.MovieDB.MovieRow;

namespace MovieTutorial.MovieDB;

public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
{
    public MovieRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}

//public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
//{
//    public MovieRetrieveHandler(IRequestContext context)
//            : base(context)
//    {
//    }

//    protected override void OnReturn()
//    {
//        base.OnReturn();

//        var mc = MovieCastRow.Fields;
//        Row.CastList = Connection.List<MovieCastRow>(q => q
//            .SelectTableFields()
//            .Select(mc.PersonFullname)
//            .Where(mc.MovieId == Row.MovieId.Value));
//    }
//}