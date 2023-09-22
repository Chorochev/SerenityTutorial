using Serenity.Data;
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MultiTenancy.Administration.RoleRow>;
using MyRow = MultiTenancy.Administration.RoleRow;


namespace MultiTenancy.Administration
{
    public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
    {
        private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

        public RoleListHandler(IRequestContext context)
             : base(context)
        {
        }
                
        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);

            if (!Permissions.HasPermission(PermissionKeys.Tenants))
                query.Where(Fld.TenantId == User.GetTenantId());
        }
    }
}