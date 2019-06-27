using System;
using System.Collections.Generic;
using System.Text;
using Worker.Core.DataAccess;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Abstract
{
   public interface IUserDal:IEntityRepository<User>
    {
        //custom
    }
}
