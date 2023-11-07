using PageNavTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavTestApp.ViewModels
{
   public  class CollectionViewModel
    {
        public List<Product> ProductView {  get; set; }=new List<Product>();
        public CollectionViewModel()
        {
            ProductView.Add(new Product
            {
                ProductName= "Parle-G",
                AvailQty=10,
                ProductWeight=100,


            });
            ProductView.Add(new Product
            {
                ProductName= "Britania",
                AvailQty=5,
                ProductWeight=50,

            });

        }
    }
}
