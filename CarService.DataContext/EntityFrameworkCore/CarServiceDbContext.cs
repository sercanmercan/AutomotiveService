using CarService.DataContext.Entities.Appointment;
using CarService.DataContext.Entities.Automotive;
using CarService.DataContext.Entities.Customers;
using CarService.DataContext.Entities.WorkOrder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.DataContext.EntityFrameworkCore
{
    public class CarServiceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-9CU05GT;Database=CarService;Trusted_Connection=True;");

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Automotive> Automotives { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
    }
}
