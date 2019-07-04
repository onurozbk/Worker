using System.Threading.Tasks;
using Worker.Entities.Concrete;

namespace Worker.Business.Helpers
{
    public interface IMailSender
    {
        Task SendMail(string mailAdress, string subject, string body, string attachmentPath = null);
        void CustomerAddedAsync(Customer customer);
        void ActivityCreated(Customer customer,Activity activity);
    }
}
