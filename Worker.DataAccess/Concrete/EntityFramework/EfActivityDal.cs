using Worker.Core.DataAccess.EntityFramework;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Concrete.EntityFramework
{
    class EfActivityDal:EfEntityRepositoryBase<Activity,WorkerContext>,IActivityDal
    {
    }
}
