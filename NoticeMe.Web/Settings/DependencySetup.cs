using Microsoft.AspNetCore.Identity.UI.Services;
using NoticeMe.Services.ServiceControllers;

namespace NoticeMe.Web.Settings
{
    public static class DependencySetup
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddScoped<IEmailSender, MailService>();
            return services;
        }
    }
}
