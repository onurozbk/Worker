using System.Collections.Generic;
using Worker.Business.Abstract;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.Business.Concrete
{
    class ActivityManager : IActivityService
    {
        private IActivityDal _activityDal;
        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public void Add(Activity activity)
        {
            _activityDal.Add(activity);
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
