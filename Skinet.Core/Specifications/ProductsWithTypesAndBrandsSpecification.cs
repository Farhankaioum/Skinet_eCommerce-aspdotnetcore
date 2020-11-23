using Skinet.Core.Entities;

namespace Skinet.Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddIncludeTypes();
        }

        public ProductsWithTypesAndBrandsSpecification(string sort, int? brandId, int? typeId)
            : base(x => 
                (!brandId.HasValue || x.ProductBrandId == brandId) &&
                (!typeId.HasValue || x.ProductTypeId == typeId)
            )
        {
            AddIncludeTypes();

            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDecending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
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
