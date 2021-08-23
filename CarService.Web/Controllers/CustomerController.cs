using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarService.DataContext.Entities.Customers;
using CarService.Service.InterfaceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Customer> GetCustomer()
        {

            return _customerService.GetAllCustomer();
        }

        /// <summary>
        /// Get Customer By CustomerId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
            return _customerService.GetCustomerById(id);
        }


        /// <summary>
        /// Create Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public Customer CreateCustomer([FromBody]Customer customer)
        {
            return _customerService.CreateCustomer(customer);
        }


        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut]
        public Customer UpdateCustomer([FromBody]Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }

        /// <summary>
        /// Delete Customer By CustomerId
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteCustomer(int id) // delete customer by id
        {
            _customerService.DeleteCustomer(id);
        }

    }
}