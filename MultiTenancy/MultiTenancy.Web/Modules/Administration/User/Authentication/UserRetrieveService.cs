using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using MyRow = MultiTenancy.Administration.UserRow;

namespace MultiTenancy.Administration
{
    public class UserRetrieveService : IUserRetrieveService
    {
        private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

        protected ITwoLevelCache Cache { get; }
        protected ISqlConnections SqlConnections { get; }

        public UserRetrieveService(ITwoLevelCache cache, ISqlConnections sqlConnections)
        {
            Cache = cache;
            SqlConnections = sqlConnections;
        }

        private static UserDefinition GetFirst(IDbConnection connection, BaseCriteria criteria)
        {
            var user = connection.TrySingle<MyRow>(criteria);
            if (user != null)
                return new UserDefinition
                {
                    UserId = user.UserId.Value,
                    Username = user.Username,
                    Email = user.Email,
                    UserImage = user.UserImage,
                    DisplayName = user.DisplayName,
                    IsActive = user.IsActive.Value,
                    Source = user.Source,
                    PasswordHash = user.PasswordHash,
                    PasswordSalt = user.PasswordSalt,
                    UpdateDate = user.UpdateDate,
                    LastDirectoryUpdate = user.LastDirectoryUpdate,
                    TenantId = user.TenantId.Value
                };

            return null;
        }

        public IUserDefinition ById(string id)
        {
            return Cache.Get("UserByID_" + id, TimeSpan.Zero, TimeSpan.FromDays(1), Fld.GenerationKey, () =>
            {
                using var connection = SqlConnections.NewByKey("Default");
                return GetFirst(connection, new Criteria(Fld.UserId) == int.Parse(id, CultureInfo.InvariantCulture));
            });
        }

        public IUserDefinition ByUsername(string username)
        {
            if (username.IsEmptyOrNull())
                return null;

            return Cache.Get("UserByName_" + username.ToLowerInvariant(),
                TimeSpan.Zero, TimeSpan.FromDays(1), Fld.GenerationKey, () =>
            {
                using var connection = SqlConnections.NewByKey("Default");
                return GetFirst(connection, new Criteria(Fld.Username) == username);
            });
        }

        public static void RemoveCachedUser(ITwoLevelCache cache, int? userId, string username)
        {
            if (userId != null)
                cache.Remove("UserByID_" + userId);

            if (username != null)
                cache.Remove("UserByName_" + username.ToLowerInvariant());
        }

        public static ClaimsPrincipal CreatePrincipal(IUserRetrieveService userRetriever, string username, string authType)
        {
            if (userRetriever is null)
                throw new ArgumentNullException(nameof(userRetriever));

            if (username is null)
                throw new ArgumentNullException(nameof(username));

            var user = (UserDefinition)userRetriever.ByUsername(username);
            if (user == null)
                throw new ArgumentOutOfRangeException(nameof(username));

            if (authType == null)
                throw new ArgumentNullException(nameof(authType));

            var identity = new GenericIdentity(username, authType);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
            identity.AddClaim(new Claim("TenantId", user.TenantId.ToInvariant())); // add tenant id claim

            return new ClaimsPrincipal(identity);
        }
    }
}

namespace MultiTenancy.Administration
{
    public static class ClaimsPrincipalExtensions
    {
        public static int GetTenantId(this ClaimsPrincipal user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            var tenantClaim = user.Claims.FirstOrDefault(x => x.Type == "TenantId");
            if (tenantClaim is null)
                throw new NullReferenceException("TenantId claim not found");

            return int.Parse(tenantClaim.Value);
        }
    }
}