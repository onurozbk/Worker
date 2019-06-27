using System;
using Worker.Core.Entities;

namespace Worker.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string NameSurname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDay { get; set; }
        public string CellPhone { get; set; }
        public short UserType { get; set; }
        public bool IsActive { get; set; }
        public string Image { get; set; }
        public DateTime CreateUser { get; set; }
        public DateTime UpdateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
