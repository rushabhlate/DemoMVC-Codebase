using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMvcApplication_Service.Interface;
namespace DemoMvcApplication_Service.Service
{
  public  class ServiceFactory:IServiceFactory
    {
      private static IServiceFactory Instance;
      private RegService regservie = new RegService();
    //  private UserService Userservice = new UserService();
     // private BranchService Branchservice = new BranchService();

      static ServiceFactory()
      {
          // Create the only instance of this class
          Instance = new ServiceFactory();

      }
      private ServiceFactory() { }
      public static IServiceFactory GetInstance()
      {
          return Instance;
      }
      public RegService RegService
      {
          get { return regservie; }
      }

     
        //public BranchService BranchService
        //{
        //    get { return Branchservice; }
        //}
    }
}
