using CarService.DataContext.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataContext.Entities.Appointment
{
    public class Appointment : BaseEntity
    {
        [NotNull]
        public int automotiveId { get; set; }

        [NotNull]
        public DateTime startAt { get; set; }

        [NotNull]
        public DateTime endAt { get; set; }
        public string description { get; set; }

        [DefaultValue(false)]
        public bool confirmation { get; set; }
       
        public DateTime createdOn { get; set; }

    }
}
