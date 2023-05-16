using System.Threading.Tasks;
using Abp.Application.Services;
using DPNotific.Sessions.Dto;

namespace DPNotific.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
