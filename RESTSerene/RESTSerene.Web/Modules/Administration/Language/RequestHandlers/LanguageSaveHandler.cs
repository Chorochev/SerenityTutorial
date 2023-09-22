using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<RESTSerene.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = RESTSerene.Administration.LanguageRow;


namespace RESTSerene.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}