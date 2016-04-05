using Abp.Application.Features;
using BoilerplateDemo.Authorization.Roles;
using BoilerplateDemo.MultiTenancy;
using BoilerplateDemo.Users;

namespace BoilerplateDemo.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}