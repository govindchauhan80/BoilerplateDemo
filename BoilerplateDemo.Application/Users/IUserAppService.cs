using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerplateDemo.Users.Dto;

namespace BoilerplateDemo.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}