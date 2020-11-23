using Skinet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddIncludeTypes();
        }

        public ProductsWithTypesAndBrandsSpecification(int id)
            : base(x => x.Id == id)
        {
            AddIncludeTypes();
        }

        private void AddIncludeTypes()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}
