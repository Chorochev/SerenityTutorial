using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MultiTenancy.Administration.TenantRow>;
using MyRow = MultiTenancy.Administration.TenantRow;

namespace MultiTenancy.Administration;

public interface ITenantListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TenantListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITenantListHandler
{
    public TenantListHandler(IRequestContext context)
            : base(context)
    {
    }
}