using Serenity.Services;
using MyRequest = ReactSerene.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<ReactSerene.Administration.UserRow>;
using MyRow = ReactSerene.Administration.UserRow;

namespace ReactSerene.Administration
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