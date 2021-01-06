using Pillow.Core.Contracts;
using Pillow.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pillow.Core.ApplicationService
{
    public class ProductService : IProdctService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Get(int ProductId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetChippestProduct()
        {
           return productRepository.GetChippestProduct()
                .Take(4).ToList();
        }

        public List<Product> GetNewestProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> ProductSearch(string category, int pageNumber, int PageSize)
        {
            throw new NotImplementedException();
        }
    }
}
