using CarService.DataContext.SeedWork;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CarService.DataContext.Entities.Automotive
{
    public class Automotive : BaseEntity
    {
        [NotNull]
        public string licensePlate { get; set; }

        public string brand { get; set; }

        public string model { get; set; }

        public int modelYear { get; set; }

        [NotNull]
        public int customerId { get; set; }
        
        public DateTime createdOn { get; set; }
    }
}
