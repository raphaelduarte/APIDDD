using APIDDD.Application.Dtos;

namespace APIDDD.Application.Interfaces
{
    public interface IApplicationProductService
    {
        void Add(ProductDto product);
        void Update(ProductDto product);
        void Remove(ProductDto product);
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(int id);
    }
}
