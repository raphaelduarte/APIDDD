using APIDDD.Domain.Core.Interfaces;
using APIDDD.Domain.Core.Services;
using APIDDD.Domain.Entities;

namespace APIDDD.Domain.Services
{
    public class CustomerService : BaseService<Customer>,  ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) :base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
