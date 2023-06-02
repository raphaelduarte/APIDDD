using APIDDD.Application.Dtos;
using APIDDD.Application.Interfaces;
using APIDDD.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IApplicationCustomerService _customerService;

        public CustomerController(IApplicationCustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_customerService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_customerService.GetById(id));
        }

        [HttpPost("{id}")]
        public ActionResult<string> Post([FromBody] CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null)
                {
                    return NotFound();
                }

                _customerService.Add(customerDto);
                return Ok("Customer registed");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(
            [FromRoute] int id,
            [FromServices] CustomerDto customerDto
        )
        {
            customerDto = _customerService.GetById(id);
            _customerService.Remove(customerDto);

            return Ok("The user was removed");
        }

        [HttpPut("{id}")]
        public ActionResult Update(
            [FromRoute] int id,
            [FromServices] CustomerDto customerDto
        )
        {
            customerDto = _customerService.GetById(id);
            _customerService.Update(customerDto);

            return Ok("The user was updated");
        }
    }
}
