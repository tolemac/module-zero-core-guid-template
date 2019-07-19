using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Linq;
using Abp.Organizations;
using AbpCompanyName.AbpProjectName.Authorization.Roles;

namespace AbpCompanyName.AbpProjectName.Authorization.Users
{
    public class UserStore : AbpUserStore<Role, User>
    {
        public UserStore(
            IUnitOfWorkManager unitOfWorkManager,
            IRepository<User> userRepository,
            IRepository<Role> roleRepository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IRepository<UserRole> userRoleRepository,
            IRepository<UserLogin> userLoginRepository,
            IRepository<UserClaim> userClaimRepository,
            IRepository<UserPermissionSetting> userPermissionSettingRepository,
            IRepository<UserOrganizationUnit> userOrganizationUnitRepository,
            IRepository<OrganizationUnitRole> organizationUnitRoleRepository)
            : base(
                unitOfWorkManager,
                userRepository,
                roleRepository,
                asyncQueryableExecuter,
                userRoleRepository,
                userLoginRepository,
                userClaimRepository,
                userPermissionSettingRepository,
                userOrganizationUnitRepository,
                organizationUnitRoleRepository)
        {
        }
    }
}
