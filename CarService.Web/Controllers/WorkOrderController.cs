using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarService.DataContext.Entities.WorkOrder;
using CarService.Service.InterfaceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderController : ControllerBase
    {
        private IWorkOrderService _workOrderService;

        public WorkOrderController(IWorkOrderService workOrderService)
        {
            _workOrderService = workOrderService;
        }
        /// <summary>
        /// Get All WorkOrder
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<WorkOrder> GetWorkOrder()
        {

            return _workOrderService.GetAllWorkOrder();
        }

        /// <summary>
        /// Get WorkOrder By WorkOrderId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public WorkOrder GetWorkOrder(int id)
        {
            return _workOrderService.GetWorkOrderById(id);
        }


        /// <summary>
        /// Create WorkOrder
        /// </summary>
        /// <param name="workOrder"></param>
        /// <returns></returns>
        [HttpPost]
        public WorkOrder CreateAppointment([FromBody]WorkOrder workOrder)
        {
            return _workOrderService.CreateWorkOrder(workOrder);
        }

        /// <summary>
        /// Update WorkOrder
        /// </summary>
        /// <param name="WorkOrder"></param>
        /// <returns></returns>
        [HttpPut]
        public WorkOrder UpdateWorkOrder([FromBody]WorkOrder workOrder)
        {
            return _workOrderService.UpdateWorkOrder(workOrder);
        }

        /// <summary>
        /// Delete WorkOrder By WorkOrderId
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteWorkOrder(int id) // delete WorkOrder by id
        {
            _workOrderService.DeleteWorkOrder(id);
        }
    }
}