﻿using CSharpEgitimKampi301.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.Bussiness.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Object> TGetProductsWithCategory();
    }
}
