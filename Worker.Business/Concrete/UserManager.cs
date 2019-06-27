using System;
using System.Collections.Generic;
using System.Text;
using Worker.Business.Abstract;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.Business.Concrete
{
    class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(int userId)
        {
            _userDal.Delete(new User { UserId = userId });
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetUser(int userId)
        {
            return _userDal.Get(p => p.UserId == userId);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
