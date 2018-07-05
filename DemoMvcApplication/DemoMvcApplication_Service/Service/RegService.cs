using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMvcApplication_Service.Interface;
using DemoMvcApplication_Entity;
using DemoMVCApplication_DB.DAL;
namespace DemoMvcApplication_Service.Service
{
   public class RegService:IRegService
    {

       cl_Reg obj = new cl_Reg();
    public bool Insert(RegistrationEntity entity)
     {
         try
         {
             return obj.Insert(entity);
         }
         catch (Exception ex)
         {
             throw;
         }
    }
    public List<RegistrationEntity> Get()
    {
        try
        {
            return obj.Get();
        }
        catch (Exception ex)
        {
            throw;
        }
    }


    public RegistrationEntity GetbyId(int id)
        {
            try
            {
                return obj.GetbyId(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    public bool Update(RegistrationEntity entity)
        {
            try
            {
                return obj.Update(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    public bool Delete(int id)
        {
            try
            {
                return obj.Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
