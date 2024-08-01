﻿using Core.DataRepositories.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class EFCategoryDal : BaseRepository<Category, ShoppingContext>, ICategoryDal
    {
        public EFCategoryDal(ShoppingContext context) : base(context)
        {
        }
    }
}