using Core.DataRepositories.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class EFOrderDal : BaseRepository<Order, ShoppingContext>, IOrderDal
    {
        public EFOrderDal(ShoppingContext context) : base(context)
        {
        }
    }
}
