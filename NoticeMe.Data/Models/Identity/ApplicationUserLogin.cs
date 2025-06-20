using Microsoft.AspNetCore.Identity;

namespace NoticeMe.Core.Models.Identity
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
