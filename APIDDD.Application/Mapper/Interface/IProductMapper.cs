using APIDDD.Application.Dtos;
using APIDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDDD.Infrastructure.CrossCutting.Interface
{
    public interface IProductMapper
    {
        Product MapperDtoToEntity(ProductDto productDto);
        IEnumerable<ProductDto> MapperCustomerListDto(IEnumerable<Product> products);
        ProductDto MapperEntitytoDto(Product product);
    }
}
