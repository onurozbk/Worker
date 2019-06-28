using Worker.Core.DataAccess;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        //custom
    }
}
