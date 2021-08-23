using CarService.DataContext.Entities.Customers;
using CarService.DataContext.EntityFrameworkCore;
using CarService.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarService.Service.Manager
{
    public class CustomerManager : ICustomerService
    {

        public Customer CreateCustomer(Customer customer)
        {
            using (var customerDbContext = new CarServiceDbContext())
            {
                customerDbContext.Customers.Add(customer);
                customerDbContext.SaveChanges();

                return customer;
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var customerDbContext = new CarServiceDbContext())
            {
                var deleteCustomer = GetCustomerById(id);
                customerDbContext.Customers.Remove(deleteCustomer);
                customerDbContext.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomer()
        {
            using (var customersDbContext = new CarServiceDbContext())

                return customersDbContext.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            using (var customerDbContext = new CarServiceDbContext())

                return customerDbContext.Customers.Find(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            using (var customerDbContext = new CarServiceDbContext())
            {
                customerDbContext.Customers.Update(customer);
                customerDbContext.SaveChanges();
                return customer;
            }
        }
    }
}
