using System;
using System.Collections.Generic;
using System.Text;
using Worker.Entities.Concrete;

namespace Worker.Business.Abstract
{
    interface IUserService
    {
        List<User> GetAll();
        User GetUser(int userId);
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
    }
}
