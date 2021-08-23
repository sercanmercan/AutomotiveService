using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarService.DataContext.Entities.Automotive;
using CarService.Service.InterfaceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomotiveController : ControllerBase
    {
        private IAutomotiveService _automotiveService;

        public AutomotiveController(IAutomotiveService automotiveService)
        {
            _automotiveService = automotiveService;
        }
        /// <summary>
        /// Get All Automotive
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Automotive> GetAutomotive()
        {

            return _automotiveService.GetAllAutomotive();
        }

        /// <summary>
        /// Get Automotive By AutomotiveId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Automotive GetAutomotive(int id)
        {
            return _automotiveService.GetAutomotiveById(id);
        }


        /// <summary>
        /// Create Automotive
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public Automotive CreateAutomotive([FromBody]Automotive automotive)
        {
            return _automotiveService.CreateAutomotive(automotive);
        }

        /// <summary>
        /// Update Automotive
        /// </summary>
        /// <param name="automotive"></param>
        /// <returns></returns>
        [HttpPut]
        public Automotive UpdateAutomotive([FromBody]Automotive automotive)
        {
            return _automotiveService.UpdateAutomotive(automotive);
        }

        /// <summary>
        /// Delete Automotive By AutomotiveId
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteAutomotive(int id) // delete Automotive by id
        {
            _automotiveService.DeleteAutomotive(id);
        }
    }
}