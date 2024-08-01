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
        public int UserID { get; set; }
        public decimal TotalPrice { get; set; } //--Order detaildaki Total Amountlarin cemi
        public Status Status { get; set; }  // Enum for Pending, Completed, Cancelled

        public List<OrderDetail> OrderDetails { get; set; }
        public User User { get; set; } //Lazim olsa IQuaryable ile melumatlari getiririk, lazim deyilse bazada null qalacaq...
    }
}
