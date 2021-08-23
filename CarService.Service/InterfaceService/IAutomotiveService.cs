using CarService.DataContext.Entities.Automotive;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service.InterfaceService
{
    public interface IAutomotiveService
    {
        List<Automotive> GetAllAutomotive();
        Automotive GetAutomotiveById(int id);

        Automotive CreateAutomotive(Automotive automotive);

        Automotive UpdateAutomotive(Automotive automotive);

        void DeleteAutomotive(int id);
    }
}
