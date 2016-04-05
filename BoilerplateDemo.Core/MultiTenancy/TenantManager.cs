using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using BoilerplateDemo.Authorization.Roles;
using BoilerplateDemo.Editions;
using BoilerplateDemo.Users;

namespace BoilerplateDemo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}