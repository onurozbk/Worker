using System;
using System.Collections.Generic;
using System.Text;
using Worker.Entities.Concrete;

namespace Worker.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetByCustomerGroup(short groupId);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
        Customer GetById(int customerId);
    }
}
