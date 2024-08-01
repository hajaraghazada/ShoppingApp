using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderDetail:BaseEntity
    {
        public int OrderID { get; set; }  
        public int ProductID { get; set; } 
        public int Quantity { get; set; }


        public decimal TotalAmount { get => Product.Price * Quantity; }//Bu kodlar bazaya getmir, cekde gorunecek!!
        public Order Order { get; set; }
        public Product Product { get; set; }
     
    }
}
