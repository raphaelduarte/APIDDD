using APIDDD.Application.Dtos;
using APIDDD.Application.Interfaces;
using APIDDD.Domain.Core.Services;
using APIDDD.Infrastructure.CrossCutting.Interface;

namespace APIDDD.Application
{
    public class ApplicationProductService : IApplicationProductService
    {
        private readonly IProductService _productService;
        private readonly IProductMapper _productMapper;

        public ApplicationProductService(IProductService productService, IProductMapper productMapper)
        {
            _productService = productService;
            _productMapper = productMapper;
        }
        public void Add(ProductDto productDto)
        {
            var productEntity = _productMapper.MapperDtoToEntity(productDto);
            _productService.Add(productEntity);

        }

        public void Update(ProductDto productDto)
        {
            var productEntity = _productMapper.MapperDtoToEntity(productDto);
            _productService.Update(productEntity);
        }

        public void Remove(ProductDto productDto)
        {
            var productEntity = _productMapper.MapperDtoToEntity(productDto);
            _productService.Remove(productEntity);

        }

        public IEnumerable<ProductDto> GetAll()
        {
            var productDto = _productService.GetAll();
            return _productMapper.MapperCustomerListDto(productDto);
        }

        public ProductDto GetById(int id)
        {
            var productEntity = _productService.GetById(id);
            return _productMapper.MapperEntitytoDto(productEntity);
        }
    }
}
