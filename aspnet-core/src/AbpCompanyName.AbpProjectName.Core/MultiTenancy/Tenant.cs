using Abp.MultiTenancy;
using AbpCompanyName.AbpProjectName.Authorization.Users;
using System;

namespace AbpCompanyName.AbpProjectName.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(Guid tenantId, string tenancyName, string name)
            : base(tenantId, tenancyName, name)
        {
        }
    }
}
