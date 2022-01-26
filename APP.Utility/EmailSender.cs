using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;

namespace APP.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // throw new NotImplementedException();
            var emailToSend = new MimeMessage();
            emailToSend.From.Add(MailboxAddress.Parse("pcsureja.dev@gmail.com"));
            //  Gz4G=ghPvF6QH6$JrXrvHg#-jZrHPqs-uy#_Vb%tJ5$T8tyAPT
            emailToSend.To.Add(MailboxAddress.Parse(email));
            emailToSend.Subject = subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) {Text = htmlMessage};

            // Send email
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate("pcsureja.dev@gmail.com", "gmailpassword");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);
            }
            return Task.CompletedTask;
        }
    }
}

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using MailKit.Net.Smtp;
// using MailKit.Security;
// using MimeKit;
// using MimeKit.Text;


// namespace APP.Utility
// {
//     public interface IEmailService
//     {
//         void Send(string from, string to, string subject, string html);
//     }

//     public class EmailService : IEmailService
//     {
//         private readonly AppSettings _appSettings;

//         public EmailService(IOptions<AppSettings> appSettings)
//         {
//             _appSettings = appSettings.Value;
//         }

//         public void Send(string from, string to, string subject, string html)
//         {
//             // create message
//             var email = new MimeMessage();
//             email.From.Add(MailboxAddress.Parse(from));
//             email.To.Add(MailboxAddress.Parse(to));
//             email.Subject = subject;
//             email.Body = new TextPart(TextFormat.Html) { Text = html };

//             // send email
//             using var smtp = new SmtpClient();
//             smtp.Connect(_appSettings.SmtpHost, _appSettings.SmtpPort, SecureSocketOptions.StartTls);
//             smtp.Authenticate(_appSettings.SmtpUser, _appSettings.SmtpPass);
//             smtp.Send(email);
//             smtp.Disconnect(true);
//         }
//     }
// }