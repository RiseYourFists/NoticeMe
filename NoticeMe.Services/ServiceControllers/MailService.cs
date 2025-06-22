using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentEmail.Core.Models;
using FluentEmail.Mailgun;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using NoticeMe.Services.Models;

namespace NoticeMe.Services.ServiceControllers
{
    public class MailService : IEmailSender
    {
        MailgunSender _sender;
        public MailService(MailgunSender sender)
        {
            _sender = sender;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Address to = new Address(email);

            EmailData data = new EmailData() { 
                Subject = subject,
                Body = htmlMessage
            };

            data.ToAddresses.Add(to);

            FluentEmailModel model = new FluentEmailModel();
            model.Data = data;

            await _sender.SendAsync(model);
        }
    }
}
