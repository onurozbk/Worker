using Microsoft.VisualStudio.TestTools.UnitTesting;
using Worker.Business.Abstract;
using Worker.Entities.Concrete;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public UnitTest1(IProductService productService)
        {
            _productService = productService;
        }


        [TestMethod]
        public void TestMethod1()
        {
            Product product = new Product();
            product.ProductName = "test";
            _productService.Add(product);
        }

        
    }
}
