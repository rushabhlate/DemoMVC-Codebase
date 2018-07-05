using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoMvcApplication_Service.Service;
using DemoMvcApplication_Entity;

namespace DemoMvcApplication_REST.Controllers
{
    public class RegAPiController : ApiController
    {

        RegService service = ServiceFactory.GetInstance().RegService;

        [HttpGet]
        public object Get()
        {
            var records = service.Get();

            return records;
        }

        [HttpGet]
        public object GetByid(int id)
        {
            var records = service.GetbyId(id);

            return records;
        }

        [HttpPost]
        public object Insert(RegistrationEntity entity)
        {
            var isinserted = service.Insert(entity);
            if (isinserted)
            {
                var json = true;
               
                return json;
            }
            else
                return false;
        }

        [HttpPut]
        public object Update(RegistrationEntity entity)
        {
            var isupdated = service.Update(entity);
            if (isupdated)
            {
                return true;
            }
            else
                return false;
        }
        [HttpDelete]

        public object Delete(int id)
        {
            var isdeleted = service.Delete(id);
           
                return isdeleted;
          
          
        }


    }
}
