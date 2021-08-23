using CarService.DataContext.SeedWork;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CarService.DataContext.Entities.WorkOrder
{
    public class WorkOrder : BaseEntity
    {
        [NotNull]
        public int automotiveId { get; set; }
        public int appointmentId { get; set; }
        public string description { get; set; }
        public DateTime createdOn { get; set; }
    }
}
