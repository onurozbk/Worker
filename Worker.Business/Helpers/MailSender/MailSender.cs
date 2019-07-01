using System.Net.Mail;
using Worker.Business.Abstract;
using Worker.Entities.Concrete;

namespace Worker.Business.Helpers
{
    public class MailSender : IMailSender
    {

        IWebSettingsService _webSettingsService;

        public MailSender(IWebSettingsService webSettingsService)
        {
            _webSettingsService = webSettingsService;
        }

        public void CustomerAdded(Customer customer)
        {
            var data = _webSettingsService.GetWebSettings();
            string subject, body, mailData = "";
            subject = "Customer Added";
            mailData = data.CustomerAddedTemplate;
            mailData = mailData.Replace("{0}", customer.CustomerName);
            mailData = mailData.Replace("{1}", customer.UserName);
            mailData = mailData.Replace("{2}", customer.UserPassword);
            body = data.MailTemplate;
            body = body.Replace("{0}", mailData);

            SendMail(customer.Mail, subject, body);
        }











        public void SendMail(string mailAdress, string subject, string body, string attachmentPath = null)
        {

            using (MailMessage mail = new MailMessage())
            {
                var data = _webSettingsService.GetWebSettings();
                SmtpClient SmtpServer = new SmtpClient(data.SmptAdress);
                mail.From = new MailAddress(data.SmtpMail);
                mail.To.Add(mailAdress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpServer.Port = data.SmtpPort;
                SmtpServer.Credentials = new System.Net.NetworkCredential(data.SmtpMail, data.SmtpPassword);
                SmtpServer.EnableSsl = data.SmtpSSL;

                SmtpServer.Send(mail);
            }

        }
    }
}
