using CarService.DataContext.Entities.WorkOrder;
using CarService.DataContext.EntityFrameworkCore;
using CarService.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarService.Service.Manager
{
    public class WorkOrderManager : IWorkOrderService
    {
        public WorkOrder CreateWorkOrder(WorkOrder workOrder)
        {
            using (var workOrderDbContext = new CarServiceDbContext())
            {
                workOrderDbContext.WorkOrders.Add(workOrder);
                workOrderDbContext.SaveChanges();

                AppointmentManager appointmentManager = new AppointmentManager();
                var appointment = workOrderDbContext.Appointments.Where(x => x.Id == workOrder.appointmentId).FirstOrDefault();
                if (workOrder.appointmentId > 0)
                {
                    appointmentManager.UpdateAppointment(new DataContext.Entities.Appointment.Appointment 
                    {
                        Id = appointment.Id,
                        confirmation = true,
                        automotiveId = appointment.automotiveId,
                        startAt = appointment.startAt,
                        endAt = appointment.endAt,
                        description = appointment.description,
                        createdOn = appointment.createdOn
                    });
                }

                return workOrder;
            }
        }

        public void DeleteWorkOrder(int id)
        {
            using (var workOrderDbContext = new CarServiceDbContext())
            {
                var deleteWorkOrder = GetWorkOrderById(id);
                workOrderDbContext.WorkOrders.Remove(deleteWorkOrder);
                workOrderDbContext.SaveChanges();
            }
        }

        public List<WorkOrder> GetAllWorkOrder()
        {
            using (var workOrderDbContext = new CarServiceDbContext())

                return workOrderDbContext.WorkOrders.ToList();
        }

        public WorkOrder GetWorkOrderById(int id)
        {
            using (var workOrderDbContext = new CarServiceDbContext())

                return workOrderDbContext.WorkOrders.Find(id);
        }

        public WorkOrder UpdateWorkOrder(WorkOrder workOrder)
        {
            using (var workOrderDbContext = new CarServiceDbContext())
            {
                workOrderDbContext.WorkOrders.Update(workOrder);
                workOrderDbContext.SaveChanges();
                return workOrder;
            }
        }
    }
}
