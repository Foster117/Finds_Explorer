using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace FindsExplorer.Services
{
    public class EmailService : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            MimeMessage emailMessage = new MimeMessage();

            //emailMessage.From.Add(new MailboxAddress("Finds Explorer", "johnoldman777@gmail.com"));
            emailMessage.From.Add(new MailboxAddress("Finds Explorer", "finds.explorer@ukr.net"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };
            
            using (var client = new SmtpClient())
            {
                //await client.ConnectAsync("smtp.gmail.com", 465, true);
                //await client.AuthenticateAsync("Finds.Explorer@gmail.com", "fbokzspdyryhbibe");
                await client.ConnectAsync("smtp.ukr.net", 465, true);
                await client.AuthenticateAsync("finds.explorer@ukr.net", "pSewsUYMIuXJciIL");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
