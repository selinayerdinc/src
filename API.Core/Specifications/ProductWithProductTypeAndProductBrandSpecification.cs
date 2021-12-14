using API.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace API.Core.Specifications
{
    public class ProductWithProductTypeAndProductBrandSpecification : BaseSpecification<Product>
    {
            public ProductWithProductTypeAndProductBrandSpecification()
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
        public ProductWithProductTypeAndProductBrandSpecification(int id) :
            base(x=> x.Id == id)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);

        }
    }
}
