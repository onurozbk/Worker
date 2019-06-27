using Worker.Core.DataAccess;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom
    }
}
