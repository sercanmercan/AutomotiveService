using CarService.DataContext.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Service.InterfaceService
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        Customer CreateCustomer(Customer customer);      
        Customer UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);

    }
}
