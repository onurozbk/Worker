using System.Collections.Generic;
using Worker.Business.Abstract;
using Worker.Business.Helpers;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IMailSender _mailSender;
        public ProductManager(IProductDal productDal, IMailSender mailSender)
        {
            _productDal = productDal;
            _mailSender = mailSender;
        }

        public void Add(Product product)

        {
            string mail = "Added Product " + product.ProductName;

            _productDal.Add(product);
            _mailSender.SendMail("onurozv@gmail.com", mail, mail);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
        public Product GetById(int productId)
        {
            return _productDal.Get(x=>x.ProductId==productId);
        }
    }
}
