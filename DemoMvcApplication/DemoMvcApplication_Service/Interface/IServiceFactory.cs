using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMvcApplication_Service.Service;
namespace DemoMvcApplication_Service.Interface
{
   public interface IServiceFactory
    {
       RegService RegService { get; }
        //BranchService BranchService { get; }
        //ContactService ContactService { get; }
        //ParkingService ParkingService { get; }
    }
}
