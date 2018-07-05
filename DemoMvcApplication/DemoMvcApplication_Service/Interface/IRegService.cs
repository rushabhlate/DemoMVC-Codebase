using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMvcApplication_Entity;

namespace DemoMvcApplication_Service.Interface
{
   public interface IRegService
    {

       bool Insert(RegistrationEntity entity);
       List<RegistrationEntity> Get();
       RegistrationEntity GetbyId(int id);
       bool Update(RegistrationEntity entity);
       bool Delete(int id);
    }
}
