using System;
using System.Collections.Generic;
using System.Text;
using Worker.Entities.Concrete;

namespace Worker.Business.Abstract
{
    public interface IActivityService
    {
        List<Activity> GetAll();
        List<Activity> GetByRelatedUser(int relatedUser);
        void Add(Activity activity);
        void Update(Activity activity);
        void Delete(int activityId);
    }
}
