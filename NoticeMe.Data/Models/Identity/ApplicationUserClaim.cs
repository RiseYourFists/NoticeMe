using Microsoft.AspNetCore.Identity;

namespace NoticeMe.Core.Models.Identity
{
    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
