using CarService.DataContext.Entities.WorkOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service.InterfaceService
{
    public interface IWorkOrderService
    {
        List<WorkOrder> GetAllWorkOrder();
        WorkOrder GetWorkOrderById(int id);

        WorkOrder CreateWorkOrder(WorkOrder workOrder);

        WorkOrder UpdateWorkOrder(WorkOrder workOrder);

        void DeleteWorkOrder(int id);
    }
}
