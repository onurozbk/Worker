using System;
using System.Collections.Generic;
using System.Text;
using Worker.Core.Entities;

namespace Worker.Entities.Concrete
{
    public class Category:IEntity
    {
        public int  CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
