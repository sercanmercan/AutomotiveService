using CarService.DataContext.Entities.Appointment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service.InterfaceService
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllAppointment();
        Appointment GetAppointmentById(int id);

        Appointment CreateAppointment(Appointment appointment);

        Appointment UpdateAppointment(Appointment appointment);

        void DeleteAppointment(int id);
    }
}
