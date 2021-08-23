using CarService.DataContext.Entities.Automotive;
using CarService.DataContext.EntityFrameworkCore;
using CarService.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarService.Service.Manager
{
    public class AutomotiveManager : IAutomotiveService
    {
        /// <summary>
        /// Create Automotive
        /// </summary>
        /// <returns></returns>
        public Automotive CreateAutomotive(Automotive automotive)
        {
            using (var automotiveDbContext = new CarServiceDbContext())
            {
                automotiveDbContext.Automotives.Add(automotive);
                automotiveDbContext.SaveChanges();

                return automotive;
            }
        }

        /// <summary>
        /// Delete Automotive
        /// </summary>
        /// <returns></returns>
        public void DeleteAutomotive(int id)
        {
            using (var automotiveDbContext = new CarServiceDbContext())
            {
                var deleteAutomotive = GetAutomotiveById(id);
                automotiveDbContext.Automotives.Remove(deleteAutomotive);
                automotiveDbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Get Automotive By Id
        /// </summary>
        /// <returns></returns>
        public Automotive GetAutomotiveById(int id)
        {
            using (var automotiveDbContext = new CarServiceDbContext())

                return automotiveDbContext.Automotives.Find(id);
        }

        /// <summary>
        /// Get All Automotive
        /// </summary>
        /// <returns></returns>
        public List<Automotive> GetAllAutomotive()
        {
            using (var automotiveDbContext = new CarServiceDbContext())

                return automotiveDbContext.Automotives.ToList();
        }

        /// <summary>
        /// Update Automotive
        /// </summary>
        /// <returns></returns>
        public Automotive UpdateAutomotive(Automotive automotive)
        {
            using (var automotiveDbContext = new CarServiceDbContext())
            {
                automotiveDbContext.Automotives.Update(automotive);
                automotiveDbContext.SaveChanges();
                return automotive;
            }
        }
    }
}
