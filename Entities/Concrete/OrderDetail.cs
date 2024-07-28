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
        public int OrderID { get; set; }  // Foreign Key
        public int ProductID { get; set; }  // Foreign Key
        public int Quantity { get; set; }


        public decimal TotalAmount { get => Product.Price * Quantity; }//Bu kodlar bazaya getmir, cekde gorunecek!!a
        public Product Product { get; set; }
    }
}
