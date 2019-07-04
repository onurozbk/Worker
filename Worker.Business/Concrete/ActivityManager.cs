using System.Collections.Generic;
using Worker.Business.Abstract;
using Worker.Business.Helpers;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.Business.Concrete
{
    public class ActivityManager : IActivityService
    {
        private IActivityDal _activityDal;
        private ICustomerDal _customerDal;
        private ICustomerService _customerService;
        private IMailSender _mailSender;

        public ActivityManager(IActivityDal activityDal, ICustomerDal customerDal, ICustomerService customerService, IMailSender mailSender)
        {
            _activityDal = activityDal;
            _customerDal = customerDal;
            _customerService = customerService;
            _mailSender = mailSender;
        }

        public void Add(Activity activity)
        {
            try
            {
                _activityDal.Add(activity);
                var customer = _customerDal.Get(x => x.CustomerId == activity.CustomerId);
                if (customer == null)
                    return;
                _mailSender.ActivityCreated(customer, activity);
            }
            catch
            {
                throw;
            }

        }

        public void Delete(int activityId)
        {
            _activityDal.Delete(new Activity { ActivityId = activityId });
        }

        public List<Activity> GetAll()
        {
            return _activityDal.GetList();
        }

        public List<Activity> GetByRelatedUser(int relatedUser)
        {
            return _activityDal.GetList(p => p.RelatedUser == relatedUser);
        }

        public void Update(Activity activity)
        {
            _activityDal.Update(activity);
        }
    }
}
