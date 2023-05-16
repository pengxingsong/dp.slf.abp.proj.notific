using Abp.Application.Services;
using DPNotific.MultiTenancy.Dto;

namespace DPNotific.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

