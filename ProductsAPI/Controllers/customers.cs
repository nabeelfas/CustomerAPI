

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsAPI.Data;
using ProductsAPI.Models;
using ProductsAPI.Services;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class customersController : ControllerBase
    {
        private readonly ICustomerService _customerservice;


        public customersController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }

        // GET: api/customers
        [HttpGet]
        public async Task<IEnumerable<CustomerMaster>> Get()
        {
            return await _customerservice.GetCustomersList();
        }
        // GET: api/customers/5
        [HttpGet("{customercode}")]

        public async Task<ActionResult<CustomerMaster>> Get(int customerCode)
        {
            var customer = await _customerservice.GetCustomerById(customerCode);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // POST: api/customers
        [HttpPost]
        public async Task<ActionResult<CustomerMaster>> Post(CustomerMaster customer)
        {
            await _customerservice.CreateCustomer(customer);

            return CreatedAtAction("Post", new { customercode = customer.CustomerCode }, customer);
        }
        // PUT: api/customers/5
        [HttpPut("{customercode}")]
        public async Task<IActionResult> Put(int customercode, CustomerMaster customer)
        {
            if (customercode != customer.CustomerCode)
            {
                return BadRequest("Not a valid customer id");
            }

            await _customerservice.UpdateCustomer(customer);

            return NoContent();
        }
        // DELETE: api/customers/5
        [HttpDelete("{customercode}")]
        public async Task<IActionResult> Delete(int customercode)
        {
            if (customercode <= 0)
                return BadRequest("Not a valid customer id");

            var customer = await _customerservice.GetCustomerById(customercode);
            if (customer == null)
            {
                return NotFound();
            }

            await _customerservice.DeleteCustomer(customer);

            return NoContent();
        }
    }
}
