using Worker.Core.DataAccess;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Custom
    }
}
