using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ReactSerene.Administration.LanguageRow>;
using MyRow = ReactSerene.Administration.LanguageRow;


namespace ReactSerene.Administration
{
    public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
    {
        public LanguageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}