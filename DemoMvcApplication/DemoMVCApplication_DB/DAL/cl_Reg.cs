using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMvcApplication_Entity;
using DemoMVCApplication_DB.Database;
namespace DemoMVCApplication_DB.DAL
{
  public  class cl_Reg
    {


      public bool Insert(RegistrationEntity entity)
      {
          bool isinserted = false;
          using (var db = new DemoDBEntities())
          {
              RegistartionMaster record = new RegistartionMaster();
              record.Address = entity.Address;
              record.Emailid = entity.Emailid;
              record.FullName = entity.FullName;
              record.Gender = entity.Gender;
              record.IsActive = true;
              record.Mobno = entity.Mobno;

              db.RegistartionMasters.Add(record);
              db.SaveChanges();
              isinserted = true;

          }

          return isinserted;


      }

      public List<RegistrationEntity> Get()
      {
          List<RegistrationEntity> list = new List<RegistrationEntity>();

          using (var db = new DemoDBEntities())
          {
              var records = db.RegistartionMasters.Where(x => x.IsActive == true).ToList();
              
              foreach (var item in records)
              {
                  RegistrationEntity entity = new RegistrationEntity();
                  entity.Id = item.Id;
                  entity.FullName = item.FullName;
                  entity.Gender = item.Gender;
                  entity.Emailid = item.Emailid;
                  entity.Address = item.Address;
                  entity.Mobno = item.Mobno;
                  list.Add(entity);


              }


          }


          return list;
      }

      public RegistrationEntity GetbyId(int id)
      {
          RegistrationEntity entity = new RegistrationEntity();
          using (var db = new DemoDBEntities())
          {
              var record = db.RegistartionMasters.Find(id);
              if (record != null)
              {
                  entity.Id = record.Id;
                  entity.FullName = record.FullName;
                  entity.Gender = record.Gender;
                  entity.Emailid = record.Emailid;
                  entity.Address = record.Address;
                  entity.Mobno = record.Mobno;

              }


          }
          return entity;

      }

      public bool Update(RegistrationEntity entity)
      {
          bool isupated = false;
          using (var db = new DemoDBEntities())
          {
              RegistartionMaster record = db.RegistartionMasters.Find(entity.Id);
              record.Address = entity.Address;
              record.Emailid = entity.Emailid;
              record.FullName = entity.FullName;
              record.Gender = entity.Gender;
              record.IsActive = true;
              record.Mobno = entity.Mobno;

             
              db.SaveChanges();
              isupated = true;

          }
          return isupated;

      }

      public bool Delete(int id)
      {
          bool isdeleted = false;
          using (var db = new DemoDBEntities())
          {
              var record = db.RegistartionMasters.Find(id);
              record.IsActive = false;
              db.SaveChanges();
              isdeleted = true;
          }
          return isdeleted;
      }


    }
}
