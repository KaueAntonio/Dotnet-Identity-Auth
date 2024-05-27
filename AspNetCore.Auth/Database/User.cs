using Microsoft.AspNetCore.Identity;

namespace AspNetCore.Auth.Database
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
