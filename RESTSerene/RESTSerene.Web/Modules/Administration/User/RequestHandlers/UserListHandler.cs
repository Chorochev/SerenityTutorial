using Serenity.Services;
using MyRequest = RESTSerene.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<RESTSerene.Administration.UserRow>;
using MyRow = RESTSerene.Administration.UserRow;

namespace RESTSerene.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}