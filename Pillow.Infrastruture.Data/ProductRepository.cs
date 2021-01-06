using Microsoft.EntityFrameworkCore;
using Pillow.Core.Entites;
using Pillow.Infrastruture.Sql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pillow.Infrastruture.Data
{
    public class ProductRepository
    {
        private readonly DemoContext context;

        public ProductRepository(DemoContext context)
        {
            this.context = context;
        }


        public Product Get(int ProductId)
        {
            return context.Products.Include(a=>a.Medias)
                .Include(a=>a.Category)
                .First(a=>a.ProductID==ProductId);
        }


        public List<Product> GetFilterProducts(string category, int pageNumber, int PageSize)
        {
          
            IQueryable<Product> query = context.Products.Include(a => a.Category).Include(a => a.Medias);
            if (category!="All")
            {
               query.Where(a => a.Category.CategoryName == category).ToList();
           
            }
          
          return query.Skip(pageNumber - 1).Take(PageSize).ToList();
        }

    }
}
