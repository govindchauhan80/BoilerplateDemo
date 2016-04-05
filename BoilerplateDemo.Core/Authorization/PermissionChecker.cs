using Abp.Authorization;
using BoilerplateDemo.Authorization.Roles;
using BoilerplateDemo.MultiTenancy;
using BoilerplateDemo.Users;

namespace BoilerplateDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
