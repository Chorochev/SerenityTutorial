using Serenity.Data;
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MultiTenancy.Administration.RoleRow>;
using MyRow = MultiTenancy.Administration.RoleRow;


namespace MultiTenancy.Administration
{
    public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
    {
        private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

        public RoleRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }

        //protected override void PrepareQuery(SqlQuery query)
        //{
        //    base.PrepareQuery(query);

        //    if (!Permissions.HasPermission(PermissionKeys.Tenants))
        //        query.Where(Fld.TenantId == User.GetTenantId());
        //}
    }
}