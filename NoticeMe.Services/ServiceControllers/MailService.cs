using Microsoft.AspNetCore.Identity.UI.Services;

namespace NoticeMe.Services.ServiceControllers
{
    public class MailService : IEmailSender
    {
        
        const string emailFrom = "notice.me.development@abv.bg";
        public MailService()
        {
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            
           
        }
    }
}
