using System;
using System.Collections.Generic;
using System.Text;
using Worker.Core.DataAccess.EntityFramework;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,WorkerContext>,IUserDal
    {
    }
}
