using System;

namespace AbpCompanyName.AbpProjectName.Authorization.Accounts.Dto
{
    public class IsTenantAvailableOutput
    {
        public TenantAvailabilityState State { get; set; }

        public Guid? TenantId { get; set; }

        public IsTenantAvailableOutput()
        {
        }

        public IsTenantAvailableOutput(TenantAvailabilityState state, Guid? tenantId = null)
        {
            State = state;
            TenantId = tenantId;
        }
    }
}
