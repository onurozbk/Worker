using Worker.Core.DataAccess.EntityFramework;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, WorkerContext>, ICustomerDal
    {
    }
}
