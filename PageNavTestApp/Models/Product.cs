using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavTestApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int AvailQty { get; set; }
        public int ProductWeight { get; set; }
        public bool IsPopular { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
