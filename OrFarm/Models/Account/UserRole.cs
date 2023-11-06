using Microsoft.AspNetCore.Identity;

namespace OrFarm.Models.Account
{
    public class UserRole:IdentityRole
    {
        public const string ADMIN = "ADMIN";
        public const string MODERATOR = "MODERATOR";
        public const string DEVELOPER = "DEVELOPER";
    }
}
