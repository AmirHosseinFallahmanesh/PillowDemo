﻿using Pillow.Core.Entites;
using System;
using System.Collections.Generic;

namespace Pillow.Core.Contracts
{
    public interface IProductRepository
    {
        Product Get(int ProductId);

        List<Product> GetFilterProducts(string category, int pageNumber, int PageSize);
    }
}