using System;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NortwindContext>, ICategoryDal
    {
    }
}
