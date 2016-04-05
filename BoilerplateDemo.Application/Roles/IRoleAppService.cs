using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerplateDemo.Roles.Dto;

namespace BoilerplateDemo.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
