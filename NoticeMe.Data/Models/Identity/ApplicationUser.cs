using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static NoticeMe.Core.ValidationConstants.IdentityConstants.IdentityConstants;

namespace NoticeMe.Core.Models.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(FirstNameMaxLength)]
        [Comment("User first name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        [Comment("User last name")]
        public string LastName { get; set; } = null!;

        [Required]
        [Comment("Identifier if the user account is deleted")]
        public bool IsActive { get; set; }

        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
