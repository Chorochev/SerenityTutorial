using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ReactSerene.Administration.LanguageRow>;
using MyRow = ReactSerene.Administration.LanguageRow;


namespace ReactSerene.Administration
{
    public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
    {
        public LanguageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}