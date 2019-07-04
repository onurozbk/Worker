using System;
using System.ComponentModel.DataAnnotations;
using Worker.Core.Entities;

namespace Worker.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string RelatedPerson { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string FaxNumber { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public string Adress { get; set; }
        public string TaxCenter { get; set; }
        public string TaxNumber { get; set; }
        public short CustomerGroupId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string CustomerLogo { get; set; }
    }
}
