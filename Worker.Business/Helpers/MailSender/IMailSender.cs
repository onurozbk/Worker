using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Worker.Entities.Concrete;

namespace Worker.Business.Helpers
{
    public interface IMailSender
    {
        void SendMail(string mailAdress, string subject, string body, string attachmentPath = null);
        void CustomerAdded(Customer customer);
    }
}
