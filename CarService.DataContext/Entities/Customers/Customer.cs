using CarService.DataContext.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CarService.DataContext.Entities.Customers
{
    public class Customer: BaseEntity
    {
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [NotNull]
        public string tcNo { get; set; }

        [NotNull]
        public string telNo { get; set; }

        [NotNull]
        [StringLength(50)]
        public string email { get; set; }       

        public DateTime createdOn { get; set; }
    }
}
