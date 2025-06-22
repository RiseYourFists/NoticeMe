using FluentEmail.Mailgun;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NoticeMe.Services.ServiceControllers;

namespace NoticeMe.Web.Settings
{
    public static class DependencySetup
    {
        private const string domainName = "https://localhost:44368";
        public static IServiceCollection AddDependencies(this IServiceCollection services, ConfigurationManager configuration)
        {
            var emailSenderApiKey = configuration["email_api_key"];

            services.AddScoped(s => new MailgunSender(domainName, emailSenderApiKey));
            services.AddScoped<IEmailSender, MailService>();

            return services;
        }
    }
}
