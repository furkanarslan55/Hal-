using Microsoft.AspNetCore.Identity;

namespace hali_takip.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
