using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ReactSerene.Administration.RoleRow>;
using MyRow = ReactSerene.Administration.RoleRow;


namespace ReactSerene.Administration
{
    public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
    {
        public RoleRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}