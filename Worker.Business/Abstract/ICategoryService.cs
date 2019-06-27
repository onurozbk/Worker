using System.Collections.Generic;
using Worker.Entities.Concrete;

namespace Worker.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        //void Add(Category category);
        //void Update(Category category);
        //void Delete(int categoryId);
    }
}
