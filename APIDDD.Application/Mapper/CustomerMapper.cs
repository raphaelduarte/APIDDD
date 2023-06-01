using APIDDD.Application.Dtos;
using APIDDD.Domain.Entities;
using APIDDD.Infrastructure.CrossCutting.Interface;

namespace APIDDD.Infrastructure.CrossCutting.Mapper
{
    public class CustomerMapper : ICustomerMapper
    {
        IEnumerable<CustomerDto> _customerDto = new List<CustomerDto>();

        public Customer MapperDtoToEntity(CustomerDto customerDto)
        {
            Customer customer = new Customer()
            {
                Id = customerDto.Id,
                Name = customerDto.Name,
                LastName = customerDto.LastName,
                Email = customerDto.Email,
            };

            return customer;
        }

        public IEnumerable<CustomerDto> MapperCustomerListDto(IEnumerable<Customer> customers)
        {
            var dto = customers.Select(c => new CustomerDto
            {
                Id = c.Id,
                Name = c.Name,
                LastName = c.LastName,
                Email = c.Email,
            });
            return dto;
        }

        public CustomerDto MapperEntitytoDto(Customer customer)
        {
            var customerDto = new CustomerDto()
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                Email = customer.Email,
            };
            return customerDto;

        }
    }
}
