using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpCompanyName.AbpProjectName.MultiTenancy.Dto;
using System;

namespace AbpCompanyName.AbpProjectName.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, Guid, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

