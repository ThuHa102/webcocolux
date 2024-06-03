using Microsoft.AspNetCore.Authorization;

namespace Cosmetic_Web.ExtendMethods
{
    public class AuthorizationService
    {
        public void AddRoleAndPolicy(string roleName, AuthorizationOptions authorizationOptions)
        {
            // Thêm policy mới với yêu cầu là người dùng phải có role tương ứng
            authorizationOptions.AddPolicy(roleName, policy => policy.RequireRole(roleName));
        }
    }
}
