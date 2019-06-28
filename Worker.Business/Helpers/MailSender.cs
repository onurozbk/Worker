using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Worker.Business.Abstract;
using Worker.Business.Concrete;

namespace Worker.Business.Helpers
{
    public class MailSender:IMailSender
    {

        IWebSettingsService _webSettingsService;

        public MailSender()
        {
        }

        public MailSender(IWebSettingsService webSettingsService)
        {
            _webSettingsService = webSettingsService;
        }
        public void SendMail(string mailAdress, string subject, string body, string attachmentPath = null)
        {
           
            using (MailMessage mail = new MailMessage())
            {
                var data = _webSettingsService.GetWebSettings();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("onurozbkyedek@gmail.com");
                mail.To.Add(mailAdress);
                mail.Subject = subject;
                mail.Body = data.MailTemplate;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(data.MailAdress,data.MailPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }

        }
    }
}
