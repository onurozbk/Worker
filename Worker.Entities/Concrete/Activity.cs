using System;
using System.Collections.Generic;
using System.Text;
using Worker.Core.Entities;

namespace Worker.Entities.Concrete
{
    public class Activity:IEntity
    {
        public int ActivityId { get; set; }
        public int CustomerId { get; set; }
        public short ActivityTypeId { get; set; }
        public string ActivityBarcode { get; set; }
        public short ActivitytOptionsId { get; set; }
        public short ActivitytSatusId { get; set; }
        public int RelatedUser { get; set; }
        public string ActivitytDescription { get; set; }
        public short ActivityPriority { get; set; }
        public short ActivityStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatedUser { get; set; }
        public int UpdatedUser { get; set; }
        public bool IsActive { get; set; }

    }
}
