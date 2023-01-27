using Microsoft.AspNetCore.Identity;

namespace Cart.Models
{
        public class AppUser : IdentityUser
        {
                public string Occupation { get; set; }
        }
}
