using Abp.Authorization.Roles;
using BoilerplateDemo.MultiTenancy;
using BoilerplateDemo.Users;

namespace BoilerplateDemo.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}