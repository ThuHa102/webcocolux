using Microsoft.AspNetCore.Authorization;

namespace Cosmetic_Web.ExtendMethods
{
    public class CustomAuthorizationRequirement : IAuthorizationRequirement
    {
        public string[] RoleNames { get; }

        public CustomAuthorizationRequirement(params string[] roleNames)
        {
            RoleNames = roleNames;
        }
    }
}
