using Microsoft.AspNetCore.Identity;

namespace NoticeMe.Web.Settings
{
    public static class IdentitySetup
    {
        public static IdentityOptions ConfigureIdentityOptions(this IdentityOptions options, ConfigurationManager configuration)
        {
            string passwordOptionsDir = "IdentityOpt:PasswordOpt:";
            string signInOptionDir = "IdentityOpt:SignInOpt:";

            var passwordConfig = options.Password;
            var signInConfig = options.SignIn;

            passwordConfig.RequireDigit = configuration.GetValue<bool>(passwordOptionsDir + nameof(passwordConfig.RequireDigit));
            passwordConfig.RequiredLength = configuration.GetValue<int>(passwordOptionsDir + nameof(passwordConfig.RequiredLength));
            passwordConfig.RequireLowercase = configuration.GetValue<bool>(passwordOptionsDir + nameof(passwordConfig.RequireLowercase));
            passwordConfig.RequireUppercase = configuration.GetValue<bool>(passwordOptionsDir + nameof(passwordConfig.RequireUppercase));
            passwordConfig.RequiredUniqueChars = configuration.GetValue<int>(passwordOptionsDir + nameof(passwordConfig.RequiredUniqueChars));
            passwordConfig.RequireNonAlphanumeric = configuration.GetValue<bool>(passwordOptionsDir + nameof(passwordConfig.RequireNonAlphanumeric));

            signInConfig.RequireConfirmedEmail = configuration.GetValue<bool>(signInOptionDir + nameof(signInConfig.RequireConfirmedEmail));

            return options;
        }
    }
}
