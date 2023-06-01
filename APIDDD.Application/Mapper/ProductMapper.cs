using APIDDD.Application.Dtos;
using APIDDD.Domain.Entities;
using APIDDD.Infrastructure.CrossCutting.Interface;

namespace APIDDD.Infrastructure.CrossCutting.Mapper
{
    public class ProductMapper : IProductMapper
    {
        public Product MapperDtoToEntity(ProductDto productDto)
        {
            Product product = new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Price = productDto.Price,
            };
            return product;
        }

        public IEnumerable<ProductDto> MapperCustomerListDto(IEnumerable<Product> products)
        {
            var dto = products.Select(c => new ProductDto()
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price,
            });
            return dto;
        }

        public ProductDto MapperEntitytoDto(Product product)
        {
            var ProductDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
            return ProductDto;
        }
    }
}
