using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet

    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            // IDispossable pattern implementation of c#

            using (NortwindContext context=new NortwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State =EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Product entity)
        {

            using (NortwindContext context = new NortwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NortwindContext context=new NortwindContext())
            {
                return filter == null                                       // filtre null mu 
                    ? context.Set<Product>().ToList()                       // evet ise set et listele
                    : context.Set<Product>().Where(filter).ToList();        // hayır ise
            }
        }

        public void Update(Product entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
