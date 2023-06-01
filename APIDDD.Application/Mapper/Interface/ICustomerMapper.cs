using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDDD.Application.Dtos;
using APIDDD.Domain.Entities;

namespace APIDDD.Infrastructure.CrossCutting.Interface
{
    public interface ICustomerMapper
    {
        Customer MapperDtoToEntity(CustomerDto customer);
        IEnumerable<CustomerDto> MapperCustomerListDto(IEnumerable<Customer> customers);
        CustomerDto MapperEntitytoDto(Customer customerDto);
    }
}
