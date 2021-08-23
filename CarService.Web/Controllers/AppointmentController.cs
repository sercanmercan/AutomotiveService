using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarService.DataContext.Entities.Appointment;
using CarService.Service.InterfaceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        /// <summary>
        /// Get All Appointment
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Appointment> GetAppointment()
        {

            return _appointmentService.GetAllAppointment();
        }

        /// <summary>
        /// Get Appointment By AppointmentId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Appointment GetAppointment(int id)
        {
            return _appointmentService.GetAppointmentById(id);
        }


        /// <summary>
        /// Create Appointment
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPost]
        public Appointment CreateAppointment([FromBody]Appointment appointment)
        {
            return _appointmentService.CreateAppointment(appointment);
        }

        /// <summary>
        /// Update Appointment
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPut]
        public Appointment UpdateAppointment([FromBody]Appointment appointment)
        {
            return _appointmentService.UpdateAppointment(appointment);
        }

        /// <summary>
        /// Delete Appointment By AppointmentId
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteAppointment(int id) // delete Appointment by id
        {
            _appointmentService.DeleteAppointment(id);
        }
    }
}