using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ClassLibrary2
{
    public class bussiness
    {

        public List<Product> Products;
        public List<Product> GetProducts()
        {
            if (Products.Count == 0)
            {
                Products.Add(new Product { productid = 1, product_name = "abc", rate = 120, qty = 5 });
            }
            return Products;
        }
    }
    class Myclass :Product
    {

    }
}
