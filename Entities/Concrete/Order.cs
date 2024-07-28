using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Order:BaseEntity
    {
        public int UserID { get; set; }  // Foreign Key
        public decimal TotalPrice { get; set; } //--Order detaildaki Total Amountlarin cemi
        public Status Status { get; set; }  // Enum for Pending, Completed, Cancelled

        public List<Order> OrderDetails { get; set; }  
    }
}
