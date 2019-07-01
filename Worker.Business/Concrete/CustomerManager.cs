using System;
using System.Collections.Generic;
using Worker.Business.Abstract;
using Worker.Business.Helpers;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private IMailSender _mailSender;
        public CustomerManager(ICustomerDal customerDal, IMailSender mailSender)
        {
            _customerDal = customerDal;
            _mailSender = mailSender;
        }
        public void Add(Customer customer)


        {
            _customerDal.Add(customer);
            _mailSender.CustomerAddedAsync(customer);
        }

        public void Delete(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByCustomerGroup(short groupId)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
