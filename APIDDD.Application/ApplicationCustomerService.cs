using APIDDD.Application.Dtos;
using APIDDD.Application.Interfaces;
using APIDDD.Domain.Core.Services;
using APIDDD.Infrastructure.CrossCutting.Interface;

namespace APIDDD.Application
{
    public class ApplicationCustomerService : IApplicationCustomerService
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerMapper _customerMapper;

        public ApplicationCustomerService(ICustomerService customerService, ICustomerMapper  customerMapper )
        {
            _customerService = customerService;
            _customerMapper = customerMapper;
        }
        public void Add(CustomerDto customerDto)
        {
            var customerEntity = _customerMapper.MapperDtoToEntity(customerDto);
            _customerService.Add(customerEntity);

        }

        public void Update(CustomerDto customerDto)
        {
            var customer = _customerMapper.MapperDtoToEntity(customerDto);
            _customerService.Update(customer);
        }

        public void Remove(CustomerDto customerDto)
        {
            var customer = _customerMapper.MapperDtoToEntity(customerDto);
            _customerService.Remove(customer);

        }

        public IEnumerable<CustomerDto> GetAll()
        {
            var customerDto = _customerService.GetAll();
            return _customerMapper.MapperCustomerListDto(customerDto);
        }

        public CustomerDto GetById(int id)
        {
            var customer = _customerService.GetById(id);
            return _customerMapper.MapperEntitytoDto(customer);
        }
    }
}
