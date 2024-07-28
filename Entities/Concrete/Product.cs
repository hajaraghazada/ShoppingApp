using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int BrandId { get; set; }  // Foreign Key
        public string ImageURL { get; set; }
        public Delivery DeliveryType { get; set; }
        public bool IsDiscount {  get; set; }
        public decimal DiscountRate { get; set; }


        public List<Review> Reviews { get; set; }  // List of Review
       
    }
}
