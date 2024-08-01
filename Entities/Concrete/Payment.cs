using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment:BaseEntity
    {
        public int UserId { get; set; }
        public int OrderID { get; set; }  
        public PaymentMethod PaymentMethod { get; set; }  // Enum for Credit Card, Cash
        public decimal Amount { get; set; }

        public User User { get; set; }
        public Order Order { get; set; }
    }
}
