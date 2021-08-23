using CarService.DataContext.Entities.Appointment;
using CarService.DataContext.EntityFrameworkCore;
using CarService.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarService.Service.Manager
{
    public class AppointmentManager : IAppointmentService
    {
        public Appointment CreateAppointment(Appointment appointment)
        {
            using (var appointmentDbContext = new CarServiceDbContext())
            {
                appointment.confirmation = false;
                appointmentDbContext.Appointments.Add(appointment);
                appointmentDbContext.SaveChanges();

                return appointment;
            }
        }

        public void DeleteAppointment(int id)
        {
            using (var appointmentDbContext = new CarServiceDbContext())
            {
                var deleteAppointment = GetAppointmentById(id);
                appointmentDbContext.Appointments.Remove(deleteAppointment);
                appointmentDbContext.SaveChanges();
            }
        }

        public List<Appointment> GetAllAppointment()
        {
            using (var appointmentDbContext = new CarServiceDbContext())

                return appointmentDbContext.Appointments.ToList();
        }

        public Appointment GetAppointmentById(int id)
        {
            using (var appointmentDbContext = new CarServiceDbContext())

                return appointmentDbContext.Appointments.Find(id);
        }

        public Appointment UpdateAppointment(Appointment appointment)
        {
            using (var appointmentDbContext = new CarServiceDbContext())
            {
                appointmentDbContext.Appointments.Update(appointment);
                appointmentDbContext.SaveChanges();
                return appointment;
            }
        }
    }
}
