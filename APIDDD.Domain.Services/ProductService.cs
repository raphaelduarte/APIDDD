using APIDDD.Domain.Core.Interfaces;
using APIDDD.Domain.Core.Services;
using APIDDD.Domain.Entities;

namespace APIDDD.Domain.Services
{
    public class ProductService : BaseService<Product> , IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) :base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
