using Microsoft.AspNetCore.Identity;

namespace OrFarm.Models.Account
{
    public class AppUser:IdentityUser<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Adress { get; set; }


    }
}
