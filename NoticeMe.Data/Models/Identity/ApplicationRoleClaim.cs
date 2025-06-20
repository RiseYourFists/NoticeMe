using Microsoft.AspNetCore.Identity;

namespace NoticeMe.Core.Models.Identity
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}
