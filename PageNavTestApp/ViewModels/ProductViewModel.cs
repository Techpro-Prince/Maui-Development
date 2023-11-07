using PageNavTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavTestApp.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public ProductViewModel()
        {
            Product = new Product()
            {
                ID= 1,
                ProductName="Glucon-D",
                ProductPrice=50,
                AvailQty=5,
                ProductWeight=100,
                IsPopular=true,
                CreatedDate= DateTime.Now,
            };
        }
    }
}
