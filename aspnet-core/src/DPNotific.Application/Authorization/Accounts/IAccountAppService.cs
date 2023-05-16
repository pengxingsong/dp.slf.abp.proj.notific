using System.Threading.Tasks;
using Abp.Application.Services;
using DPNotific.Authorization.Accounts.Dto;

namespace DPNotific.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
