using APIDDD.Application.Dtos;

namespace APIDDD.Application.Interfaces
{
    public interface IApplicationCustomerService
    {
        void Add(CustomerDto customer);
        void Update(CustomerDto customer);
        void Remove(CustomerDto customer);
        IEnumerable<CustomerDto> GetAll();
        CustomerDto GetById(int id);

    }
}
